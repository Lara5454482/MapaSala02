
namespace MapaSala.Formularios
{
    partial class frmSalas
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsLab = new System.Windows.Forms.CheckBox();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNumPc = new System.Windows.Forms.NumericUpDown();
            this.txtNumCadeira = new System.Windows.Forms.NumericUpDown();
            this.dtGridSalas = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.NumericUpDown();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCadeira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de computadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de Cadeiras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id";
            // 
            // chkIsLab
            // 
            this.chkIsLab.AutoSize = true;
            this.chkIsLab.Location = new System.Drawing.Point(436, 33);
            this.chkIsLab.Name = "chkIsLab";
            this.chkIsLab.Size = new System.Drawing.Size(85, 17);
            this.chkIsLab.TabIndex = 8;
            this.chkIsLab.Text = "É laboratório";
            this.chkIsLab.UseVisualStyleBackColor = true;
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.Location = new System.Drawing.Point(527, 33);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(77, 17);
            this.chkDisponivel.TabIndex = 9;
            this.chkDisponivel.Text = "Disponível";
            this.chkDisponivel.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(610, 29);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // txtNumPc
            // 
            this.txtNumPc.Location = new System.Drawing.Point(171, 32);
            this.txtNumPc.Name = "txtNumPc";
            this.txtNumPc.Size = new System.Drawing.Size(120, 20);
            this.txtNumPc.TabIndex = 11;
            // 
            // txtNumCadeira
            // 
            this.txtNumCadeira.Location = new System.Drawing.Point(318, 32);
            this.txtNumCadeira.Name = "txtNumCadeira";
            this.txtNumCadeira.Size = new System.Drawing.Size(112, 20);
            this.txtNumCadeira.TabIndex = 12;
            // 
            // dtGridSalas
            // 
            this.dtGridSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSalas.Location = new System.Drawing.Point(12, 107);
            this.dtGridSalas.Name = "dtGridSalas";
            this.dtGridSalas.Size = new System.Drawing.Size(673, 322);
            this.dtGridSalas.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(44, 20);
            this.txtId.TabIndex = 17;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(12, 86);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(673, 20);
            this.txtPesquisa.TabIndex = 18;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Pesquisar";
            // 
            // frmSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtGridSalas);
            this.Controls.Add(this.txtNumCadeira);
            this.Controls.Add(this.txtNumPc);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.chkDisponivel);
            this.Controls.Add(this.chkIsLab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "frmSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalas";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCadeira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsLab;
        private System.Windows.Forms.CheckBox chkDisponivel;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown txtNumPc;
        private System.Windows.Forms.NumericUpDown txtNumCadeira;
        private System.Windows.Forms.DataGridView dtGridSalas;
        private System.Windows.Forms.NumericUpDown txtId;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label5;
    }
}