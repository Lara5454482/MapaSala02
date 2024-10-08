﻿using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaSala.DAO
{
    public class disciplinaDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public disciplinaDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(DisciplinaEntidade disciplina)
        {
            Conexao.Open();
            string query = "Insert into Disciplinas (Nome , Sigla, Ativo) Values (@nome, @sigla, @ativo) ";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", disciplina.Nome);
            SqlParameter parametro2 = new SqlParameter("@sigla", disciplina.Sigla);
            SqlParameter parametro3 = new SqlParameter("@ativo", disciplina.Ativo);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.ExecuteNonQuery();
            Conexao.Close();

        }

        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT Id, Nome, Sigla, Ativo FROM Disciplinas";

            using (SqlConnection connection = new SqlConnection(LinhaConexao))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    // Preenche o DataTable com os dados da consulta
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    // Lida com erros, se necessário
                    throw new Exception("Erro ao acessar os dados: " + ex.Message);
                }
            }

            return dataTable;
        }

        public DataTable ObterDisciplinas ()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Nome, Sigla, Ativo FROM Disciplinas Order by Id desc";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = comando.ExecuteReader();

            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    DisciplinaEntidade p = new DisciplinaEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.Sigla = Leitura[2].ToString();
                    p.Ativo = Convert.ToBoolean(Leitura[3]);
                    dt.Rows.Add(p.Linha());
                }
            }

            Conexao.Close();
            return dt;
        }


        public DataTable Pesquisar(string pesquisa)
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "";
            if (string.IsNullOrEmpty(pesquisa))
            {
                query = "SELECT Id, Nome, Sigla, Ativo FROM Disciplinas Order by Id desc";
            }
            else
            {
                query = "SELECT Id, Nome, Sigla, Ativo FROM Disciplinas Where Nome like '%" + pesquisa + "%' Order by Id desc";
            }



            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = comando.ExecuteReader();

            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    DisciplinaEntidade p = new DisciplinaEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.Sigla = Leitura[2].ToString();
                    p.Ativo = Convert.ToBoolean(Leitura[3]);
                    dt.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return dt;

        
        }

    }
}
