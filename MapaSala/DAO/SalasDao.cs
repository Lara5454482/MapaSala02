using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaSala.DAO
{
    public class SalasDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao; 

        public SalasDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(SalasEntidade sala)
        {
            Conexao.Open();
            string query = "insert into Salas(Nome, NumeroComputadores, NumeroCadeiras, IsLab, Disponivel) Values (@nome, @numerocomputadores, @numerocadeiras, @islab, @disponivel)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", sala.Nome);
            SqlParameter parametro2 = new SqlParameter("@numerocomputadores", sala.NumeroComputadores);
            SqlParameter parametro3 = new SqlParameter("@numerocadeiras", sala.NumeroCadeiras);
            SqlParameter parametro4 = new SqlParameter("@islab", sala.IsLab);
            SqlParameter parametro5 = new SqlParameter("@disponivel", sala.Disponivel);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);


            comando.ExecuteNonQuery(); //nao retorna nd
            Conexao.Close();
        }
        public DataTable ObterSalas()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT * FROM Salas ORDER BY Id desc";
            SqlCommand Comando = new SqlCommand(query, Conexao);


            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(SalasEntidade).GetProperties())//laço de reoetição para ler listas
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows) //a linha existe? true or false
            {
                while (Leitura.Read())//para pegar mais de um registro, faz uma consulta
                {
                    SalasEntidade p = new SalasEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.NumeroCadeiras = Convert.ToInt32(Leitura[2]);
                    p.NumeroComputadores = Convert.ToInt32(Leitura[3]);
                    p.Disponivel = Convert.ToBoolean(Leitura[4]);
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
                query = "SELECT * FROM Salas ORDER BY Id desc";
            }
            else
            {
                query = "SELECT * FROM Salas WHERE NOME LIKE '%" + pesquisa + "%' ORDER BY ID desc"; //concatenação
            }

            SqlCommand Comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(SalasEntidade).GetProperties())//laço de reoetição para ler listas
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    SalasEntidade p = new SalasEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.NumeroCadeiras = Convert.ToInt32(Leitura[2]);
                    p.NumeroComputadores = Convert.ToInt32(Leitura[3]);
                    p.Disponivel = Convert.ToBoolean(Leitura[4]);
                    dt.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}