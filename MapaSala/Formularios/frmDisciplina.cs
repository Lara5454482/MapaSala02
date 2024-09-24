using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.DAO;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class frmDisciplina : Form
    {
        DataTable dados;

        int LinhaSelecionada;

        disciplinaDAO dao = new disciplinaDAO();
        public frmDisciplina()
        {
            InitializeComponent();
            dados = new DataTable();
            
            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }


            dados = dao.ObterDisciplinas();
            dtGridDisciplina.DataSource = dados;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DisciplinaEntidade d = new DisciplinaEntidade();
            d.Id = Convert.ToInt32(numId.Value);
            d.Nome = txtNomeDisciplina.Text;
            d.Sigla = txtSigla.Text;
            d.Ativo = chkAtivo.Checked;

            disciplinaDAO dao = new disciplinaDAO();
            dao.Inserir(d);

            dtGridDisciplina.DataSource = dao.ObterDisciplinas();

            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(); 
        }

        private void LimparCampos()
        {
            numId.Value = 0;
            txtNomeDisciplina.Text = "";
            txtSigla.Text = "";
        }


        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dtGridDisciplina.DataSource = dao.Pesquisar(txtPesquisa.Text);
        }
    }
}
