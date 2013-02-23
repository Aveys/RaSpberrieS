using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

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
            if (textBox1.Text != string.Empty)
                connect(textBox1.Text);
            else
                MessageBox.Show("Veuillez entrer une adresse");
        }

        private void connect(string p)
        {
            StringBuilder rssContent = new StringBuilder();
            XmlDocument rss = new XmlDocument();
            rss.Load(p);
            XmlNodeList rssList = rss.SelectNodes("rss/channel/item");
            foreach (XmlNode rssNode in rssList)
            {
                rssContent.Append(rssNode.Value + "\n");

                
            }
            textBox2.Text = rssContent.ToString();
            }

        }

    }