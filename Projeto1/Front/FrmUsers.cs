using Projeto1.Back;
using Projeto1.ConnectionDB;
using Projeto1.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class frmUser : Form
    {
        public frmUser(int id)
        {
            InitializeComponent();
            if (id != 0)
                ObterProduto(id);

            Department();

        }
        public void Department()
        {
            try
            {
                using (var context = new DataContext())
                {
                    var listaDepartments = from department in context.Deparments
                                           select department;

                    cmbDepartment.DataSource = listaDepartments.ToList();
                    cmbDepartment.DisplayMember = "Name";
                    cmbDepartment.ValueMember = "IdDepartment";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha a localizar Departamento.\n" + ex.Message);
            }


        }
        public void ObterProduto(int id)
        {
            txtId.Text = id.ToString();

            try
            {
                using (var context = new DataContext())
                {

                    var User = context.Users.Find(id);
                    if (User != null)
                    {
                        txtName.Text = User.Name;
                        txtEmail.Text = User.Email;
                        TxtPassword.Text = User.Password;
                        cmbDepartment.SelectedValue = User.Deparment;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha a conectar.\n" + ex.Message);

            }
        }

        private void bntRegister_Click(object sender, EventArgs e)
        {
            if (Salvar())
                Close();
        }

        private bool Salvar()
        {
            var user = new Users();

            user.IdUser = Convert.ToInt32("0" + txtId.Text);
            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Password = BD.Criptografar(TxtPassword.Text);
            user.Deparment = Convert.ToString(cmbDepartment.SelectedValue);
            user.DataCreat = DateTime.Now;
            user.DataModified = DateTime.Now;

            try
            {
                using (var context = new DataContext())
                {
                    if (user.IdUser == 0)
                        context.Users.Add(user);
                    else
                        context.Entry(user).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar.\n" + ex.Message);
                return false;
            }

        }
    }
}


