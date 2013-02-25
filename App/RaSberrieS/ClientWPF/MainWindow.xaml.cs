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
using MahApps.Metro.Controls;
using MahApps.Metro.Actions;

namespace ClientWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private String connect(string p)
        {

            StringBuilder rssContent = new StringBuilder(); //Construction du chaine de résultat
            XmlDocument rss = new XmlDocument(); //Creation de l'objet XML
            rss.Load(p); // Récupération du XML en ligne (multi-threading à prevoir car cette fonction est bloquante)
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

            return rssContent.ToString(); //affichage de la chaine construite
        }

        private void btnCheck_Click_1(object sender, RoutedEventArgs e)
        {
            String res;
            String p = txtAdresse.Text;
            if (p != null && p!="")
            {
                pr1.IsActive = true;
               // System.Threading.Thread.Sleep(5000);
                res = this.connect(p);
                pr1.IsActive = false;
                tB.Visibility = Visibility.Visible;
               // System.Threading.Thread.Sleep(5000);
                tB.Text = res;
            }
            else
                MessageBox.Show("Erreur : le champ d'adresse est vide");
        }
    }
}

