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
    public partial class frmSalas : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmSalas()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridSalas.DataSource = dados;

            foreach (var atributos in typeof(SalasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }


            dados.Rows.Add(1, "sala b", true, 45, 41,true);

            dtGridSalas.DataSource = dados;

        }

        private void frmSalas_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalasEntidade sala = new SalasEntidade();
            sala.Id = Convert.ToInt32(numId.Text);
            sala.Nome = txtNome.Text;
            sala.IsLab = chkIsLab.Checked;
            sala.NumeroCadeiras = Convert.ToInt32(numCadeira.Value);
            sala.NumeroComputadores = Convert.ToInt32(numPc.Value);
            sala.Disponivel = chkDisponivel.Checked;

            dados.Rows.Add(sala.Linha());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            numId.Value = 0;
            txtNome.Text = "";
            numPc.Text = "";
            numCadeira.Text = "";
            chkIsLab.Checked = false;
            chkDisponivel.Checked = false;
        }
 

        private void dtGridSalas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNome.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            numPc.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            numCadeira.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            chkIsLab.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[0].Value);
            chkDisponivel.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[0].Value);
            numId.Value = Convert.ToInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[1].Value);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridSalas.Rows.RemoveAt(LinhaSelecionada);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow a = dtGridSalas.Rows[LinhaSelecionada];
            DataGridViewRow Editar = dtGridSalas.Rows[LinhaSelecionada];
            Editar.Cells[0].Value = numId.Value;
            Editar.Cells[1].Value = txtNome.Text;
            Editar.Cells[2].Value = numCadeira.Text;
            Editar.Cells[3].Value = numPc.Text;
            Editar.Cells[4].Value = chkDisponivel.Checked;
            Editar.Cells[5].Value = chkDisponivel.Checked;

        }
    }
}
