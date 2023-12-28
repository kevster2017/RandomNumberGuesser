namespace RandomNumberGuesser
{
    public partial class Form1 : Form
    {
        Random randomNumber = new Random();

        int number = 0;
        int guesses = 0;


        public Form1()
        {
            InitializeComponent();
            loadAnswer();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Game Started");
            loadAnswer();
            txtNumGuess.Text = "";
            guesses = 0;
            lblGuessed.Text = "You guessed " + guesses + " times";

        }

        private void GuessNumber(object sender, EventArgs e)
        {


            int i = Convert.ToInt32(txtNumGuess.Text);

            guesses += 1; ;
            lblGuessed.Text = "You guessed " + guesses + " times";

            if (i == number)
            {
                MessageBox.Show("Correct, you guessed it!!!");
                loadAnswer();
                txtNumGuess.Text = "";
                guesses = 0;
                txtOutput.Text = "Guess a number to begin";
                lblGuessed.Text = "You guessed " + guesses + " times";

            }

            else if (i < number)
            {
                txtOutput.Text = "Go Higher";

            }
            else
            {
                txtOutput.Text = "Go Lower";

            }


        }

        private void loadAnswer()
        {
            number = randomNumber.Next(0, 100);

            lblNumber.Text = "I am thinking of a number between 0 and 100 ";
        }
    }
}