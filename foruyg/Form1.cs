﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foruyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int defa;
            defa = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < defa; i++)
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
