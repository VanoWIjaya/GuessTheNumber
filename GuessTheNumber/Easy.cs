using System;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Easy : Form
    {
        int guessNumber;
        int numberGuess = 15;
        Random random = new Random();

        public Easy()
        {
            InitializeComponent();
            NewGame();
        }

        private void NewGame()
        {
            guessNumber = random.Next(1, 100);
            lblguesses.Text = $"Guess from : {Math.Min(1, 100)} - {Math.Max(1, 100)}";
            txtGuessesLeft.Text = $"Guesses Left : {numberGuess}";
            txtGuess.Text = "";
            btnGuess.Enabled = true;
            txtGuess.Enabled = true;
        }

        private void GameOver()
        {
            txtExplanation.Text = $"\nGame Over! The correct number was {guessNumber}.";
            NewGame();


        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtGuess.Text, out int userGuess))
            {
                numberGuess--;
                txtGuessesLeft.Text = $"Guesses Left : {numberGuess}";

                if (userGuess == guessNumber)
                {
                    txtExplanation.Text = "\nCongratulations! You've guessed the number!";
                    NewGame();
                }
                else if (userGuess < guessNumber)
                {
                    txtExplanation.Text = "\nToo low! Try again.";
                }
                else
                {
                    txtExplanation.Text = "\nToo high! Try again.";
                }
                if (numberGuess == 0)
                {
                    GameOver();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
            txtGuess.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Difficulty difficulty = new Difficulty();
            difficulty.Show();
            this.Close();    
        }
    }
}
