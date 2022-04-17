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
    public partial class redigerRapport : Form
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

        public redigerRapport(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public void chargerBulletin()
        {
            deconnecter();
            con.Open();
            cmd = new SqlCommand("select num_B,date_Dep,acte,totale,frais,des,reponse from bulletin where des is null and id_AS=" + id, con);
            Reader = cmd.ExecuteReader();
            table.Load(Reader);
            dataGridViewBulletin.DataSource = table;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(id.ToString());
        }

        private void redigerRapport_Load(object sender, EventArgs e)
        {
            chargerBulletin();
        }
    }
}
