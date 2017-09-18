using jijia.zexam.domain.models;
using jijia.zexam.domain.Repository;
using jijia.zexam.web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jijia.zexam.web.Controllers.Api
{
    public class TestPaperQusController : BaseApiController
    {
        /// <summary>
        /// 保存试卷所有细节
        /// </summary>
        /// <param name="qus"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/testpaperqus/saveall")]
        public HttpResponseMessage Save(OverYearQus qus) {
            //BaseRespository<Q_CharpterQuestion>

            return Json("{\"s\":true,\"d\":1,\"m\":\"\"}");
        }
        /// <summary>
        /// 保存试卷题干
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        [HttpPost]

        public HttpResponseMessage Save(Group group)
        {
            return Json("{\"s\":true,\"d\":1,\"m\":\"\"}");
        }
        /// <summary>
        /// 删除试卷
        /// </summary>
        /// <param name="testpagerId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public HttpResponseMessage Delete(int testpagerId,int id)
        {
            return Json("{\"s\":true,\"d\":1,\"m\":\"\"}");
        }
    }
}
