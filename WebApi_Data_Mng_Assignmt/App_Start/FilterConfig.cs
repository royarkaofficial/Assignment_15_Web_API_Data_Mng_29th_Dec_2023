using System.Web;
using System.Web.Mvc;

namespace WebApi_Data_Mng_Assignmt
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
