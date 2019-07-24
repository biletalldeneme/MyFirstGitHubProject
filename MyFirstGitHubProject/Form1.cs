using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstGitHubProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Carp(1, 4).ToString());
        }

        private int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        private int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        private int Topla2(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
