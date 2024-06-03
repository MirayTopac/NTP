using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say = 0;
            do
            {
                MessageBox.Show("Döngü çalışıyor.");
                if (say == 5)
                {
                    MessageBox.Show("Döngü durdu.");
                    break;
                }
                say++;
            } while (say < 10);
        }
    }
}
