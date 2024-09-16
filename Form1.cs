using System.Security.Cryptography.X509Certificates;

namespace tic_tac_teo_Form
{
    public partial class Form1 : Form
    {
        Player player1 = new Player('X', 0, 0, 0);
        Player player2 = new Player('O', 0, 0, 0);
        int turn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Player player1 = new Player('X', 0, 0, 0);
            //Player player2 = new Player('O', 0, 0, 0);
            if (MessageBox.Show("do you want to be player 1 ?", "Yes or No ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //player1.setFields('X', 0, 0, 0);
                //player2.setFields('O', 0, 0, 0);
                turn = 1;
            }
        }

        private void btnclick(object sender, EventArgs e)
        {
            if (((Button)sender).Text != "")
            {
                MessageBox.Show("this field has been chosen before , please choose another field ");
                return;
            }
            else
            {
                if (turn == 1)
                {
                    ((Button)sender).Text = "X";
                    player1.increaseMoves();
                    lblplayer1moves.Text = Convert.ToString(player1.getmoves());
                    turn = 2;
                }

                else
                {
                    ((Button)sender).Text = "O";
                    player2.increaseMoves();
                    lblplayer2moves.Text = Convert.ToString(player1.getmoves());
                    turn = 1;
                }

                if (victorycheck() == 'X')
                {
                    MessageBox.Show("First Player is winner !!!");
                    player1.increaseWins();
                    player1.increasegames();
                    player2.increasegames();
                    lblplayer1games.Text = Convert.ToString(player1.getgames());
                    lblplayer1wins.Text = Convert.ToString(player1.getwins());
                    lblplayer2games.Text = Convert.ToString(player1.getgames());
                    if (MessageBox.Show("Do you want to play again ?", "Restart", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Clear();
                        Form1_Load(null, null);
                    }
                    else
                        this.Close();
                }
                if (victorycheck() == 'O')
                {
                    MessageBox.Show("Second Player is winner !!!");
                    player2.increaseWins();
                    player2.increasegames();
                    player1.increasegames();
                    lblplayer2games.Text = Convert.ToString(player1.getgames());
                    lblplayer2wins.Text = Convert.ToString(player1.getwins());
                    lblplayer1games.Text = Convert.ToString(player1.getgames());
                    if (MessageBox.Show("Do you want to play again ?", "Restart", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Clear();
                        Form1_Load(null, null);
                    }
                    else
                        this.Close();
                }
            }
        }

        public char victorycheck()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X" ||
               btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X" ||
               btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X" ||
               btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X" ||
               btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X" ||
               btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X" ||
               btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X" ||
               btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                return 'X';
            }
            else if
               (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O" ||
               btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O" ||
               btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O" ||
               btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O" ||
               btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O" ||
               btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O" ||
               btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O" ||
               btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                return 'O';
            }
            else { return '0'; }
        }
        public void Clear()
        {
            btn1.Text = null;
            btn2.Text = null;
            btn3.Text = null;
            btn4.Text = null;
            btn5.Text = null;
            btn6.Text = null;
            btn7.Text = null;
            btn8.Text = null;
            btn9.Text = null;
        }
    }
}