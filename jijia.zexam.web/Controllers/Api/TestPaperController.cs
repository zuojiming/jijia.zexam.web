using jijia.zexam.domain.VO;
using jijia.zexam.web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jijia.zexam.web.Controllers.Api
{
    public class TestPaperController : BaseApiController
    {
        /// <summary>
        /// 根据答题类型自动出卷
        /// </summary>
        /// <param name="questionCategary"></param>
        /// <returns></returns>
        [HttpPut]
        public HttpResponseMessage CreateTestPager([FromBody]VTestPagerQusCategary[] questionCategary) {
            return Json("{\"id\":\"1/*试卷id*/\"}");
        }
        /// <summary>
        /// 读取一个试卷
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage Get(int id) {
            return Json("{\"s\":\"ture\",\"d\":{\"categary\":\"分类\",\"name\":\"\",\"totalscore\":\"100\",\"id\":\"1\",\"qustypes\":[{\"count\":\"5\",\"type\":\"0/*0单选题,1共用题干单选题*/\",\"itemscore\":\"5\",\"qus\":[{\"categary\":\"单选题\",\"year\":2017,\"subject\":\"专业实务\",\"id\":\"1\",\"title\":\"题目\",\"type\":\"A!\"}]}],\"title\":\"试卷标题\"},\"m\":\"\"}");
        }/// <summary>
        /// 试卷分页列表
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pagesize"></param>
        /// <param name="pageidx"></param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage GetPage(string name, int pagesize = 10, int pageidx = 1) {
            return Json("{\"s\":\"ture\",\"d\":{\"pagecount\":\"100\",\"data\":[{\"name\":\"试卷名称\",\"totalscore\":\"100\",\"id\":\"1\",\"createdtime\":\"2017 / 7 / 7 1:1:1\"}]},\"m\":\"\"}");
        }/// <summary>
        /// 更新
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage Update(VTestPaper m) {
            return Json("{\"s\":true,\"d\":1,\"m\":\"\"}");
        }/// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public HttpResponseMessage Delete(int id) {
            return Json("{\"s\":true,\"d\":1,\"m\":\"\"}");
        }
    }
}
