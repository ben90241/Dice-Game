using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        bool firstRoll = false;
        int currentScore = 0;
        void disableButton()
        {
            rollBtn.Enabled = false;
            standBtn.Enabled = false;
        }
        void enableButton()
        {
            rollBtn.Enabled = true;
            standBtn.Enabled = true;
        }
        async void playerAI()
        {
            disableButton();
            currentScore = 0;
            if (label2.Text=="Player AI")
            {
                await Task.Delay(1500);
                if (int.Parse(player2Score.Text)>=100)
                {
                    MessageBox.Show("Player AI wins!");
                }
                else
                {
                    int temp = 0;
                    while((currentScore<20))
                    {
                        //System.Threading.Thread.Sleep(5000);
                        temp = random.Next(1, 7);
                        currentScore += temp;

                        currentPoints.Text = currentScore.ToString();
                        rolledVal.Text = temp.ToString();

                        if (temp == 1)
                        {
                            currentScore = 0;
                            currentPoints.Text = currentScore.ToString();
                            rolledVal.Clear();
                            playerTurn.Text = "1";
                            enableButton();
                            return;
                        }

                        await Task.Delay(1500);
                    }
                    temp = int.Parse(player2Score.Text);
                    temp += currentScore;
                    player2Score.Text = temp.ToString();
                    if (int.Parse(player2Score.Text) >= 100)
                    {
                        MessageBox.Show("Player AI won!");
                    }

                    currentScore = 0;
                    currentPoints.Text = currentScore.ToString();
                    rolledVal.Clear();

                    playerTurn.Text = "1";
                    enableButton();
                    return;
                }
            }
            enableButton();
            return;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
                int temp = random.Next(1, 7);

                if (temp == 1)
                {
                    if (playerTurn.Text == "1")
                    {
                        if (label2.Text == "Player AI")
                        {
                            playerTurn.Text = "AI";

                            firstRoll = false;
                            currentScore = 0;
                            currentPoints.Text = currentScore.ToString();
                            rolledVal.Clear();

                            playerAI();
                        }
                        else
                            playerTurn.Text = "2";
                    }
                    else if (playerTurn.Text == "2")
                    {
                        playerTurn.Text = "1";
                    }
                    firstRoll = false;
                    currentScore = 0;
                    currentPoints.Text = currentScore.ToString();
                    rolledVal.Clear();
                }
                else
                {
                    currentScore += temp;

                    currentPoints.Text = currentScore.ToString();
                    rolledVal.Text = temp.ToString();

                    firstRoll = true;
                }
           
        }

        private void standBtn_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if(firstRoll)
            {
                if (playerTurn.Text == "1")
                {
                    temp = int.Parse(player1Score.Text);
                    temp += currentScore;
                    player1Score.Text = temp.ToString();
                    currentScore = 0;
                    currentPoints.Text = currentScore.ToString();
                    rolledVal.Clear();

                    if (label2.Text == "Player AI")
                    {
                        playerTurn.Text = "AI";
                        playerAI();
                    }
                    else
                        playerTurn.Text = "2";
                }
                else if (playerTurn.Text=="2")
                {
                    temp = int.Parse(player2Score.Text);
                    temp += currentScore;
                    player2Score.Text = temp.ToString();
                    currentScore = 0;
                    currentPoints.Text = currentScore.ToString();
                    rolledVal.Clear();

                    playerTurn.Text = "1";
                }
                firstRoll = false;
            }
            temp = int.Parse(player1Score.Text);
            if(temp>=100)
            {
                MessageBox.Show("Player 1 wins!");
            }
            temp = int.Parse(player2Score.Text);
            if (temp >= 100 &&label2.Text=="Player 2")
            {
                MessageBox.Show("Player 2 wins!");
            }
        }
        
        void clearMethod()
        {
            player1Score.Text = "0";
            player2Score.Text = "0";
            playerTurn.Text = "1";
            currentPoints.Text = "0";
            rolledVal.Clear();
            firstRoll = false;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.clearMethod();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Player 1";
            label2.Text = "Player AI";
            clearMethod();
            panel1.Visible = true;
        }

        private void twoPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Player 1";
            label2.Text = "Player 2";
            clearMethod();
            panel1.Visible = true;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        
    }
}
