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
using MapaSala.Formularios.Editar;
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

            dtGridDisciplina.DataSource = dao.ObterDisciplinas();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FrmDisciplinaCadastrar cadastrar = new FrmDisciplinaCadastrar();

            // Inscreve-se no evento
            cadastrar.FormClosed += Fechou_cadastrar_FormClosed;

            cadastrar.ShowDialog(); // Abre o formulário como um diálogo modal

        }


        private void dtGridDisciplina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                    dtGridDisciplina.Rows[e.RowIndex].Cells[0].Value);


                frmEditarDisciplina editar = new frmEditarDisciplina(id);

                // Inscreve-se no evento
                editar.FormClosed += Fechou_Editar_FormClosed;

                editar.ShowDialog(); // Abre o formulário como um diálogo modal
            }
        }

        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {

            dtGridDisciplina.DataSource = dao.ObterDisciplinas();
        }
        private void Fechou_cadastrar_FormClosed(object sender, FormClosedEventArgs e)
        {

            dtGridDisciplina.DataSource = dao.ObterDisciplinas();
        }


        private void dtGridDisciplina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dtGridDisciplina.DataSource = dao.Pesquisar(txtPesquisa.Text);
        }
    }
}
