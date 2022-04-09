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
    public partial class Espace_employe : Form
    {
        private int id;
        public Espace_employe(int id)
        {
            InitializeComponent();
            Login.ActiveForm.Hide();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(id.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }
    }
}
