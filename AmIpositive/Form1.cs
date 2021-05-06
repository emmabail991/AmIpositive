using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmIpositive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          
        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(inputIntager.Text);

            if (number >=0 ) 
            {
                outputLabel.Text = "your number is a positive number";
            }
            else
            {
                outputLabel.Text = "your number is not a positive number";
            }
            if(number % 7 == 0)
            {
                outputLabel.Text += "\n\nyour number is divisable by 7";

            }
            else
            {
                outputLabel.Text += "\n\nyour number is not divisable by 7";
            }
        }
        
        

        }
    
}
