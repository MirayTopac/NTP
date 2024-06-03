using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toplamidiziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[] sayilar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < sayilar.Length;i++);
            {
                toplam += sayilar[i];
            }
                MessageBox.Show("Toplam değeri:" + toplam.ToString());   
            }
        }
   }

