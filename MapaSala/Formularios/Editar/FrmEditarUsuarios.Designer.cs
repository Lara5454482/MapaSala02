
namespace MapaSala.Formularios.Editar
{
    partial class frmEditarUsuarios
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
            this.E = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.E.SuspendLayout();
            this.SuspendLayout();
            // 
            // E
            // 
            this.E.Controls.Add(this.btnExcluir);
            this.E.Controls.Add(this.chkAtivo);
            this.E.Controls.Add(this.btnSalvar);
            this.E.Controls.Add(this.label_id);
            this.E.Controls.Add(this.txtId);
            this.E.Controls.Add(this.txtSenha);
            this.E.Controls.Add(this.label1);
            this.E.Controls.Add(this.label2);
            this.E.Controls.Add(this.txtLogin);
            this.E.Location = new System.Drawing.Point(29, 26);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(246, 319);
            this.E.TabIndex = 35;
            this.E.TabStop = false;
            this.E.Text = "groupBox1";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(122, 258);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(59, 23);
            this.btnExcluir.TabIndex = 41;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(34, 197);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 42;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(34, 258);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(59, 23);
            this.btnSalvar.TabIndex = 36;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(74, 35);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(35, 13);
            this.label_id.TabIndex = 43;
            this.label_id.Text = "label3";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(26, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 13);
            this.txtId.TabIndex = 44;
            this.txtId.Text = "Código";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(34, 150);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(34, 88);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(147, 20);
            this.txtLogin.TabIndex = 37;
            // 
            // frmEditarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 374);
            this.Controls.Add(this.E);
            this.Name = "frmEditarUsuarios";
            this.Text = "FrmEditarUsuarios";
            this.E.ResumeLayout(false);
            this.E.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox E;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
    }
}