using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace beeping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                System.Console.Beep();
                textBox1.Text += "+";
                Refresh();
                Thread.Sleep(1000);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
