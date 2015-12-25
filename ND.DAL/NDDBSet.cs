using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ND.DAL
{
    public class NDDBSet<T> : DbSet<T> where T : class
    {
        public DB DB { get; set; }

        public NDDBSet(DB db)
        {
            DB = db;
        }

        virtual public void Add(T entity, bool save = true)
        {
            DB.Add(entity, save);
        }

        virtual public void Remove(T entity, bool save = true)
        {
            DB.Remove(entity);
        }

        virtual public void Update(T entity, bool save = true)
        {
            DB.Remove(entity);
        }
    }
}