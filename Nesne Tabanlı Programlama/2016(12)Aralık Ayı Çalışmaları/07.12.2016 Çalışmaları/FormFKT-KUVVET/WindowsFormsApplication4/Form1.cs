﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matematik mt1 = new Matematik(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text));
            if (textBox1.Text != "" && textBox2.Text == "")
            {
                textBox3.Text = Convert.ToString(mt1.faktoriyel());
            }
            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                
                textBox3.Text = Convert.ToString(mt1.usalma());
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                
            }
        }
    }
}
