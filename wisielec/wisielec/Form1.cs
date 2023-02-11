using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wisielec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            Form Latwy = new frmHangman();
            Latwy.ShowDialog();
            
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            Form Sredni = new Form3();
            Sredni.ShowDialog();

        }

        private void Hard_Click(object sender, EventArgs e)
        {
            Form Ciezki = new Form4();
            Ciezki.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
