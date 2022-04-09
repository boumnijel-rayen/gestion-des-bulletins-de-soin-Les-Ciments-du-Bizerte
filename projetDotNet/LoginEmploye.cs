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
    public partial class LoginEmploye : Form
    {
        public LoginEmploye()
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

        private void button2_Click(object sender, EventArgs e)
        {
            deconnecter();
            con.Open();
            cmd = new SqlCommand("select mat_E, num_CIN from employe where mat_E="+login.Text, con);
            Reader = cmd.ExecuteReader();
            table.Clear();
            table.Load(Reader);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Login n'existe pas !");
            }
            else
            {
                if (table.Rows[0]["num_CIN"].ToString() != mdp.Text)
                {
                    MessageBox.Show("Mot de passe invalide !");
                }
                else
                {
                    Espace_employe espace_Employe = new Espace_employe((int) table.Rows[0]["mat_E"]);
                    espace_Employe.ShowDialog();
                }
            }

            con.Close();

        }
    }
}
