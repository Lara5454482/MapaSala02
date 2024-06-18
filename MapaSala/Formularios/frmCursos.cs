using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class frmCursos : Form
    {
        BindingSource dados;
        int LinhaSelecionada;
        public frmCursos()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridCursos.DataSource = dados;
        }

        private void frmCursos_Load(object sender, EventArgs e)
        {

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
            txtNome.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            txtTurno.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(dtGridCursos.Rows[LinhaSelecionada].Cells[0].Value);
            numId.Value = Convert.ToInt32(dtGridCursos.Rows[LinhaSelecionada].Cells[1].Value);
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow a = dtGridCursos.Rows[LinhaSelecionada];
            DataGridViewRow Editar = dtGridCursos.Rows[LinhaSelecionada];
            Editar.Cells[0].Value = numId.Value;
            Editar.Cells[1].Value = txtNome.Text;
            Editar.Cells[2].Value = txtTurno.Text;
            Editar.Cells[4].Value = chkAtivo.Checked;
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            CursosEntidade cursosEntidade = new CursosEntidade();
            d = cursosEntidade;
            h.Id = Convert.ToInt32(numId.Value);
            h.Nome = txtNomeDisciplina.Text;
            h.Sigla = txtSigla.Text;

            dados.Rows.Add(h.Linha());
            LimparCampos();
        }
    }
}
