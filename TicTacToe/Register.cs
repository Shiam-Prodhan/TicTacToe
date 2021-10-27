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
    public partial class Register : Form
    {
        public static string player1;
        public static string player2;
        Game obj = new Game();
        public Register()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //obj.GetName(player1, player2);
            player1 = textBox1.Text;
            player2 = textBox2.Text;
            Game access = new Game();
            access.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu access = new Menu();
            access.Show();
            this.Hide();
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
