using System;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Difficulty : Form
    {
        public Difficulty()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Easy easy = new Easy();
            easy.Show();
            this.Hide();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            Medium medium = new Medium();   
            medium.Show();
            this.Hide();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Hard hard = new Hard();
            hard.Show();
            this.Hide();
        }
    }
}
