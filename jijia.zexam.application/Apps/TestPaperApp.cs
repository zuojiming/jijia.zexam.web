using jijia.zexam.domain.models;
using jijia.zexam.domain.Repository;
using jijia.zexam.domain.Tools;
using jijia.zexam.domain.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jijia.zexam.application.Apps
{
    public class TestPaperApp : BaseRespository<T_TestPaper>
    {
        public IEnumerable<T_TestPaper> GetPape(string name,int pagesize = 10,int pageidx = 1) {
            var sql = base.GetPage(f => f.Name.IndexOf(name) >= 0,pageidx,pagesize);
            return sql;
        }

        public T_TestPaper Get(int id) {
            var o = base.Get(id);
            return o;
        }

        public int Update(VTestPaper paper) {
            
            return 1;
            //base.Edit();
        }
    }
}
