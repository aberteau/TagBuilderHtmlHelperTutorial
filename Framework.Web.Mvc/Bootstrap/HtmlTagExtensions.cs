namespace Techeasy.Framework.Web.Mvc.Bootstrap
{
    public static class HtmlTagExtensions
    {
        public static HtmlTag SetTooltip(this HtmlTag htmlTag, string title)
        {
            HtmlTag tag = htmlTag.SetAttribute("data-toggle", "tooltip").SetAttribute("title", title);
            return tag;
        }
    }
}