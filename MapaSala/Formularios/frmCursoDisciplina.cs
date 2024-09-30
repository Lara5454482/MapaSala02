using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.DAO;
using Model.entidades;

namespace MapaSala.Formularios
{
    public partial class FrmCursoDisciplina : Form
    {
        disciplinaDAO disciplinaDAO = new disciplinaDAO();
        cursoDAO cursoDAO = new cursoDAO();
        CursoDisciplinaDAO dao = new CursoDisciplinaDAO();

        private void AtualizarGrid(DataTable dados)
        {
            dtCursoDisciplina.DataSource = dados;
        }

        public FrmCursoDisciplina()
        {
            InitializeComponent();



            cbDisciplinas.DataSource = disciplinaDAO.PreencherComboBox();
            cbDisciplinas.DisplayMember = "Nome";
            cbDisciplinas.ValueMember = "Id";

            cbCursos.DataSource = cursoDAO.PreencherComboBox();
            cbCursos.DisplayMember = "Nome";
            cbCursos.ValueMember = "Id";

            AtualizarGrid(dao.ObterCursoDisciplina());


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CursoDisciplinaDAO cursoDisciplinaDAO = new CursoDisciplinaDAO();
            CursoDisciplinaEntidade entidade = new CursoDisciplinaEntidade();
            entidade.CursoId = Convert.ToInt32(cbCursos.SelectedValue);
            entidade.DisciplinaId = Convert.ToInt32(cbDisciplinas.SelectedValue);
            entidade.Periodo = cbperiodos.SelectedItem.ToString();

            cursoDisciplinaDAO.Inserir(entidade);
            AtualizarGrid(dao.ObterCursoDisciplina());
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dtCursoDisciplina.DataSource = dao.Pesquisar(txtPesquisa.Text);
        }
    }
}