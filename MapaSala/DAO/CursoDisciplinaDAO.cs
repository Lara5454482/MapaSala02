﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.entidades;
using Model.Entitidades;

namespace MapaSala.DAO
{
    public class CursoDisciplinaDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public CursoDisciplinaDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }

        public void Inserir(CursoDisciplinaEntidade objeto)
        {
            Conexao.Open();
            string query = "Insert into Curso_Disciplina (Curso_Id , Disciplina_Id, Periodo) Values (@Curso_Id, @Disciplina_Id, @Periodo) ";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlParameter parametro1 = new SqlParameter("@Curso_Id", objeto.CursoId);
            SqlParameter parametro2 = new SqlParameter("@Disciplina_Id", objeto.DisciplinaId);
            SqlParameter parametro3 = new SqlParameter("@Periodo", objeto.Periodo);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.ExecuteNonQuery();
            Conexao.Close();

        }
        public DataTable ObterCursosDisciplina()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = @"SELECT C.Nome NomeCurso, D.Nome NomeDiciplina, CD.Periodo Periodo FROM CURSO_DISCIPLINA CD
                                  INNER JOIN CURSOS C ON(C.Id = CD.Curso.Id) 
                                  INNER JOIN DISCIPLINAS D ON(C.Id = CD.Disciplinas.Id)
                                  ORDER BY CD.Id DESC";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = comando.ExecuteReader();
            
            dt.Columns.Add("NomeCurso");
            dt.Columns.Add("NomeDiciplina");
            dt.Columns.Add("Periodo");

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    CursoDisciplinaEntidade p = new CursoDisciplinaEntidade();
                    p.NomeCurso = Leitura[0].ToString();
                    p.NomeDisciplina = Leitura[1].ToString();
                    p.Periodo = Leitura[2].ToString();
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
                query = @"SELECT C.Nome NomeCurso, D.Nome NomeDisciplina, CD.Periodo Periodo FROM CURSO_DISCIPLINA CD
                            INNER JOIN CURSOS C ON (C.Id = CD.Curso_Id)
                            INNER JOIN DISCIPLINAS D ON (D.Id = CD.Disciplina_Id)
                            ORDER BY CD.Id DESC";
            }
            else
            {
                query = @"SELECT C.Nome NomeCurso, D.Nome NomeDisciplina, CD.Periodo Periodo FROM CURSO_DISCIPLINA CD
                            INNER JOIN CURSOS C ON (C.Id = CD.Curso_Id)
                            INNER JOIN DISCIPLINAS D ON (D.Id = CD.Disciplina_Id)
                            WHERE D.NOME LIKE '%" + pesquisa + "%' OR C.NOME LIKE '%" + pesquisa + "%' ORDER BY CD.ID desc"; //concatenação
            }

            SqlCommand Comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = Comando.ExecuteReader(); //não entendi, erroo

            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())//laço de reoetição para ler listas
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows) //a linha existe? true or false
            {
                while (Leitura.Read())//para pegar mais de um registro, faz uma consulta
                {
                    CursoDisciplinaEntidade cursodis = new CursoDisciplinaEntidade();
                    cursodis.NomeCurso = Leitura[0].ToString();
                    cursodis.NomeDisciplina = Leitura[1].ToString();
                    cursodis.Periodo = Leitura[2].ToString();
                    dt.Rows.Add(cursodis.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}