using System.Web;
using System.Web.Mvc;

namespace Techeasy.Framework.Web.Mvc
{
    public class HtmlTag
        : IHtmlString
    {
        private readonly TagBuilder _tagBuilder;

        private readonly TagRenderMode _renderMode;

        public HtmlTag(string tagName, TagRenderMode renderMode)
        {
            _tagBuilder = new TagBuilder(tagName);
            _renderMode = renderMode;
        }

        public HtmlTag(string tagName)
            : this(tagName, TagRenderMode.Normal)
        { }

        public string ToHtmlString()
        {
            return _tagBuilder.ToString(_renderMode);
        }

        public HtmlTag SetAttribute(string key, string value)
        {
            _tagBuilder.MergeAttribute(key, value);
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
            _tagBuilder.AddCssClass(value);
            return this;
        }

        public HtmlTag SetInnerHtml(string innerHtml)
        {
            _tagBuilder.InnerHtml = innerHtml;
            return this;
        }

        public HtmlTag SetInnerHtml(HtmlTag htmlTag)
        {
            _tagBuilder.InnerHtml = htmlTag.ToHtmlString();
            return this;
        }

        public HtmlTag SetInnerText(string innerText)
        {
            _tagBuilder.SetInnerText(innerText);
            return this;
        }
    }
}