using System.Web.Mvc;

namespace Techeasy.TagBuilderHtmlHelperTutorial.WebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
