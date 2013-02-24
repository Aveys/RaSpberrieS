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
            progressBar1.Value = 10;
           // if (textBox1.Text != string.Empty)
                connect(textBox1.Text);
          //  else
          //      MessageBox.Show("Veuillez entrer une adresse");
        }

        private void connect(string p)
        {
            p = "https://developer.apple.com/news/rss/news.rss";
            StringBuilder rssContent = new StringBuilder(); //Construction du chaine de résultat
            XmlDocument rss = new XmlDocument(); //Creation de l'objet XML
            rss.Load(p); // Récupération du XML en ligne
            XmlNodeList rssList = rss.SelectNodes("rss/channel/item");//Décomposition en liste de noeud
            foreach (XmlNode rssNode in rssList) // boucle parcourant les noeud
            {
                XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                string title = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("link");
                string link = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("description");
                string description = rssSubNode != null ? rssSubNode.InnerText : "";

                rssContent.Append("<a href='" + link + "'>" +"<h1>"+ title +"</h1> "+"</a>\n<br>\n" + description+"\n");   
            }
            progressBar1.Value = 100;
            TextBox2.Text = rssContent.ToString(); //affichage de la chaine construite
            }
        }
    }