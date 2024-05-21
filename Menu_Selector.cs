using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Side_Scrolling_Game_MOO_ICT
{
    public partial class Menu_Selector : Form
    {
        public Menu_Selector()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form MainMenu = Application.OpenForms[0];
            this.Close();
            MainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 lvl1 = new();
            this.Hide();
            lvl1.Show();
        }
    }
}
