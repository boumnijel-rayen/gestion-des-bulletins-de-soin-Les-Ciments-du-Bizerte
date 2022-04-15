using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetDotNet
{
    public partial class Espace_Agent_Social : Form
    {

        private int id;
        public Espace_Agent_Social(int id)
        {
            InitializeComponent();
            if(Login.ActiveForm != null)
            {
                Login.ActiveForm.Hide();
            }
            this.id = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajoute_bulletin ajoute_Bulletin = new Ajoute_bulletin(id);
            ajoute_Bulletin.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modifier_bulletin modifier_Bulletin = new Modifier_bulletin(id);
            modifier_Bulletin.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(id.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supprimer_bulletin supprimer_Bulletin = new Supprimer_bulletin(id);
            supprimer_Bulletin.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rechercher_bulletin rechercher_Bulletin = new Rechercher_bulletin(id);
            rechercher_Bulletin.ShowDialog();
        }
    }
}
