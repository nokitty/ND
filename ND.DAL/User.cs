using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ND.DAL
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }

        public User()
        {
            CreateTime = DateTime.Now;
        }
    }
}