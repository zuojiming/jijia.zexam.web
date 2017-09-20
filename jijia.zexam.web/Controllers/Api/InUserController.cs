using jijia.zexam.application.Apps;
using jijia.zexam.domain.VO;
using jijia.zexam.web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace jijia.zexam.web.Controllers.Api
{
    /// <summary>
    /// 校内用户
    /// </summary>
    public class InUserController : BaseApiController
    {
        public UserApp UserApp { get; set; } = new UserApp();
        /// <summary>
        /// 分页列表
        /// </summary>
        /// <param name="username"></param>
        /// <param name="studydate"></param>
        /// <param name="classid"></param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage Get(string username,string studydate, int classid,int pagesize=10,int pageidx = 1) {
            
            return Json(UserApp.GetList(username, studydate, classid, pagesize, pageidx));
            //return Json("{\"s\":true,\"d\":{\"pagecount\":100,\"data\":[{\"classid\":\"1\",\"phone\":\"11012011912\",\"sex\":\"1\",\"id\":\"1\",\"studydate\":\"2017/7/7\",\"class\":\"护士1班\",\"realname\":\"左琦\",\"username\":\"admin\"}],\"pageidx\":1,\"pagesize\":10},\"m\":\"\"}");
        }
        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage Get(int id) {
            return Json(UserApp.Get(id));
            //return Json("{\"s\":true,\"d\":{\"classid\":\"1\",\"phone\":\"11012011912\",\"sex\":\"1\",\"id\":\"1\",\"studydate\":\"2017/7/7\",\"class\":\"护士1班\",\"username\":\"admin\",\"realname\":\"左琦\"},\"m\":\"\"}");
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="inUser"></param>
        /// <returns></returns>
        [HttpPut]
        public HttpResponseMessage Insert([FromBody]VInUser inUser) {
            return Json(UserApp.Insert(inUser));
            //return Json("{\"s\":true,\"d\":1,\"m\":\"数据添加成功\"}");
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="inUser"></param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage Update([FromBody]VInUser inUser)
        {
            if (Request.Files.Count > 0)
            {
                return Import(null);
            }
            return Json(UserApp.Update(inUser));
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPatch]
        public HttpResponseMessage Import(HttpPostedFile file)
        {
            return Json("{\"s\":true,\"d\":1,\"m\":\"数据修改成功\"}");
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            return Json(UserApp.Delete(id));
            //return Json("{\"s\":true,\"d\":1,\"m\":\"\"}");
        }
    }
}
