namespace Projeto1
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEstoque = new Button();
            btnReport = new Button();
            SuspendLayout();
            // 
            // btnEstoque
            // 
            btnEstoque.Location = new Point(31, 70);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(194, 79);
            btnEstoque.TabIndex = 0;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click_1;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(31, 179);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(194, 79);
            btnReport.TabIndex = 1;
            btnReport.Text = "Relatorios";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReport);
            Controls.Add(btnEstoque);
            Name = "FrmMenu";
            Text = "Menu Inicial";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEstoque;
        private Button btnReport;
    }
}