using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace ClientWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnApple_Click(object sender, RoutedEventArgs e)
        {
            String p = "https://developer.apple.com/news/rss/news.rss";
            this.connect(p);
        }
        private void connect(string p)
        {

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

                rssContent.Append("<a href='" + link + "'>" + "<h1>" + title + "</h1> " + "</a>\n<br>\n" + description + "\n");
            }

            txtRes.Text = rssContent.ToString(); //affichage de la chaine construite
        }
    }
}

