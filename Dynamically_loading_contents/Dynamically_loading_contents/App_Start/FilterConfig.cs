using System.Web;
using System.Web.Mvc;

namespace Dynamically_loading_contents
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
