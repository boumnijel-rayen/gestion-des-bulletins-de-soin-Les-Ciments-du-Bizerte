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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.panelContainer.Controls.Count > 0)
            {
                this.panelContainer.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(f);
            this.panelContainer.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadForm(new LoginAdmin());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadForm(new LoginAgent());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadForm(new LoginEmploye());
        }

    }
}
