using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ND.DAL
{
    public class Article
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public int CreatorID { get; set; }
        virtual public User Creator { get; set; }
        public DateTime CreateTime { get; set; }
    }
}