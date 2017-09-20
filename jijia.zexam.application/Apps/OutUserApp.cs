using jijia.zexam.domain.DTO;
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
    public class OutUserApp
    {
        public ReturnModel GetList(string username, string studydate, int classid, int pagesize = 10, int pageidx = 1)
        {
            var userdb = new BaseRespository<S_User>();
            int pagecount = 0;
            var sqlreslt = userdb.GetPage(f => {
                bool eu = true, ed = true, ec = true;
                if (!string.IsNullOrWhiteSpace(username))
                {
                    eu = username.IndexOf(f.UserName) >= 0;
                }
                DateTime dt;
                if (DateTime.TryParse(studydate, out dt) && f.StudyDate.HasValue)
                {
                    ed = f.StudyDate.Value.Year == dt.Year;
                }
                if (classid > 0)
                {
                    ec = f.ClassId == classid;
                }
                return eu && ed && ec && f.Categary == 1;
            }, pageidx, pagesize, out pagecount).ToList();
            return new ReturnModel
            {
                m = "",
                s = true,
                d = new
                {
                    pagecount = pagecount,
                    data = sqlreslt.Select(s => {
                        s.Pwd = string.Empty;
                        return SimpleMapper.Map<S_User, VOutUser>(s);
                    })
                }
            };
        }

        public ReturnModel Get(int id) {
            var userdb = new BaseRespository<S_User>();
            return new ReturnModel { d = SimpleMapper.Map<S_User,VOutUser>(userdb.Get(id)) };
        }

        public ReturnModel Insert(VOutUser vOutUser) {
            var userdb = new BaseRespository<S_User>();
            return new ReturnModel { d = userdb.Create(SimpleMapper.Map<VOutUser, S_User>(vOutUser)) };
        }
        public ReturnModel Update(VOutUser vOutUser)
        {
            var userdb = new BaseRespository<S_User>();
            return new ReturnModel { d = userdb.Edit(SimpleMapper.Map<VOutUser, S_User>(vOutUser)) };
        }
        public ReturnModel Delete(int id)
        {
            var userdb = new BaseRespository<S_User>();
            return new ReturnModel { d = userdb.Remove(Get(id).d as S_User) };
        }
    }
}
