using jijia.zexam.web.App_Start;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jijia.zexam.web.Controllers.Api
{
    public class UserClassController : BaseApiController
    {
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIdx"></param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage GetPage(string name,string code,int pageSize = 10,int pageIdx = 1) {
            return Json("{\"s\":\"true\",\"d\":{\"pagecount\":100,\"data\":[{\"code\":\"\",\"name\":\"\",\"id\":\"1\"}],\"pageidx\":\"1\",\"pagesize\":\"10\"},\"m\":\"\"}");
        }
        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Json("{\"s\":true,\"d\":{\"code\":\"11012011912\",\"name\":\"\",\"id\":\"1\"},\"m\":\"\"}");
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="userClass"></param>
        /// <returns></returns>
        [HttpPut]
        public HttpResponseMessage Insert([FromBody]UserClass userClass) {
            return Json("{\"s\":true,\"d\":1,\"m\":\"数据添加成功\"}");
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="userClass"></param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage Update([FromBody]UserClass userClass)
        {
            return Json("{\"s\":true,\"d\":1,\"m\":\"数据修改成功\"}");
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public HttpResponseMessage Delete(int id = 0)
        {
            return Json(" {\"s\":true,\"d\":1,\"m\":\"\"}");
        }
    }

    public struct UserClass {
        public string code { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }
}
