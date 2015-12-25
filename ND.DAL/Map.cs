using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ND.DAL
{
    public class Map
    {
        public int ID { get; set; }
        public int BeginID { get; set; }
        virtual public Article Begin { get; set; }
        public int EndID { get; set; }
        virtual public Article End { get; set; }
        public DateTime CreateTime { get; set; }
    }
}