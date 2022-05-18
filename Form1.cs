using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Activity13
{
    public partial class Form1 : Form
    {
        //declare local variable
        int Counter = 0;
        //Initialize the form
        public Form1()
        {
            InitializeComponent();
        }
        //Implement action for the first button
        //If initially counter is 0
        //set the text to X
        //If counter is 1 set text to O
        private void button1_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (Counter == 0)
            {
                button1.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button1.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();
        }

        //Implement action for the second button
        //If initially counter is 0
        //set the text to X
        //If counter is 1
        //set text to O
        private void button2_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (Counter == 0)
            {
                button2.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button2.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();
        }
        //Implement action for the third button
        //If initially counter is 0
        //set the text to X
        //If counter is 1
        //set text to O
        private void button3_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (Counter == 0)
            {
                button3.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button3.Text = "O";
                Counter--;
            }
            //Disable button so it cannot be changed
            button3.Enabled = true;
            //Check if anyone won, lose, tie
            Check();
        }
        //Implement action for the fourth button
        //If initially counter is 0
        //set the text to X
        //If counter is 1
        //set text to O
        private void button4_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (Counter == 0)
            {
                button4.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button4.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();
        }
        //Implement action for the fifth button
        //If initially counter is 0
        //set the text to X
        //If counter is 1
        //set text to O
        private void button5_Click(object sender, EventArgs e)
        {
            // Check who's turn it is
            if (Counter == 0)
            {
                button5.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button5.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();
        }
        //Implement action for the sixth button
        //If initially counter is 0
        //set the text to X
        //If counter is 1
        //set text to O
        private void button7_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (Counter == 0)
            {
                button7.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button7.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();
        }
        //Implement action for the seventh button
        //If initially counter is 0
        //set the text to X
        //If counter is 1
        //set text to O
        private void button6_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (Counter == 0)
            {
                button6.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button6.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();
        }
        //Implement action for the eighth button
        //If initially counter is 0
        //set the text to X
        //If counter is 1
        //set text to O
        private void button8_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (Counter == 0)
            {
                button8.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button8.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();
        }
        //Implement action for the nineth button
        //If initially counter is 0
        //set the text to X
        //If counter is 1
        //set text to O
        private void button9_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (Counter == 0)
            {
                button9.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button9.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();
        }
        //Implement method to check the rows and columns whether X wins
        //or O wins
        void Check()
        {
            //Check if tie
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
            button4.Text != "" && button5.Text != "" && button6.Text != "" &&
            button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                textBox1.Text = "Tied";
            }
            //Check diagonal for X
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                textBox1.Text = "X Wins!";
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                textBox1.Text = "X Wins!";
            }
            //Check rows for X
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                textBox1.Text = "X Wins!";
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                textBox1.Text = "X Wins!";
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                textBox1.Text = "X Wins!";
            }
            //Check columns for X
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                textBox1.Text = "X Wins!";
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                textBox1.Text = "X Wins!";
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                textBox1.Text = "X Wins!";
            }
            //Check diagonal for O
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                textBox1.Text = "O Wins!";
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                textBox1.Text = "O Wins!";
            }
            //Check rows for O
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                textBox1.Text = "O Wins!";
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                textBox1.Text = "O Wins!";
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                textBox1.Text = "O Wins!";
            }
            //Check columns for O
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                textBox1.Text = "O Wins!";
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                textBox1.Text = "O Wins!";
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                textBox1.Text = "O Wins!";
            }
        }
        //Implement method to start a new game
        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            textBox1.Text = "";
            Counter = 0;
        }
        //implement button to exit from the game
        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //set the text to center alignment
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Counter == 0)
            {
                button1.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button1.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (Counter == 0)
            {
                button2.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button2.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (Counter == 0)
            {
                button3.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button3.Text = "O";
                Counter--;
            }
            //Disable button so it cannot be changed
            button3.Enabled = true;
            //Check if anyone won, lose, tie
            Check();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (Counter == 0)
            {
                button4.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button4.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // Check who's turn it is
            if (Counter == 0)
            {
                button5.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button5.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (Counter == 0)
            {
                button6.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button6.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (Counter == 0)
            {
                button7.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button7.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (Counter == 0)
            {
                button8.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button8.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (Counter == 0)
            {
                button9.Text = "X";
                Counter++;
            }
            else if (Counter == 1)
            {
                button9.Text = "O";
                Counter--;
            }
            //Check if anyone won, lose, tie
            Check();

        }
    }
}