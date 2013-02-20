using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
                connect(textBox1.Text);
            else
                MessageBox.Show("Veuillez entrer une adresse");
        }

        private void connect(string p)
        {
            throw new NotImplementedException();
        }

    }
}
