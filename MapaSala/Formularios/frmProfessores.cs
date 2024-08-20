using System;
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
    public partial class frmProfessores : Form
    {
        DataTable dados;

        int LinhaSelecionada;

        professorDAO dao = new professorDAO();
        public frmProfessores()
        {
            InitializeComponent();
            dados = new DataTable();
          

            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados = dao.ObterProfessores();
            dtGridProfessores.DataSource = dados;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade p = new ProfessoresEntidade();
            p.Id = Convert.ToInt32(numId.Value);
            p.Apelido = txtApelido.Text;
            p.Nome = txtNomeCompleto.Text;

            professorDAO dao = new professorDAO();
            dao.Inserir(p);

            dtGridProfessores.DataSource = dao.ObterProfessores();

            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtApelido.Text = "";
            txtNomeCompleto.Text = "";
            numId.Value = 0;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow a = dtGridProfessores.Rows[LinhaSelecionada];
            a.Cells[0].Value = numId.Value;
            a.Cells[1].Value = txtNomeCompleto.Text;
            a.Cells[2].Value = txtApelido.Text;

        }

        private void dtGridProfessores_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNomeCompleto.Text = dtGridProfessores.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtApelido.Text = dtGridProfessores.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            numId.Value = Convert.ToInt32(dtGridProfessores.Rows[LinhaSelecionada].Cells[0].Value);
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            dtGridProfessores.Rows.RemoveAt(LinhaSelecionada);
        }

        private void frmProfessores_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dtGridProfessores.DataSource = dao.Pesquisar(textBox1.Text);
        }
    }
}