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
        public string title
        {
            get
            {
                return this.m_title;
            }
            set;
        }

        private string m_author;
        public string author
        { 
            get
            {
                return this.m_author;
            }
            set;
        }
        //content?

        private UInt32 m_id;
        public UInt32 id
        {
            get
            {
                return this.m_id;
            } 
            set;
        }
        private DateTime m_date_pub;
        public DateTime datePub
        { 
            get
            {
                return this.m_date_pub;
            }
            set;
        }
        private Uri m_link;
        public Uri link
        { 
            get
            {
                return this.m_link;
            }
            set;
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
            set;
        }
        
        public void add( ArticleItem new_item )
        {
            this.items.Add(new_item);
        }

    }
}
