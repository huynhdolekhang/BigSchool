using System.Web;
using System.Web.Mvc;

namespace B3_L4_HuynhDoLeKhang
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
