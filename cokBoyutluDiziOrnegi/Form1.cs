﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cokBoyutluDiziOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[,] bolgeler = new string[5, 2]
            {
                {"İstanbul","İzmit" },
                {"Ankara","Konya" },
                {"Antalya","Adana" },
                {"Rize","Trabzon" },
                {"İzmir","Muğla" }
            };

            for (int i = 0; i <= bolgeler.GetUpperBound(0); i++) 
            {
                for (int j = 0; j <= bolgeler.GetUpperBound(1); j++)
                {

                    listBox1.Items.Add(bolgeler[i,j]);

                }
            }
        }
    }
}
