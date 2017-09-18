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
    /// 组织考试
    /// </summary>
    public class ExamController : BaseApiController
    {
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="exam"></param>
        /// <returns></returns>
        public HttpResponseMessage Save(Exam exam) {
            return Json("{\"s\":true,\"d\":1,\"m\":\"\"}");
        }
        /// <summary>
        /// 分页列表
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pagesize"></param>
        /// <param name="pageidx"></param>
        /// <returns></returns>
        public HttpResponseMessage GetPage(string name,int pagesize = 10 ,int pageidx = 1) {
            return Json("{\"s\":true,\"d\":{\"exams\":[{\"name\":\"考试名称\",\"statue\":\"10/*0未开始,10正在考试,20过期,30被取消*/\",\"timelength\":\"90\"}],\"pagecount\":1},\"m\":\"\"}");
        }
    }

    public struct Exam {
        public string name { get; set; }
        public float passcore { get; set; }
        public string begintime { get; set; }
        public int timelength { get; set; }
        public int ispublic { get; set; }
        public int id { get; set; }
    }
}
