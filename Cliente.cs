using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastrarCliente
{
    public class Cliente
    {
        private int id;
        private string nome;
        private string sobrenome;
        private string email;
        private string ddd;
        private string telefone;
        private string sexo;
        private string escolaridade;
        private DateTime dataNascimento;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Email { get => email; set => email = value; }
        public string Ddd { get => ddd; set => ddd = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Escolaridade { get => escolaridade; set => escolaridade = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }

        public bool Cadastrar()
        {
            int afetados = 0;
            using (MySqlConnection con = new MySqlConnection("Server=localhost;Database=test;Uid=usuario;Pwd=senha"))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO cliente (nome,sobrenome,email,ddd,telefone,sexo,escolaridade,datanascimento) ");
                sql.Append("VALUES(@nome,@sobrenome,@email,@ddd,@telefone,@sexo,@escolaridade,@datanascimento);");

                MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);

                cmd.Parameters.AddWithValue("@Nome", this.Nome);
                cmd.Parameters.AddWithValue("@sobrenome", this.Sobrenome);
                cmd.Parameters.AddWithValue("@email", this.Email);
                cmd.Parameters.AddWithValue("@ddd", this.Ddd);
                cmd.Parameters.AddWithValue("@telefone", this.Telefone);
                cmd.Parameters.AddWithValue("@sexo", this.Sexo);
                cmd.Parameters.AddWithValue("@escolaridade", this.Escolaridade);
                cmd.Parameters.AddWithValue("@datanascimento", this.DataNascimento);

                con.Open();
                afetados = cmd.ExecuteNonQuery();
            }
            return (afetados > 0);
        }
        public bool Alterar()
        {
            int afetados = 0;
            using (MySqlConnection con = new MySqlConnection(
                @"Server=localhost;Database=test;Uid=usuario;Pwd=senha"))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE cliente ");
                sql.Append("SET nome = @nome, sobrenome = @sobrenome, email = @email, " +
                    "ddd = @ddd, telefone = @telefone, sexo = @sexo, " +
                    "escolaridade = @escolaridade, datanascimento = @datanascimento");
                sql.Append("WHERE id = @id");

                MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);

                cmd.Parameters.AddWithValue("@Nome", this.Nome);
                cmd.Parameters.AddWithValue("@sobrenome", this.Sobrenome);
                cmd.Parameters.AddWithValue("@email", this.Email);
                cmd.Parameters.AddWithValue("@ddd", this.Ddd);
                cmd.Parameters.AddWithValue("@telefone", this.Telefone);
                cmd.Parameters.AddWithValue("@sexo", this.Sexo);
                cmd.Parameters.AddWithValue("@escolaridade", this.Escolaridade);
                cmd.Parameters.AddWithValue("@datanascimento", this.DataNascimento);
                cmd.Parameters.AddWithValue("@id", this.Id);
                con.Open();
                afetados = cmd.ExecuteNonQuery();
            }
            return (afetados > 0);
        }
        public bool Excluir()
        {
            int afetados = 0;
            using (MySqlConnection con = new MySqlConnection(
                @"Server=localhost;Database=test;Uid=usuario;Pwd=senha"))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("DELETE FROM cliente ");
                sql.Append("WHERE id = @id");

                MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);

                cmd.Parameters.AddWithValue("@id", this.Id);

                con.Open();
                afetados = cmd.ExecuteNonQuery();
            }
            return (afetados > 0);
        }
        public List<Cliente> ObterLista()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            using (MySqlConnection con = new MySqlConnection(
                @"Server=localhost;Database=test;Uid=usuario;Pwd=senha"))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM Cliente");

                MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
                con.Open();
                MySqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    Cliente p = new Cliente();
                    p.Id = Convert.ToInt32(leitor["id"]);
                    p.Nome = leitor["nome"].ToString();
                    p.Sobrenome = leitor["sobrenome"].ToString();
                    p.Email = leitor["email"].ToString();
                    p.Ddd = leitor["ddd"].ToString();
                    p.Telefone = leitor["telefone"].ToString();
                    p.Sexo = leitor["sexo"].ToString();
                    p.Escolaridade = leitor["escolaridade"].ToString();
                    p.DataNascimento = Convert.ToDateTime(leitor["dtNascimento"]);

                    listaClientes.Add(p);
                }
            }
            return listaClientes;
        }

        public Cliente ObterDetalhes(int idCliente)
        {

            Cliente p = new Cliente();

            using (MySqlConnection con = new MySqlConnection(
                @"Server=localhost;Database=test;Uid=usuario;Pwd=senha"))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM cliente ");
                sql.Append("WHERE IdCliente = @IdCliente");

                MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                con.Open();

                MySqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read())
                {
                    p.Id = Convert.ToInt32(leitor["id"]);
                    p.Nome = leitor["nome"].ToString();
                    p.Sobrenome = leitor["sobrenome"].ToString();
                    p.Email = leitor["email"].ToString();
                    p.Ddd = leitor["ddd"].ToString();
                    p.Telefone = leitor["telefone"].ToString();
                    p.Sexo = leitor["sexo"].ToString();
                    p.Escolaridade = leitor["escolaridade"].ToString();
                    p.DataNascimento = Convert.ToDateTime(leitor["dtNascimento"]);
                }
            

            }

            return p;
        }

    }
}
