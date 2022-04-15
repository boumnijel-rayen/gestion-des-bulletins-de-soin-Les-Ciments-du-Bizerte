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
    public partial class Ajoute_bulletin : Form
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

        public Ajoute_bulletin(int id)
        {
            InitializeComponent();
            this.id = id;

            deconnecter();
            con.Open();
            cmd = new SqlCommand("select mat_E from employe", con);
            Reader = cmd.ExecuteReader();
            table.Clear();
            table.Load(Reader);
            for (int i=0;i < table.Rows.Count; i++)
            {
                comboBoxMatE.Items.Add(table.Rows[i]["mat_E"]);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Espace_Agent_Social espace_Agent_Social = new Espace_Agent_Social(id);
            espace_Agent_Social.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String date;
            String matE;
            decimal frais;

            if (numb.Text == "")
            {
                MessageBox.Show("donner le numéro de bulletin");
            }
            else
            {
                if (acte.Text == "")
                {
                    MessageBox.Show("donner l'acte");
                }
                else
                {
                    if (totale.Text == "")
                    {
                        MessageBox.Show("donner le totale");
                    }
                    else
                    {
                        deconnecter();
                        con.Open();
                        cmd = new SqlCommand("select * from bulletin where num_B=" + numb.Text, con);
                        Reader = cmd.ExecuteReader();
                        table.Clear();
                        table.Load(Reader);

                        if (table.Rows.Count == 0)
                        {
                            date = dateD.Value.ToString("dd-MM-yyyy");
                            matE = comboBoxMatE.SelectedItem.ToString();
                            frais = decimal.Parse(totale.Text) * 0.3M;
                            
                            cmd = new SqlCommand("insert into bulletin (num_B,date_Dep,acte,totale,frais,mat_E,id_AS) values ("+numb.Text+",'"+date+"','"+acte.Text+"',@totale,@frais,"+matE+","+id+")", con);
                            cmd.Parameters.AddWithValue("@totale", decimal.Parse(totale.Text));
                            cmd.Parameters.AddWithValue("@frais",frais);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("bulletin ajouté !");
                           
                        }
                        else
                        {
                            MessageBox.Show("bulletin déja existe !");
                        }
                        con.Close();

                    }

                }

            }
            
        }
    }
}
