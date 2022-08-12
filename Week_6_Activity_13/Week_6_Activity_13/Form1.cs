using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_6_Activity_13
{
    public partial class Form1 : Form


    {
        // Declare a object for 2D
        int[,] gamemat = new int[3, 3];

        string winner = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void startTurn_Click(object sender, EventArgs e)
        {

            //Random and loop to add to 2D array
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int numLoop = random.Next(0, 2);

                    gamemat[i, j] = numLoop;
                }
            }


            //Assigning values to game mat
            if (gamemat[0, 0] == 0)
            {
                gameBox00.Text = "0";
            }
            else  
            {
                gameBox00.Text = "X";
            }
             if (gamemat[0, 1] == 0)
            {
                gameBox01.Text = "0";
            }
            else 
            {
                gameBox01.Text = "X";
            }
             if (gamemat[0, 2] == 0)
            {
                gameBox03.Text = "0";
            }
            else 
            {
                gameBox03.Text = "X";
            }
            if (gamemat[1, 0] == 0)
            {
                gameBox10.Text = "0";
            }
            else 
            {
                gameBox10.Text = "X";
            }
            if (gamemat[1, 1] == 0)
            {
                gameBox11.Text = "0";
            }
            else 
            {
                gameBox11.Text = "X";
            }
            if (gamemat[1, 2] == 0)
            {
                gameBox12.Text = "0";
            }
            else 
            {
                gameBox12.Text = "X";
            }
            if (gamemat[2, 0] == 0)
            {
                gameBox20.Text = "0";
            }
            else 
            {
                gameBox20.Text = "X";
            }
            if (gamemat[2, 1] == 0)
            {
                gameBox22.Text = "0";
            }
            else 
            {
                gameBox22.Text = "X";
            }
            if (gamemat[2, 2] == 0)
            {
                gameBox23.Text = "0";
            }
            else 
            {
                gameBox23.Text = "X";
            }

            if (winner == "")
            {
                MessageBox.Show("The Game is a Tie");
            }
            else
                MessageBox.Show(winner + " Wins");

            winner = check_for_winner();

        }
        //Method to check winner
        private string check_for_winner()
        {
            string winner = "";

            //If O wins

            if (gamemat[0,0] == 0 && gamemat[0,1] == 0 && gamemat[0,2] == 0)
            {
                winner = "O";
            }
            else if (gamemat[1, 0] == 0 && gamemat[1, 1] == 0 && gamemat[1, 2] == 0)
            {
                winner = "O";
            }
            else if (gamemat[2, 0] == 0 && gamemat[2, 1] == 0 && gamemat[2, 2] == 0)
            {
                winner = "O";
            }
            else if (gamemat[0, 0] == 0 && gamemat[1, 1] == 0 && gamemat[2,2] == 0)
            {
                winner = "O";
            }
            else if (gamemat[0,2] == 0 && gamemat[1,1] == 0 && gamemat[2,0]== 0)
            {
                winner = "O";
            }
            else if (gamemat[0,0] == 0 && gamemat[1,0] == 0 && gamemat[2,0]== 0)
            {
                winner = "O";   
            }
            else if (gamemat[0,1] == 0 && gamemat[1,1] == 0 && gamemat[2,1] == 0)
            {
                winner= "O";
            }
            else if (gamemat[0,2] == 0 && gamemat[1,2]== 0 && gamemat[2,2] == 0)
            {
                winner = "O";
            }



            //If X wins

            if (gamemat[0, 0] == 1 && gamemat[0, 1] == 1 && gamemat[0, 2] == 1)
            {
                winner = "X";
            }
            else if (gamemat[1, 0] == 1 && gamemat[1, 1] == 1 && gamemat[1, 2] == 1)
            {
                winner = "X";
            }
            else if (gamemat[2, 0] == 1 && gamemat[2, 1] == 1 && gamemat[2, 2] == 1)
            {
                winner = "X";
            }
            else if (gamemat[0, 0] == 1 && gamemat[1, 0] == 1 && gamemat[2, 0] == 1)
            {
                winner = "X";
            }
            else if (gamemat[0, 1] == 1 && gamemat[1, 1] == 1 && gamemat[2, 1] == 1)
            {
                winner = "X";
            }
            else if (gamemat[0, 2] == 1 && gamemat[1, 2] == 1 && gamemat[2, 2] == 1)
            {
                winner = "X";
            }
            else if (gamemat[0, 0] == 1 && gamemat[1, 1] == 1 && gamemat[2, 2] == 1)
            {
                winner = "X";
            }
            else if (gamemat[0, 2] == 1 && gamemat[1, 1] == 1 && gamemat[2, 0] == 1)
            {
                winner = "X";
            }


            return winner;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
