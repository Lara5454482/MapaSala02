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
    public partial class frmCursos : Form
    {
        DataTable dados;

        int LinhaSelecionada;

        cursoDAO dao = new cursoDAO();
        public frmCursos()
        {
            InitializeComponent();
            dados = new DataTable();
          

            foreach (var atributos in typeof(CursosEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados = dao.ObterCurso();
            dtGridCursos.DataSource = dados;
        }



        private void bntExcluir_Click(object sender, EventArgs e)
        {
            dtGridCursos.Rows.RemoveAt(LinhaSelecionada);
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            numId.Value = 0;
            txtNome.Text = "";
            txtTurno.Text = "";
            chkAtivo.Checked = false;
        }
    

        private void dtGridCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNome.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtTurno.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(dtGridCursos.Rows[LinhaSelecionada].Cells[3].Value);
            numId.Value = Convert.ToInt32(dtGridCursos.Rows[LinhaSelecionada].Cells[0].Value);
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Editar = dtGridCursos.Rows[LinhaSelecionada];
            Editar.Cells[0].Value = numId.Value;
            Editar.Cells[1].Value = txtNome.Text;
            Editar.Cells[2].Value = txtTurno.Text;
            Editar.Cells[4].Value = chkAtivo.Checked;
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            CursosEntidade cursos = new CursosEntidade();
            cursos.Id = Convert.ToInt32( numId.Value);
            cursos.Nome = txtNome.Text;
            cursos.Turno = txtTurno.Text;
            cursos.Ativo = chkAtivo.Checked;

            cursoDAO dao = new cursoDAO();
            dao.Inserir(cursos);

            dtGridCursos.DataSource = dao.ObterCurso();

            LimparCampos();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dtGridCursos.DataSource = dao.Pesquisar(txtPesquisa.Text);
        }
    }
}
