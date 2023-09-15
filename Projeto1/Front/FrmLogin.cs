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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            var id = 0;
            using (var frm = new frmUser(id))
                frm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmMenu())
                frm.ShowDialog();
        }
    }
}
