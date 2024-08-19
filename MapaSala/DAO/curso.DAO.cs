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
    public class cursoDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public cursoDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(CursosEntidade curso)
        {
            Conexao.Open();
            string query = "Insert into Professores (Nome , Apelido) Values (@nome, @apelido) ";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", curso.Nome);
            SqlParameter parametro2 = new SqlParameter("@turno", curso.Turno);
            SqlParameter parametro3 = new SqlParameter("@ativo", curso.Ativo);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.ExecuteNonQuery();
            Conexao.Close();

        }

        public DataTable ObterCurso()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Nome, Apelido FROM Cursos Order by Id desc";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = comando.ExecuteReader();

            foreach (var atributos in typeof(CursosEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    CursosEntidade p = new CursosEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.Turno = Leitura[2].ToString();
                    p.Ativo = Leitura[3].ToBool();
                    dt.Rows.Add(p.Linha());
                }
            }


            return dt;
        }

    }
}

