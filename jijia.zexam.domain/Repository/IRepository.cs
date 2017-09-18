using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jijia.zexam.domain.Repository
{
    public interface IRepository<T> where T:class,new ()
    {
        T Get(int id);
        IEnumerable<T> GetList(Func<T,bool> func);
        IEnumerable<T> GetPage(Func<T, bool> func,int pageIdx,int pageSize);
        int Create(T model);
        int InsertList(IEnumerable<T> models);
        int Edit(T model);
        int EditList(IEnumerable<T> models);
        int Remove(T model);
        int RemoveList(IEnumerable<T> models);
    }
}
