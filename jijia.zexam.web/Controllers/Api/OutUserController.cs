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
    /// 校外用户
    /// </summary>
    public class OutUserController : BaseApiController
    {
        /// <summary>
        /// 读取列表
        /// </summary>
        /// <param name="username"></param>
        /// <param name="studydate"></param>
        /// <param name="classid"></param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage Get(string username,string studydate,int classid,int pagesize = 10, int pageidx = 1) {
            return Json("{\"s\":true,\"d\":{\"pagecount\":100,\"data\":[{\"classid\":\"1\",\"phone\":\"11012011912\",\"sex\":\"1\",\"id\":\"1\",\"studydate\":\"2017/7/7\",\"class\":\"护士1班\",\"realname\":\"左琦\",\"username\":\"admin\"}],\"pageidx\":1,\"pagesize\":10},\"m\":\"\"}");
        }
        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage Get(int id) {
            return Json("{\"s\":true,\"d\":{\"classid\":\"1\",\"phone\":\"11012011912\",\"sex\":\"1\",\"id\":\"1\",\"studydate\":\"2017/7/7\",\"class\":\"护士1班\",\"username\":\"admin\",\"realname\":\"左琦\"},\"m\":\"\"}");
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="inUser"></param>
        /// <returns></returns>
        [HttpPut]
        public HttpResponseMessage Insert([FromBody]OutUser inUser) {
            return Json("{\"s\":true,\"d\":1,\"m\":\"数据添加成功\"}");
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="inUser"></param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage Update([FromBody]OutUser inUser)
        {
            if (string.IsNullOrWhiteSpace(inUser.username))
            {
                return Import(null);
            }
            return Json("{\"s\":true,\"d\":1,\"m\":\"数据修改成功\"}");
        }
        /// <summary>
        /// 导入
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
        public HttpResponseMessage Delete([FromBody]int? id)
        {
            return Json("{\"s\":true,\"d\":1,\"m\":\"\"}");
        }
    }
}
