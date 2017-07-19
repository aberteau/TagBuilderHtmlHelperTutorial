using System.Web;
using System.Web.Mvc;

namespace Techeasy.Framework.Web.Mvc
{
    public class HtmlTag
        : IHtmlString
    {
        private TagBuilder TagBuilder { get; set; }

        private TagRenderMode RenderMode { get; set; }

        public HtmlTag(string tagName, TagRenderMode renderMode)
        {
            TagBuilder = new TagBuilder(tagName);
            RenderMode = renderMode;
        }

        public HtmlTag(string tagName)
            : this(tagName, TagRenderMode.Normal)
        { }

        public string ToHtmlString()
        {
            return TagBuilder.ToString(RenderMode);
        }

        public HtmlTag SetAttribute(string key, string value)
        {
            TagBuilder.MergeAttribute(key, value);
            return this;
        }

        public HtmlTag SetNameAttribute(string name)
        {
            SetAttribute("name", name);
            return this;
        }

        public HtmlTag SetIdAttribute(string name)
        {
            SetAttribute("id", name);
            return this;
        }

        public HtmlTag SetRequiredAttribute()
        {
            SetAttribute("required", string.Empty);
            return this;
        }

        public HtmlTag SetValueAttribute(string value)
        {
            SetAttribute("value", value);
            return this;
        }

        public HtmlTag SetTypeAttribute(string type)
        {
            SetAttribute("type", type);
            return this;
        }

        public HtmlTag AddCssClass(string value)
        {
            TagBuilder.AddCssClass(value);
            return this;
        }

        public HtmlTag SetInnerHtml(string innerHtml)
        {
            TagBuilder.InnerHtml = innerHtml;
            return this;
        }

        public HtmlTag SetInnerHtml(HtmlTag htmlTag)
        {
            TagBuilder.InnerHtml = htmlTag.ToHtmlString();
            return this;
        }

        public HtmlTag SetInnerText(string innerText)
        {
            TagBuilder.SetInnerText(innerText);
            return this;
        }

    }
}