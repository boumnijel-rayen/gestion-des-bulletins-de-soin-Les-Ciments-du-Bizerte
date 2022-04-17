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
            if (matE.Text == "")
            {
                MessageBox.Show("saisir la matricule de l'employée");
            }
            else
            {
                if (dataGridViewBulletin.Rows.Count > 1)
                {
                    for (int i = 0; i < dataGridViewBulletin.Rows.Count; i++)
                    {
                        dataGridViewBulletin.Rows.RemoveAt(i);
                    }
                }

                String date = dateD.Value.ToString("dd-MM-yyyy");
                deconnecter();
                con.Open();
                cmd = new SqlCommand("select num_B,date_Dep,acte,totale,frais from bulletin where date_Dep='"+date+"' and mat_E=" + matE.Text + " and id_AS=" + id, con);
                Reader = cmd.ExecuteReader();
                table.Load(Reader);
                dataGridViewBulletin.DataSource = table;
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Espace_Agent_Social espace_Agent_Social = new Espace_Agent_Social(id);
            espace_Agent_Social.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(numb.Text == "")
            {
                MessageBox.Show("saisir le numéro de bulletin");
            }
            else
            {
                if (dataGridViewBulletin.Rows.Count > 1)
                {
                    for (int i = 0; i < dataGridViewBulletin.Rows.Count; i++)
                    {
                        dataGridViewBulletin.Rows.RemoveAt(i);
                    }
                }
                
                
                deconnecter();
                con.Open();
                cmd = new SqlCommand("select num_B,date_Dep,acte,totale,frais from bulletin where num_B="+numb.Text+" and id_AS=" + id, con);
                Reader = cmd.ExecuteReader();
                table.Load(Reader);
                dataGridViewBulletin.DataSource = table;
                con.Close();
            }
        }
    }
}
