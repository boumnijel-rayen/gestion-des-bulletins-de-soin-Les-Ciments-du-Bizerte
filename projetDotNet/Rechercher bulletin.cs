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
    public partial class Rechercher_bulletin : Form
    {
        private int id;

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
        public Rechercher_bulletin(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(id.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Espace_Agent_Social espace_Agent_Social = new Espace_Agent_Social(id);
            espace_Agent_Social.Show();
        }
    }
}
