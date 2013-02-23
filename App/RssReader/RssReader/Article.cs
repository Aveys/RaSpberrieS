using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.ServiceModel.Syndication;


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
        public string title
        {
            get
            {
                return this.m_title;
            }
            set
            {

            }
        }

        private string m_author;
        public string author
        { 
            get
            {
                return this.m_author;
            }
            set
            {

            }
        }
        //content?

        private UInt32 m_id;
        public UInt32 id
        {
            get
            {
                return this.m_id;
            }
            set
            {

            }
        }
        private DateTime m_date_pub;
        public DateTime datePub
        { 
            get
            {
                return this.m_date_pub;
            }
            set
            {

            }
        }
        private Uri m_link;
        public Uri link
        { 
            get
            {
                return this.m_link;
            }
            set
            {

            }
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
        public ObservableCollection<ArticleItem> items
        {
            get
            {
                return this.m_items;
            }
            set
            {

            }
        }

        private string m_title;
        public string title
        {
            get
            {
                return this.m_title;
            }
            set
            {
                this.m_title = value;
            }
        }
        
        public void add( ArticleItem new_item )
        {
            this.items.Add(new_item);
        }

        public ArticlesData(string uriString)
        {
            Uri uri_tmp = new Uri(uriString);
            SyndicationFeed feed = new SyndicationFeed();

            feed.BaseUri = uri_tmp;
            
        }

    }

    class ArticlesDataSource
    {
        private ObservableCollection<ArticlesData> m_datas = new ObservableCollection<ArticlesData>();
        public ObservableCollection<ArticlesData> datas
        {
            get
            {
                return this.m_datas;
            }
            set
            {

            }
        }
    }
}
