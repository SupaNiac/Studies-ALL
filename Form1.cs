using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aula16._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mensagem(string msg)
        {
            listBox1.Items.Add(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQL Server
            //  SQL Connection
            //      ConnectionString
            //      Open()
            //      Close()
         

            //  SQL Command
            //SqlDataReader

            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EmpresaDb;
                                  Integrated Security=True;Pooling=False;";

            cn.Open();
            Mensagem("Conexão aberta");
            cn.Close();
            Mensagem("Conexão fechada");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EmpresaDb;
                                  Integrated Security=True;Pooling=False;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT Nome FROM Cliente";

            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string nome = reader["Nome"].ToString();
                listBox1.Items.Add(nome);  
             }
            reader.Close();
            cn.Close() ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EmpresaDb;
                                  Integrated Security=True;Pooling=False;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO Cliente(Id,Nome,Email,Telefone) Values(@Id,@Nome,@Email,@Telefone)";
            cmd.Parameters.AddWithValue("@Id", 25);
            cmd.Parameters.AddWithValue("@Nome", "Silvio Santos");
            cmd.Parameters.AddWithValue("@Telefone", "83598250");
            cmd.Parameters.AddWithValue("@Email", "@aodkaokd@");
            cn.Open();
            Mensagem("Conexão aberta");
            
            int total = cmd.ExecuteNonQuery();
            Mensagem("Registro incluido");

            cn.Close();
            Mensagem("Conexão fechada");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EmpresaDb;
                                  Integrated Security=True;Pooling=False;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE Cliente SET Nome=@Nome Where Id=@Id";
            cmd.Parameters.AddWithValue("@Id", 25);
            cmd.Parameters.AddWithValue("@Nome", "Silvio Santos Santos");
            cn.Open();
            int total = cmd.ExecuteNonQuery();
            cn.Close();
            Mensagem("Registro alterado com sucesso!");


        }

        private void button5_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EmpresaDb;
                                  Integrated Security=True;Pooling=False;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "DELETE Cliente WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", 25);
            cn.Open();
            int total = cmd.ExecuteNonQuery();
            cn.Close();
            Mensagem("Registro excluido com sucesso!");
        }
    }
}
