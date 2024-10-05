using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int attempts;
        private int computerChoice;

        private void Restart()
        {
            Random random = new Random();
            computerChoice = random.Next(1, 101);
            attempts = 0;
            label4.Text = computerChoice.ToString();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int playerChoice = Convert.ToInt32(textBox1.Text);

            if (playerChoice > 100 || playerChoice < 1)
            {
                label3.Text = "You are out of the diapason. Please enter number from 1 to 100";
            }
            else if (textBox1 == null)
            {
                MessageBox.Show("Error! Put a number into the text box");
            }
            else
            {
                attempts++;
                if (computerChoice == playerChoice)
                {
                    label3.Text = $"Right!!! Congratulations!\n {attempts} attempts";
                }
                else if (playerChoice < computerChoice)
                {
                    label3.Text = "More";
                }
                else if (playerChoice > computerChoice)
                {
                    label3.Text = "Less";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Restart();
        }
    }
}
