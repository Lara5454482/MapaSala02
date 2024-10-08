using MapaSala.DAO;
using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class FrmDisciplinaCadastrar : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        disciplinaDAO dao = new disciplinaDAO();
        public FrmDisciplinaCadastrar()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

        }

        private void dtGridDisciplina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DisciplinaEntidade d = new DisciplinaEntidade();
            d.Id = Convert.ToInt32(numId.Value);
            d.Nome = txtNomeDisciplina.Text;
            d.Sigla = txtSigla.Text;
            d.Ativo = chkAtivo.Checked;

            dados.Rows.Add(d.Linha());
            dao.Inserir(d);
            MessageBox.Show("Disciplina Excluída com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
    }

