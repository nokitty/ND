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

        virtual public void AddEx(T entity, bool save = true)
        {
            DB.Set<T>().Add(entity);
            if (save)
            {
                DB.SaveChanges();
            }
        }

        virtual public void RemoveEx(T entity, bool save = true)
        {
            DB.Set<T>().Remove(entity);
            if (save)
            {
                DB.SaveChanges();
            }
        }

        public void Update(T entity, bool save = true)
        {
            DB.Entry(entity).State = EntityState.Modified;
            if (save)
            {
                DB.SaveChanges();
            }
        }

        virtual public void UpdateEx(T entity, bool save = true)
        {
            Update(entity, save);
        }
    }
}