﻿using Projeto1.Back;
using Projeto1.ConnectionDB;
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
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();

            using (var context = new DataContext())
            {
                dataGridView1.DataSource = (from estoque in context.Estoque select estoque).ToList();
            }
            ConfigurarGrade();

        }
        private void ConfigurarGrade()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);
            //dataGridView1.RowHeadersWidth = 25;

            dataGridView1.Columns["Id"].HeaderText = "ID";
            dataGridView1.Columns["Id"].Width = 80;
            dataGridView1.Columns["Id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["Description"].HeaderText = "Descrição";
            dataGridView1.Columns["Description"].Width = 250;

            dataGridView1.Columns["Unit"].HeaderText = "Unidades";
            dataGridView1.Columns["Unit"].Width = 80;

            dataGridView1.Columns["IdDepartment"].HeaderText = "Departamento ID";
            dataGridView1.Columns["IdDepartment"].Width = 120;

        }
    }
}