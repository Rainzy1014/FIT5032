using System.Web;
using System.Web.Mvc;

namespace FIT5032_Week2_DatabaseFirst
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
