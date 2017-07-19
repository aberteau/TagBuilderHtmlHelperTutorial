using System.Web.Mvc;

namespace Techeasy.Framework.Web.Mvc
{
    public static class HtmlHelperExtensions
    {
        public static HtmlTag HtmlTag(this HtmlHelper helper, string tagName)
        {
            return new HtmlTag(tagName);
        }

        public static HtmlTag HtmlTag(this HtmlHelper helper, string tagName, TagRenderMode renderMode)
        {
            return new HtmlTag(tagName, renderMode);
        }

        public static HtmlTag SelectTag(this HtmlHelper helper)
        {
            HtmlTag htmlTag = helper.HtmlTag("select");
            return htmlTag;
        }

        public static HtmlTag InputTag(this HtmlHelper helper, string type)
        {
            HtmlTag htmlTag = helper.HtmlTag("input", TagRenderMode.SelfClosing);
            htmlTag.SetTypeAttribute(type);
            return htmlTag;
        }

        public static HtmlTag TextInputTag(this HtmlHelper helper)
        {
            HtmlTag htmlTag = helper.InputTag("text");
            return htmlTag;
        }

        public static HtmlTag DateInputTag(this HtmlHelper helper)
        {
            HtmlTag htmlTag = helper.InputTag("date");
            return htmlTag;
        }

        public static HtmlTag CheckboxInputTag(this HtmlHelper helper)
        {
            HtmlTag htmlTag = helper.InputTag("checkbox");
            return htmlTag;
        }

        public static HtmlTag SpanTag(this HtmlHelper helper)
        {
            HtmlTag htmlTag = helper.HtmlTag("span");
            return htmlTag;
        }

        public static HtmlTag BeginTr(this HtmlHelper helper)
        {
            HtmlTag htmlTag = helper.HtmlTag("tr", TagRenderMode.StartTag);
            return htmlTag;
        }

        public static HtmlTag EndTr(this HtmlHelper helper)
        {
            HtmlTag htmlTag = helper.HtmlTag("tr", TagRenderMode.EndTag);
            return htmlTag;
        }
    }
}