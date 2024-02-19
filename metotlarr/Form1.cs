using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metotlarr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getir()
        {
            textBox1.Text = "Furkan";
            textBox2.Text = "Masraf";
            textBox3.Text = "Bilgisayar Muhendisi";
            textBox4.Text = "Uskudar Universitesi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getir();
        }
    }
}
