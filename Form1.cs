using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TicTacToe
{
    public partial class frmMain : Form
    {

       private int playerTerm = 1;
       private char[] letter;
       private int played = 0;
       private string player1 = "";
       private string player2 = "";

        //it is a button which Allows log in the game.
        //there are some conditional statements which are related to if the players name empty
        private void LogInButton_Click_1(object sender, EventArgs e)
        {

            if (player1NameBox.Text == "")
            {
                MessageBox.Show("Please enter Player1 name!");
            }
            else if (player2NameBox.Text == "") {
                MessageBox.Show("Please enter Player2 name!");
            }
            
            else
            {
                player1 = player1NameBox.Text;
                player2 = player2NameBox.Text;
                LogInPage.Visible = false;
                turns.Text = player2 + " 's TURN";
            }
           

        }




        //in the game there are 9 boxes, it starts from the index of 0 that's why [10].
        public frmMain()
        {
            InitializeComponent();
            letter = new char[10];           
        }


        //All the instruction under the Form1_Load will executed when running the program
        //play again button, wins and quit button are not visible because we don't need it right now
        private void Form1_Load(object sender, EventArgs e)
        {   
            playAgainButton.Visible = false;
            wins.Visible = false;
            quitButton.Visible = false;
        }


        //this is basically close the program when click the X symbol at the left corner of the screen
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }


        //below sections are mostly the same. ones which start "pic" is closely related to clicking the boxes
        //after clicking the boxes there are some instruction will be executed
        private void picTL_Click(object sender, EventArgs e)
        {
            if (playerTerm == 1)
            {
                picTL.Image = Properties.Resources.xTicTacToe;
                letter[1] = 'x';
                playerTerm = 2;
                picTL.Enabled = false;
                turns.Text = player1 +" 's TURN";

            }
            else {
                picTL.Image = Properties.Resources.oTictacToe;
                letter[1] = 'o';
                playerTerm = 1;
                picTL.Enabled = false;
                turns.Text = player2 + " 's TURN";

            }
            played++;
            checkWin();
        }

        private void picTM_Click(object sender, EventArgs e)
        {
            if (playerTerm == 1)
            {
                picTM.Image = Properties.Resources.xTicTacToe;
                letter[2] = 'x';
                playerTerm = 2;
                picTM.Enabled = false;
                turns.Text = player1 + " 's TURN";

            }
            else
            {
                picTM.Image = Properties.Resources.oTictacToe;
                letter[2] = 'o';
                playerTerm = 1;
                picTM.Enabled = false;
                turns.Text = player2 + " 's TURN";

            }
            played++;
        
            checkWin();
        }

        private void picTR_Click(object sender, EventArgs e)
        {
            if (playerTerm == 1)
            {
                picTR.Image = Properties.Resources.xTicTacToe;
                letter[3] = 'x';
                playerTerm = 2;
                picTR.Enabled = false;
                turns.Text = player1 + " 's TURN";

            }
            else
            {
                picTR.Image = Properties.Resources.oTictacToe;
                letter[3] = 'o';
                playerTerm = 1;
                picTR.Enabled = false;
                turns.Text = player2 + " 's TURN";

            }
            played++;
            
            checkWin();
        }

        private void picML_Click(object sender, EventArgs e)
        {
            if (playerTerm == 1)
            {
                picML.Image = Properties.Resources.xTicTacToe;
                letter[4] = 'x';
                playerTerm = 2;
                picML.Enabled = false;
                turns.Text = player1 + "' s TURN";

            }
            else
            {
                picML.Image = Properties.Resources.oTictacToe;
                letter[4] = 'o';
                playerTerm = 1;
                picML.Enabled = false;
                turns.Text = player2 + " 's TURN";

            }
            played++;
            
            checkWin();
        }

        private void picM_Click(object sender, EventArgs e)
        {
            if (playerTerm == 1)
            {
                picM.Image = Properties.Resources.xTicTacToe;
                letter[5] = 'x';
                playerTerm = 2;
                picM.Enabled = false;
                turns.Text = player1 + " 's TURN";

            }
            else
            {
                picM.Image = Properties.Resources.oTictacToe;
                letter[5] = 'o';
                playerTerm = 1;
                picM.Enabled = false;
               
                turns.Text = player2 + " 's TURN";

            }
            played++;
            checkWin();
        }

        private void picMR_Click(object sender, EventArgs e)
        {
            if (playerTerm == 1)
            {
                picMR.Image = Properties.Resources.xTicTacToe;
                letter[6] = 'x';
                playerTerm = 2;
                picMR.Enabled = false;
                turns.Text = player1 + " 's TURN";

            }
            else
            {
                picMR.Image = Properties.Resources.oTictacToe;
                letter[6] = 'o';
                playerTerm = 1;
                picMR.Enabled = false;
                turns.Text = player2 + " 's TURN";

            }
            played++;
            checkWin();
        }

        private void picDL_Click(object sender, EventArgs e)
        {
            if (playerTerm == 1)
            {
                picDL.Image = Properties.Resources.xTicTacToe;
                letter[7] = 'x';
                playerTerm = 2;
                picDL.Enabled = false;
                turns.Text = player1 + " 's TURN";

            }
            else
            {
                picDL.Image = Properties.Resources.oTictacToe;
                letter[7] = 'o';
                playerTerm = 1;
                picDL.Enabled = false;
                turns.Text = player2 + " 's TURN";

            }
            played++;
            checkWin();
        }

        private void picDM_Click(object sender, EventArgs e)
        {
            if (playerTerm == 1)
            {
                picDM.Image = Properties.Resources.xTicTacToe;
                letter[8] = 'x';
                playerTerm = 2;
                picDM.Enabled = false;
                turns.Text = player1 + " 's TURN";

            }
            else
            {
                picDM.Image = Properties.Resources.oTictacToe;
                letter[8] = 'o';
                playerTerm = 1;
                picDM.Enabled = false;
                turns.Text = player2 + " 's TURN";

            }
            played++;
            checkWin();
        }

        private void picDR_Click(object sender, EventArgs e)
        {
            if (playerTerm == 1)
            {
                picDR.Image = Properties.Resources.xTicTacToe;
                letter[9] = 'x';
                playerTerm = 2;
                picDR.Enabled = false;
                turns.Text = player1 + " 's TURN";

            }
            else
            {
                picDR.Image = Properties.Resources.oTictacToe;
                letter[9] = 'o';
                playerTerm = 1;
                picDR.Enabled = false;
                turns.Text = player2 + " 's TURN";

            }
            played++;
            checkWin();
        }


        //Check the winner one then show at the middle of the screen
        public void checkWin() {
            //check horizontal for p1
            if (letter[1] == 'x' && letter[2] == 'x' && letter[3] == 'x')
            {

                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player2 + " WİNS!";

            }
            else if (letter[4] == 'x' && letter[5] == 'x' && letter[6] == 'x')
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player2 + " WİNS!";
            }
            else if (letter[7] == 'x' && letter[8] == 'x' && letter[9] == 'x')
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player2 + " WİNS!";
            }

            //check vertical for p1
            else if (letter[1] == 'x' && letter[4] == 'x' && letter[7] == 'x')
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player2 + " WİNS!";
            }
            else if (letter[2] == 'x' && letter[5] == 'x' && letter[8] == 'x')
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player2 + " WİNS!";
            }
            else if (letter[3] == 'x' && letter[6] == 'x' && letter[9] == 'x')
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player2 + " WİNS!";
            }

            //check diagnol for p1
            else if (letter[1] == 'x' && letter[5] == 'x' && letter[9] == 'x')
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player2 + " WİNS!";
            }
            else if (letter[3] == 'x' && letter[5] == 'x' && letter[7] == 'x')
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player2 + " WİNS!";
            }
            

            //check horizontal for p2
            else if (letter[1] == 'o' && letter[2] == 'o' && letter[3] == 'o')
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player1 + " WİNS!";
            }
            else if (letter[4] == 'o' && letter[5] == 'o' && letter[6] == 'o')
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player1 + " WİNS!";
            }
            else if (letter[7] == 'o' && letter[8] == 'o' && letter[9] == 'o')
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player1 + " WİNS!";
            }

            //check vertical for p2
            else if (letter[1] == 'o' && letter[4] == 'o' && letter[7] == 'o')
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player1 + " WİNS!";
            }
            else if (letter[2] == 'o' && letter[5] == 'o' && letter[8] == 'o')
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player1 + " WİNS!";
            }
            else if (letter[3] == 'o' && letter[6] == 'o' && letter[9] == 'o')
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player1 + " WİNS!";
            }

            //check dianol for p2
            else if (letter[1] == 'o' && letter[5] == 'o' && letter[9] == 'o')
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player1 + " WİNS!";
               
            }
            else if (letter[3] == 'o' && letter[5] == 'o' && letter[7] == 'o')
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                wins.Text = player1 + " WİNS!";
                
            }
            else if (played == 9) 
            {
                winBackColor();
                enableXandO();
                turnVisibleAgainQuit();
                
                wins.Text =" TIE!";
                
                
            }


        }
       

        //as we see it is a restart button
        private void playAgainButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        //here the aim is ones we changed the boxes value, not be able to change again
        public void enableXandO() {
            picTL.Enabled = false;
            picTM.Enabled = false;
            picTR.Enabled = false;
            picML.Enabled = false;
            picM.Enabled = false;
            picMR.Enabled = false;
            picDL.Enabled = false;
            picDM.Enabled = false;
            picDR.Enabled = false;

        }


        //Turn, visiable, Again and quit functions will be here to control it
        public void turnVisibleAgainQuit()
        {
            turns.Visible = false;
            wins.Visible = true;
            playAgainButton.Visible = true;
            quitButton.Visible = true;

        }


        //after one player wins the game the back color will be like that
        public void winBackColor() {
            wins.BackColor = Color.FromArgb(230, 0, 128, 128);
        }




        //close the app
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }


        //close the app
        private void LogInQuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
