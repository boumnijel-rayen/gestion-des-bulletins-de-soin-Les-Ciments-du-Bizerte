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
    public partial class Supprimer_bulletin : Form
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

        public Supprimer_bulletin(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public void chargerBulletin()
        {
            deconnecter();
            con.Open();
            cmd = new SqlCommand("select num_B,date_Dep,acte,totale,frais from bulletin where id_AS=" + id, con);
            Reader = cmd.ExecuteReader();
            table.Load(Reader);
            dataGridViewBulletin.DataSource = table;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewBulletin.CurrentRow.Index >= 0)
            {
                DataGridViewRow l = dataGridViewBulletin.Rows[dataGridViewBulletin.CurrentRow.Index];
                String selectedNum = l.Cells["num_B"].Value.ToString();
                deconnecter();
                con.Open();
                cmd = new SqlCommand("delete from bulletin where num_B="+selectedNum, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("bulletin supprimé avec success !");
            }
            else
            {
                MessageBox.Show("selectionnez un bulletin !");
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Espace_Agent_Social espace_Agent_Social = new Espace_Agent_Social(id);
            espace_Agent_Social.Show();
        }

        private void dataGridViewBulletin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Supprimer_bulletin_Load(object sender, EventArgs e)
        {
            chargerBulletin();
        }
    }
}
