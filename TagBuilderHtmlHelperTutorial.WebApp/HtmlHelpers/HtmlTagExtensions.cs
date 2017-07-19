using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Techeasy.Framework.Web.Mvc;

namespace Techeasy.TagBuilderHtmlHelperTutorial.WebApp.HtmlHelpers
{
    public static class HtmlTagExtensions
    {
        public static HtmlTag SetInnerHtml(this HtmlTag tag, HtmlTag iconTag, String text, ContentDisplayMode contentDisplayMode)
        {
            switch (contentDisplayMode)
            {
                case ContentDisplayMode.Text:
                    tag.SetInnerHtml(text);
                    break;
                case ContentDisplayMode.Icon:
                    tag.SetInnerHtml(iconTag.ToHtmlString());
                    break;

                case ContentDisplayMode.IconAndText:
                    tag.SetInnerHtml(iconTag.ToHtmlString() + " " + text);
                    break;
            }
            return tag;
        }
    }
}