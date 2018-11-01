using System;

namespace FYC.DataAccess.Entities
{
    public class Blog
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string ShortPostContent { get; set; }
        public string FullPostContent { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public DateTime PostAddedDate { get; set; }
        public DateTime PostUpdatedDate { get; set; }
        public bool IsCommented { get; set; }
        public bool IsShared { get; set; }
        public bool IsPrivate { get; set; }
        public int NumberOfViews { get; set; }
        public string PostUrl { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
