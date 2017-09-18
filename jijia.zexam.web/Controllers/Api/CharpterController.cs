using jijia.zexam.web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jijia.zexam.web.Controllers.Api
{
    /// <summary>
    /// 章节
    /// </summary>
    public class CharpterController : BaseApiController
    {
        /// <summary>
        /// 章节分页列表
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pagesize"></param>
        /// <param name="pageidx"></param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage GetPage(string name,int pagesize = 10,int pageidx = 1) {
            return Json("{\"s\":true,\"d\":{\"pagecount\":100,\"data\":[{\"sortno\":\"\",\"name\":\"\",\"id\":\"1\"}],\"pageidx\":1,\"pagesize\":10},\"m\":\"\"}");
        }
        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage Get(int id) {
            return Json("{\"s\":true,\"d\":{\"sortno\":\"\",\"name\":\"\",\"id\":\"1\"},\"m\":\"\"}");
        }
        [HttpGet]
        public HttpResponseMessage GetChild(int parentid) {
            return Json("{\"s\":true,\"d\":[{\"sortno\":\"\",\"name\":\"\",\"id\":\"1\"}],\"m\":\"\"}");
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpPut]
        public HttpResponseMessage Insert(Charpter m) {
            return Json("{\"s\":true,\"d\":1,\"m\":\"\"}");
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage Update(Charpter m)
        {
            return Json("{\"s\":true,\"d\":1,\"m\":\"\"}");
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            return Json(" {\"s\":true,\"d\":1,\"m\":\"\"}");
        }
    }

    public struct Charpter {
        public string name { get; set; }
        public string sortno { get; set; }
        public int id { get; set; }
    }
}
