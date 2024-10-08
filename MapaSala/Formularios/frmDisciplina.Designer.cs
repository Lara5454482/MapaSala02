
namespace MapaSala.Formularios
{
    partial class frmDisciplina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntCadastrar = new System.Windows.Forms.Button();
            this.dtGridDisciplina = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // bntCadastrar
            // 
            this.bntCadastrar.Location = new System.Drawing.Point(13, 25);
            this.bntCadastrar.Name = "bntCadastrar";
            this.bntCadastrar.Size = new System.Drawing.Size(124, 23);
            this.bntCadastrar.TabIndex = 0;
            this.bntCadastrar.Text = "Adicionar Disciplina";
            this.bntCadastrar.UseVisualStyleBackColor = true;
            this.bntCadastrar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtGridDisciplina
            // 
            this.dtGridDisciplina.AllowUserToAddRows = false;
            this.dtGridDisciplina.AllowUserToDeleteRows = false;
            this.dtGridDisciplina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDisciplina.Location = new System.Drawing.Point(12, 103);
            this.dtGridDisciplina.Name = "dtGridDisciplina";
            this.dtGridDisciplina.ReadOnly = true;
            this.dtGridDisciplina.Size = new System.Drawing.Size(549, 359);
            this.dtGridDisciplina.TabIndex = 7;
            this.dtGridDisciplina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDisciplina_CellContentClick);
            this.dtGridDisciplina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDisciplina_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pesquisar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(13, 77);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(548, 20);
            this.txtPesquisa.TabIndex = 12;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // frmDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 489);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtGridDisciplina);
            this.Controls.Add(this.bntCadastrar);
            this.Name = "frmDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDisciplina";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCadastrar;
        private System.Windows.Forms.DataGridView dtGridDisciplina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}