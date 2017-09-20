using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace jijia.zexam.domain.Repository
{
    public class BaseRespository<T> : IRepository<T> where T : class, new()
    {
        zexam.domain.models.ZExamEntiteis db;
        public BaseRespository() {
            db = new models.ZExamEntiteis();
        }
        ~BaseRespository()
        {
            db.Dispose();
            db = null;
        }
        public int Create(T model)
        {
            db.Entry<T>(model).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }

        public int Edit(T model)
        {
            db.Set<T>().Attach(model);
            PropertyInfo[] props = model.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                if (prop.GetValue(model, null) != null)
                {
                    if (prop.GetValue(model, null).ToString() == "&nbsp;")
                        db.Entry(model).Property(prop.Name).CurrentValue = null;
                    db.Entry(model).Property(prop.Name).IsModified = true;
                }
            }
            return db.SaveChanges();
        }

        public int EditList(IEnumerable<T> models)
        {
            int result = 0;
            foreach (var item in models)
            {
                result += Edit(item);
            }
            return result;
        }

        public T Get(int id)
        {
            var o = db.Set<T>().Find(id);
            return o;
        }

        public IEnumerable<T> GetList(Func<T, bool> func)
        {
            var set = db.Set<T>().Where(func);
            return set;
        }

        public IEnumerable<T> GetPage(Func<T, bool> func, int pageIdx, int pageSize)
        {
            return db.Set<T>().Where(func).Skip((pageIdx - 1) * pageSize);
        }

        public IEnumerable<T> GetPage(Func<T, bool> func, int pageIdx, int pageSize,out int pagecount)
        {
            var sqldb = db.Set<T>().Where(func);
            int c = sqldb.Count();
            pagecount = c / pageSize + (c % pageSize > 0 ? 1 : 0);
            return sqldb.Skip((pageIdx - 1) * pageSize);
        }

        public int InsertList(IEnumerable<T> models)
        {
            var result = 0;
            foreach (var item in models)
            {
                result += Create(item);
            }
            return result;
        }

        public int Remove(T model)
        {
            db.Entry<T>(model).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }

        public int RemoveList(IEnumerable<T> models)
        {
            int result = 0;
            foreach (var item in models)
            {
                result += Remove(item);
            }
            return result;
        }

        public void Dispose()
        {
            
        }
    }
}
