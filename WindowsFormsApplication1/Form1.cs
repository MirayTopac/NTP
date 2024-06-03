using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yemek = Convert.ToString(textBox1.Text);//yemek değerini girp istenenin girilmesini sağladım.
            switch (yemek)
            {
                case "hamburger"://eğer textbox1e hamburger yazıldıysa aşağıdaki mesajı gönder.
                    MessageBox.Show("İçindekiler:Kıyma,Turşu,Marul,Dometes,Burger sos.Fiyat:300");
                        break;
                case "pizza"://eğer textbox1e pizza yazıldıysa aşağıdaki mesajı gönder.
                    MessageBox.Show("İçindekiler:Sos,Peynir,Mantar,Dometes,Sucuk,Sosiz.Fiyat:250");
                        break;
                default://eğer yanlış ya da birşey yazılmadıysa hata mesajı gönder.
                    MessageBox.Show("Hata lütfen birşey yazın!");
                    break;
            }
        }
    }
}
