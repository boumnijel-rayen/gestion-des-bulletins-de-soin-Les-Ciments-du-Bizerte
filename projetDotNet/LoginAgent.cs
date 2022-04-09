using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetDotNet
{
    public partial class LoginAgent : Form
    {
        public LoginAgent()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RD2C7JJ\SQLEXPRESS;Initial Catalog=projetDotnet;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader Reader;
        DataTable table = new DataTable();

        public void deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deconnecter();
            con.Open();
            cmd = new SqlCommand("select id_AS, login,password from agent_social where login = '" + login.Text + "'", con);
            Reader = cmd.ExecuteReader();
            table.Clear();
            table.Load(Reader);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Login n'existe pas !");
            }
            else
            {
                if (table.Rows[0]["password"].ToString() != mdp.Text)
                {
                    MessageBox.Show("Mot de passe invalide !");
                }
                else
                {
                    Espace_Agent_Social espace_Agent = new Espace_Agent_Social((int) table.Rows[0]["id_AS"]);
                    espace_Agent.ShowDialog();
                }
            }

            con.Close();
        }
    }
}
