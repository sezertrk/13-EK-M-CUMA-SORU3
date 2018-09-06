using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication38
{
    public partial class Form1 : Form
    {
        private string HATA;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ka = textBox1.Text;
            string sf = textBox2.Text;

            if (ka == "admin" && sf == "admin")
            { MessageBox.Show(" MERHABA PATRON "); }
            else if (ka == "satıcı" && sf == "1234")
            { MessageBox.Show("MERHABA SATICI"); }
            else if (ka == "kasiyer" && sf == "1235")
            { MessageBox.Show("MERHABA KASİYER"); }
            else if (ka == "temizlkçi" && sf == "4444")
            { MessageBox.Show("MERHABA TEMİZLİKÇİ"); }
            else
            { MessageBox.Show("Hatalı Giriş!...", HATA, MessageBoxButtons.OK, MessageBoxIcon.Error); }



        }
    }
}

