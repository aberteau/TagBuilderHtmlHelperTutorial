using System;
using System.Web.Mvc;

namespace Techeasy.Framework.Web.Mvc.Bootstrap
{
    public static class HtmlHelperExtensions
    {
        #region Glyphicon Tags

        public static HtmlTag GlyphiconListSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.SpanTag();
            tag.AddCssClass("glyphicon glyphicon-list");
            return tag;
        }

        public static HtmlTag GlyphiconFilmSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.SpanTag();
            tag.AddCssClass("glyphicon glyphicon-film");
            return tag;
        }

        public static HtmlTag GlyphiconPlusSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.SpanTag();
            tag.AddCssClass("glyphicon glyphicon-plus");
            return tag;
        }

        public static HtmlTag GlyphiconPencilSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.SpanTag();
            tag.AddCssClass("glyphicon glyphicon-pencil");
            return tag;
        }

        public static HtmlTag GlyphiconTrashSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.SpanTag();
            tag.AddCssClass("glyphicon glyphicon-trash");
            return tag;
        }

        public static HtmlTag GlyphiconFloppyDiskSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.SpanTag();
            tag.AddCssClass("glyphicon glyphicon-floppy-disk");
            return tag;
        }

        public static HtmlTag GlyphiconBanCircleSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.SpanTag();
            tag.AddCssClass("glyphicon glyphicon-ban-circle");
            return tag;
        }

        public static HtmlTag GlyphiconOkCircleSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.SpanTag();
            tag.AddCssClass("glyphicon glyphicon-ok-circle");
            return tag;
        }

        public static HtmlTag GlyphiconSearchSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.SpanTag();
            tag.AddCssClass("glyphicon glyphicon-search");
            return tag;
        }

        public static HtmlTag GlyphiconEjectSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.SpanTag();
            tag.AddCssClass("glyphicon glyphicon-eject");
            return tag;
        }

        #endregion

        private static string GetBtnClass(Nullable<ButtonStyle> buttonStyle)
        {
            if (buttonStyle.HasValue)
            {
                switch (buttonStyle.Value)
                {
                    case ButtonStyle.Primary:
                        return "btn btn-primary";
                    case ButtonStyle.Secondary:
                        return "btn btn-secondary";
                    case ButtonStyle.Success:
                        return "btn btn-success";
                    case ButtonStyle.Info:
                        return "btn btn-info";
                    case ButtonStyle.Warning:
                        return "btn btn-warning";
                    case ButtonStyle.Danger:
                        return "btn btn-danger";
                    case ButtonStyle.Link:
                        return "btn btn-link";
                }
            }

            return "btn btn-default";
        }

        #region AnchorButton Tags

        public static HtmlTag AnchorButtonHtmlTag(this HtmlHelper helper, string href, Nullable<ButtonStyle> buttonStyle = null)
        {
            HtmlTag tag = helper.HtmlTag("a");
            string btnClass = GetBtnClass(buttonStyle);
            tag.AddCssClass(btnClass).SetAttribute("role", "button").SetAttribute("href", href);
            return tag;
        }

        public static HtmlTag AnchorButtonHtmlTag(this HtmlHelper helper, string href, String text, Nullable<ButtonStyle> buttonStyle = null)
        {
            HtmlTag tag = helper.AnchorButtonHtmlTag(href, buttonStyle);
            tag.SetInnerText(text);
            return tag;
        }

        public static HtmlTag AnchorButtonHtmlTag(this HtmlHelper helper, string href, HtmlTag iconTag, Nullable<ButtonStyle> buttonStyle = null)
        {
            HtmlTag tag = helper.AnchorButtonHtmlTag(href, buttonStyle);
            tag.SetInnerHtml(iconTag);
            return tag;
        }

        #endregion

        #region Button Tags

        public static HtmlTag ButtonHtmlTag(this HtmlHelper helper, Nullable<ButtonStyle> buttonStyle = null)
        {
            HtmlTag tag = helper.HtmlTag("button");
            string btnClass = GetBtnClass(buttonStyle);
            tag.AddCssClass(btnClass);
            return tag;
        }

        public static HtmlTag ButtonHtmlTag(this HtmlHelper helper, String text, Nullable<ButtonStyle> buttonStyle = null)
        {
            HtmlTag tag = helper.ButtonHtmlTag(buttonStyle);
            tag.SetInnerHtml(text);
            return tag;
        }

        public static HtmlTag ListAnchorButtonHtmlTag(this HtmlHelper helper, string href)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconListSpanTag();
            return helper.AnchorButtonHtmlTag(href, glyphiconSpanTag);
        }

        #endregion
    }
}