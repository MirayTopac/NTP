﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            do
            {
                MessageBox.Show("Döngü çalışıyor.");
                if (a == 5)
                {
                    MessageBox.Show("Döngü durdu.");
                    break;
                }
                a++;
            } while (a < 10);
            }
    }
}
