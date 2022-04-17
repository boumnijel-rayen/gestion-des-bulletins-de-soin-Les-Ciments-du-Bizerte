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
            if (dataGridViewBulletin.CurrentRow.Index >= 0)
            {
                DataGridViewRow l = dataGridViewBulletin.Rows[dataGridViewBulletin.CurrentRow.Index];
                String selectedNum = l.Cells["num_B"].Value.ToString();
                DataTable table1 = new DataTable();
                DataTable table2 = new DataTable();

                deconnecter();
                con.Open();
                cmd = new SqlCommand("select frais,mat_E from bulletin where num_B=" + selectedNum, con);
                Reader = cmd.ExecuteReader();
                table1.Load(Reader);
                String frais = table1.Rows[0]["frais"].ToString();
                String numE = table1.Rows[0]["mat_E"].ToString();
                con.Close();

                deconnecter();
                con.Open();
                cmd = new SqlCommand("select plafond_R from employe where mat_E="+numE, con);
                Reader = cmd.ExecuteReader();
                table2.Load(Reader);
                String plafond = table2.Rows[0]["plafond_R"].ToString();
                con.Close();

                double plafondD = double.Parse(plafond);
                double fraisD = double.Parse(frais);

                if (rapport.Text != "")
                 {
                    String rep;
                    if(plafondD == 0)
                    {
                        rep = "refuser";

                    }
                    else
                    {
                        double newP;
                        if (plafondD > fraisD)
                        {
                            newP = plafondD - fraisD;
                        }
                        else
                        {
                            newP = 0;
                        }
                        rep = "accepter";
                        deconnecter();
                        con.Open();
                        cmd = new SqlCommand("update employe set plafond_R=@plafond where mat_E="+numE, con);
                        cmd.Parameters.AddWithValue("@plafond",newP);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                     deconnecter();
                     con.Open();
                     cmd = new SqlCommand("update bulletin set des='"+rapport.Text+"',reponse='"+rep+"' where num_B=" + selectedNum, con);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("rapport rédigé avec succes");
                     con.Close();
                 }
                 else
                 {
                     MessageBox.Show("rédigez le rapport !");
                 }
            }
            else
            {
                MessageBox.Show("selectionnez un bulletin !");
            }
        }

        private void redigerRapport_Load(object sender, EventArgs e)
        {
            chargerBulletin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Espace_Agent_Social espace_Agent_Social = new Espace_Agent_Social(id);
            espace_Agent_Social.Show();
        }
    }
}
