using jijia.zexam.web.Filters;
using System.Web;
using System.Web.Mvc;

namespace jijia.zexam.web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
