using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Transactions;

namespace ND.DAL
{
    public class DB : DbContext
    {
        #region 数据表
        public NDDBSet<User> Users { get; set; }
        public NDDBSet<Article> Articles { get; set; }
        public NDDBSet<Map> Maps { get; set; }
        #endregion

        #region 构造函数
        public DB()
            : base("DB")
        {
            Users = new NDDBSet<User>(this);
            Articles = new NDDBSet<Article>(this);
            Maps = new NDDBSet<Map>(this);
        }
        #endregion

        #region 增删改
        public void Add<T>(T entity, bool save = true) where T : class
        {
            this.Set<T>().Add(entity);
            if (save)
            {
                this.SaveChanges();
            }
        }

        public void Remove<T>(T entity, bool save = true) where T : class
        {
            this.Set<T>().Remove(entity);
            if (save)
            {
                this.SaveChanges();
            }
        }

        public void Update<T>(T entity, bool save = true) where T : class
        {
            this.Entry<T>(entity).State = EntityState.Modified;
            if (save)
            {
                this.SaveChanges();
            }
        }
        #endregion

        #region 事务处理
        public void Transaction(Action action)
        {
            using (var transaction = new TransactionScope())
            {
                if (action != null)
                    action();
                transaction.Complete();
            }
        }
        #endregion

    }
}