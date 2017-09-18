using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace jijia.zexam.web.App_Start
{
    public class BaseApiController : ApiController
    {
        [NonAction]
        public HttpResponseMessage Json(string c) {
            StringContent content = new StringContent(c, Encoding.UTF8, "application/json");
            var msg = new HttpResponseMessage();
            msg.Content = content;
            return msg;
        }
        [NonAction]
        public HttpResponseMessage Json(object r)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(r), Encoding.UTF8, "application/json");
            var msg = new HttpResponseMessage();
            msg.Content = content;
            return msg;
        }
        
        public HttpResponse Response {
            get {
                return HttpContext.Current.Response;
            }
        }

        public HttpResponse Request
        {
            get
            {
                return HttpContext.Current.Request;
            }
        }
    }
}