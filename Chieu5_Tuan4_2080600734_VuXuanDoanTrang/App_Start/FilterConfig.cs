using System.Web;
using System.Web.Mvc;

namespace Chieu5_Tuan4_2080600734_VuXuanDoanTrang
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
