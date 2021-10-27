using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Game : Form
    {
        bool input = true;
        int Count = 0;
        public static int flag=0;
        public static string player1;
        public static string player2;
        public static string win;
        int temp = 0;
        public Game()
        {
            InitializeComponent();
            

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please match 3 X's or 3 O's\nHorizontally or Vertically or Diagonally to win!");
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu access = new Menu();
            access.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?","Exit", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button obj = (Button)sender;
            if(input)
            {
                obj.Text = "X";
            }
            else
            {
                obj.Text = "O";
            }

            input = !input;
            obj.Enabled = false;
            Count++;
            Winner();
        }
        private void Winner()
        {
            bool winner = false;

            if((x1.Text==x2.Text) && (x2.Text==x3.Text) && (!x1.Enabled))
            {
                winner = true;
            }
            else if ((y1.Text == y2.Text) && (y2.Text == y3.Text) && (!y1.Enabled))
            {
                winner = true;
            }
            else if ((z1.Text == z2.Text) && (z2.Text == z3.Text) && (!z1.Enabled))
            {
                winner = true;
            }
            if ((x1.Text == x2.Text) && (x2.Text == x3.Text) && (!x1.Enabled))
            {
                winner = true;
            }
            if ((x1.Text == y1.Text) && (y1.Text == z1.Text) && (!x1.Enabled))
            {
                winner = true;
            }
            if ((x2.Text == y2.Text) && (y2.Text == z2.Text) && (!x2.Enabled))
            {
                winner = true;
            }
            if ((x3.Text == y3.Text) && (y3.Text == z3.Text) && (!x3.Enabled))
            {
                winner = true;
            }
            if ((x1.Text == y2.Text) && (y2.Text == z3.Text) && (!x1.Enabled))
            {
                winner = true;
            }
            if ((x3.Text == y2.Text) && (y2.Text == z1.Text) && (!z1.Enabled))
            {
                winner = true;
            }
            temp = (temp + 1) % 2;
            if(temp == 1)
            {
                label2.Text = (player2);
            }
            else if(temp==0)
            {
                label2.Text = (player1);
            }
            
            
            if (winner)
            {
                ButtonDisable();
                
                if(input)
                {
                    label1.Text = (player2);
                    label2.Text = (" is the WINNER!");
                    win = player2;
                }
                else
                {
                    label1.Text = (player1);
                    label2.Text = (" is the WINNER!");
                    win = player1;
                }
                flag++;
                MessageBox.Show(win+" has won the game!", "Congratulations");
            }
            else
            {
                if(Count==9)
                {
                    label1.Text = ("Draw");
                    label2.Text = ("!No WINNER!");
                    MessageBox.Show("Both of the players got equal points!", "Draw!");
                }
            }
        }
        private void ButtonDisable()
        {
            foreach (Control Access in Controls )
            {
                try 
                {
                    Button obj = (Button)Access;
                    obj.Enabled = false;
                }
                catch 
                {
                }
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void Game_Load(object sender, EventArgs e)
        {
           
            player1 = Register.player1;
            player2 = Register.player2;
            label2.Text = (player1);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input = true;
            Count = 0;
            label1.Text = ("Turn:");
            label2.Text = (player1);

            foreach (Control Access in Controls)
                {
                    try
                {
                    Button obj = (Button)Access;
                    obj.Enabled = true;
                    obj.Text = "";
                }
                catch
                {

                }
                        
                }    
            
           
        }

        private void formclosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
