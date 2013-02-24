using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections.ObjectModel;

namespace RssReader
{
    /**
     * <summary>
     * Contains information about a single RSS post.
     * </summary>
     * 
     */
    class ArticleItem
    {
        private string m_title;

        public string Title
        {
            get { return m_title; }
            set { m_title = value; }
        }


        private string m_author;

        private UInt32 m_id;

        public UInt32 Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        private DateTime m_date_pub;

        public DateTime Date_pub
        {
            get { return m_date_pub; }
            set { m_date_pub = value; }
        }
        private Uri m_link;

        public Uri Link
        {
            get { return m_link; }
            set { m_link = value; }
        }
       

    }
    /**
     * <summary>
     *  
     * </summary>
     */
    class ArticlesData
    {
        private ObservableCollection<ArticleItem> m_items = new ObservableCollection<ArticleItem>();

        internal ObservableCollection<ArticleItem> Items
        {
            get { return m_items; }
            set { m_items = value; }
        }
        
        public void add( ArticleItem new_item )
        {
            //this.m_items.Add(new_item); erreur de compilation sur cette ligne
        }

    }

    class ArticlesDataSource
    {
        private ObservableCollection<ArticlesData> m_datas = new ObservableCollection<ArticlesData>();

        internal ObservableCollection<ArticlesData> Datas
        {
            get { return m_datas; }
            set { m_datas = value; }
        }


    }
}
