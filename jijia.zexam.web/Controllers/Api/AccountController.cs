using jijia.zexam.application.Apps;
using jijia.zexam.domain.DTO;
using jijia.zexam.domain.VO;
using jijia.zexam.web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace jijia.zexam.web.Controllers.Api
{
    public class AccountController : BaseApiController
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage Login([FromBody]VLoginModel l)
        {
            var m = new UserApp().Login(l.username,l.pwd,l.categary);
            if (m.s)
            {
                HttpCookie cookie = new HttpCookie("UserApp._LoginStatue","yes");
                
                Response.Cookies.Add(cookie);
            }
            return  Json(m);
        }
        [HttpGet]
        [Route("Account/LogOut/")]
        public HttpResponseMessage LogOut() {
            Request.Cookies.Clear();
            return Json(new ReturnModel() { m = "已经退出登录" , s = true }); 
        }
    }
}
