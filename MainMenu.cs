using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Side_Scrolling_Game_MOO_ICT
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Quit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_Btn_Click(object sender, EventArgs e)
        {
            Help newForm = new Help();
            this.Hide();
            newForm.Show();
        }

        private void Play_Btn_Click(object sender, EventArgs e)
        {
            Menu_Selector newForm = new();
            this.Hide();
            newForm.Show();
        }
    }
}
