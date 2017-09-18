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
    /// 历史真题
    /// </summary>
    public class OldQusController : BaseApiController
    {
        /// <summary>
        /// 分页列表
        /// </summary>
        /// <param name="title"></param>
        /// <param name="year"></param>
        /// <param name="pagesize"></param>
        /// <param name="pageidx"></param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage GetPage(string title, string year, int pagesize = 10, int pageidx = 1) {
            return Json("{\"s\":true,\"d\":{\"pagecount\":\"100\",\"pageidx\":1,\"data\":[{\"categary\":\"单选题\",\"year\":2017,\"subject\":\"专业实务\",\"id\":\"1\",\"title\":\"题目\",\"type\":\"A!\"}],\"pagesize\":10},\"m\":\"\"}");
        }
        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage Get(int id) {
            return Json("{\"s\":true,\"d\":{\"categary\":\"单选题\",\"year\":2017,\"subject\":\"专业实务\",\"id\":\"1\",\"title\":\"题目\",\"type\":\"A!\"},\"m\":\"\"}");
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpPut]
        public HttpResponseMessage Insert(OverYearQus m) {
            return Json(" {\"s\":true,\"d\":1,\"m\":\"\"}");
        }
        /// <summary>
        /// 更新考试概念
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage Update([FromBody]OverYearQus m)
        {
            return Json(" {\"s\":true,\"d\":1,\"m\":\"\"}");
        }
        /// <summary>
        /// 更新题干
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/oldqus/updategroup")]
        public HttpResponseMessage UpdateGroup([FromBody]Group m)
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
        /// <summary>
        /// 删除题干
        /// </summary>
        /// <param name="id"></param>
        /// <param name="random"></param>
        /// <param name="parentrandom"></param>
        /// <param name="parentid"></param>
        /// <returns></returns>
        [HttpDelete]
        public HttpResponseMessage DeleteGroup(int id,string random,string parentrandom,string parentid)
        {
            return Json(" {\"s\":true,\"d\":1,\"m\":\"\"}");
        }
    }
}
