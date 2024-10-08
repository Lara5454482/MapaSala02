﻿using System;
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
    public partial class frmSalas : Form
    {
        DataTable dados;
        SalasDAO dao = new SalasDAO();

        int LinhaSelecionada;
        public frmSalas()
        {
            InitializeComponent();


            dtGridSalas.DataSource = dao.ObterSalas();
        }

        private void frmSalas_Load(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            txtId.Value = 0;
            txtNome.Text = "";
            txtNumPc.Text = "";
            txtNumCadeira.Text = "";
            chkIsLab.Checked = false;
            chkDisponivel.Checked = false;

        }



        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            dtGridSalas.Rows.RemoveAt(LinhaSelecionada);
            LimparCampos();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow editar = dtGridSalas.Rows[LinhaSelecionada];
            editar.Cells[0].Value = txtId.Value;
            editar.Cells[1].Value = txtNome.Text;
            editar.Cells[3].Value = Convert.ToInt32(txtNumCadeira.Value);
            editar.Cells[2].Value = Convert.ToInt32(txtNumPc.Value);
            editar.Cells[4].Value = Convert.ToBoolean(chkIsLab.Checked);
            editar.Cells[5].Value = Convert.ToBoolean(chkDisponivel.Checked);



        }

        private void dtGridSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNome.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtNumCadeira.Value = Convert.ToInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[3].Value);
            txtNumPc.Value = Convert.ToInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[2].Value);
            chkIsLab.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[4].Value);
            chkDisponivel.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[5].Value);
            txtId.Value = Convert.ToInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[0].Value);

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dtGridSalas.DataSource = dao.Pesquisar(txtPesquisa.Text);
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            SalasEntidade d = new SalasEntidade();
            d.Id = Convert.ToInt32(txtId.Value);
            d.Nome = txtNome.Text;
            d.NumeroCadeiras = Convert.ToInt32(txtNumCadeira.Value);
            d.NumeroComputadores = Convert.ToInt32(txtNumPc.Value);
            d.IsLab = chkIsLab.Checked;
            d.Disponivel = chkDisponivel.Checked;

            dao.Inserir(d);
            dtGridSalas.DataSource = dao.ObterSalas();
            LimparCampos();
        }
    }
}
