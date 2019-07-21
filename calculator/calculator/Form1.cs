using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double FirstNum, SecondNum;
        
        char znak;
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Button11_Click(object sender, EventArgs e)
        {
           label2.Text += ",";
        }

        private void Button12_Click(object sender, EventArgs e)
        {
           
            SecondNum = Convert.ToDouble(label2.Text);
            switch (znak)
            {
                case '+':label2.Text = Convert.ToString(FirstNum + SecondNum);break;
                case '-':label2.Text = Convert.ToString(FirstNum - SecondNum);break;
                case '*':label2.Text = Convert.ToString(FirstNum * SecondNum);break;
                case '/':label2.Text = Convert.ToString(FirstNum / SecondNum);break;
                case '^':label2.Text = Convert.ToString(Math.Pow(FirstNum , SecondNum));break;
                

            }
           label1.Text += "="+label2.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(label2.Text);
           label2.Text = "";
           label1.Text += "+";
          
            znak = '-';

        }

        private void Button10_Click(object sender, EventArgs e)
        {
           label2.Text += "0";
           label1.Text += "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           label1.Text += "1";
           label2.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           label1.Text += "2";
           label2.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {

           label1.Text += "3";
           label2.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           label1.Text += "4";
           label2.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
           label1.Text += "5";
           label2.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
           label1.Text += "6";
           label2.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
           label1.Text += "7";
           label2.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
           label1.Text += "8";
           label2.Text += "8";
        }

        private void Button13_Click(object sender, EventArgs e)
        {

                FirstNum = Convert.ToDouble(label2.Text);
               label2.Text = "";
               label1.Text += "+";
                znak = '+';               
                       
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(label2.Text);
           label2.Text = "";
           label1.Text += "*";
            znak = '*';
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(label2.Text);
           label2.Text = "";
           label1.Text += "/";
            znak = '/';
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(label2.Text);
           label2.Text = "";
           label1.Text += "^";
            znak = '^';
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            
            FirstNum = Convert.ToDouble(label2.Text);
           label2.Text = "";
           label2.Text= Convert.ToString(Math.Sqrt(FirstNum));

        }

  
      

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button19_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            znak = ' ';
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is the best calculator ", "Dima Kachenya");
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
           label2.Text += "9";
           label1.Text += "9";
            
        }
    }
}
