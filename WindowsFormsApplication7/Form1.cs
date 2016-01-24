using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mg_Click(object sender, EventArgs e)
        {
            int max = 0;
            int maxsk = 0;
            int n = Int32.Parse(input1.Text);
            int ik = Int32.Parse(input2.Text);

            listBox1.Items.Clear();

            for (int i = n; i <= ik; i++)
            {
                int dalikliai = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) 
                    {
                        dalikliai++;
                        
                    }

                    if (dalikliai >= max)
                    {
                        max = dalikliai;
                        maxsk = i;
                    }

                    string o = "skaicius: " + i + " dalikliai: " + dalikliai;
                    listBox1.Items.Add(o);
                    Console.WriteLine(o);
                }

                rez.Text = maxsk.ToString();
                dlk.Text = max.ToString();
            }

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
