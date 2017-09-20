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
    public class UserApp
    {
        public static string _LoginStatue = "_exam_login_autostatue";
        public ReturnModel Login(string username, string pwd, int usercategary)
        {
            var userdb = new BaseRespository<S_User>();
            var usersql = userdb.GetList(f => f.UserName == username && f.Categary == usercategary);
            var user = usersql.FirstOrDefault();
            if (user == null)
            {
                return new ReturnModel { m = "用户名错误", s = false, d = null };
            }
            else
                if (!user.Pwd.Equals(pwd, StringComparison.Ordinal))
            {
                return new ReturnModel { m = "密码错误", s = false, d = null };
            }
            else
            {
                return new ReturnModel { m = "登录成功！", s = true, d = new { uid = user.Id, model = user } };
            }
        }

        public ReturnModel GetList(string username, string studydate, int classid, int pagesize = 10, int pageidx = 1) {
            var userdb = new BaseRespository<S_User>();
            int pagecount = 0;
            var sqlreslt = userdb.GetPage(f=> {
                bool eu = true,ed = true, ec = true;
                if (!string.IsNullOrWhiteSpace(username)) {
                    eu = username.IndexOf(f.UserName) >= 0;
                }
                DateTime dt;
                if (DateTime.TryParse(studydate, out dt) && f.StudyDate.HasValue)
                {
                    ed = f.StudyDate.Value.Year == dt.Year;
                }
                if (classid > 0) {
                    ec = f.ClassId == classid;
                }
                return eu && ed && ec && f.Categary == 0;
            },pageidx, pagesize,out pagecount).ToList();
            return new ReturnModel
            {
                m = "",
                s = true,
                d = new
                {
                    pagecount = pagecount,
                    data = sqlreslt.Select(s => {
                        s.Pwd = string.Empty;
                        return SimpleMapper.Map<S_User, VInUser>(s);
                    })
                }
            };
        }

        public ReturnModel Get(int id) {
            var db = new BaseRespository<S_User>();
            return new ReturnModel { d = db.Get(id), s = true, m = "" };
        }

        public ReturnModel Insert(VInUser vInUser) {
            var db = new BaseRespository<S_User>();
            return new ReturnModel { d = db.Create(SimpleMapper.Map<VInUser, S_User>(vInUser)), s = true, m = "数据添加成功" };
        }

        public ReturnModel Update(VInUser vInUser)
        {
            var db = new BaseRespository<S_User>();
            return new ReturnModel { d = db.Edit(SimpleMapper.Map<VInUser, S_User>(vInUser)), s = true, m = "数据添加成功" };
        }

        public ReturnModel Delete(int id) {
            var db = new BaseRespository<S_User>();
            return new ReturnModel { d = db.Remove(Get(id).d as S_User), s = true, m = "数据删除成功" };
        }
    }
}
