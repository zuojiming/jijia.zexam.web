using jijia.zexam.domain.DTO;
using jijia.zexam.domain.models;
using jijia.zexam.domain.Repository;
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
    }
}
