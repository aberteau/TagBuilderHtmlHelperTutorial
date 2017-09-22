using System.Web.Mvc;

namespace Techeasy.Framework.Web.Mvc.Bootstrap
{
    public static class HtmlHelperExtensions
    {
        #region Glyphicon Tags

        public static HtmlTag GlyphiconListSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.HtmlTag("span");
            tag.AddCssClass("glyphicon glyphicon-list");
            return tag;
        }

        public static HtmlTag GlyphiconFilmSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.HtmlTag("span");
            tag.AddCssClass("glyphicon glyphicon-film");
            return tag;
        }

        public static HtmlTag GlyphiconPlusSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.HtmlTag("span");
            tag.AddCssClass("glyphicon glyphicon-plus");
            return tag;
        }

        public static HtmlTag GlyphiconPencilSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.HtmlTag("span");
            tag.AddCssClass("glyphicon glyphicon-pencil");
            return tag;
        }

        public static HtmlTag GlyphiconTrashSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.HtmlTag("span");
            tag.AddCssClass("glyphicon glyphicon-trash");
            return tag;
        }

        public static HtmlTag GlyphiconFloppyDiskSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.HtmlTag("span");
            tag.AddCssClass("glyphicon glyphicon-floppy-disk");
            return tag;
        }

        public static HtmlTag GlyphiconBanCircleSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.HtmlTag("span");
            tag.AddCssClass("glyphicon glyphicon-ban-circle");
            return tag;
        }

        public static HtmlTag GlyphiconOkCircleSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.HtmlTag("span");
            tag.AddCssClass("glyphicon glyphicon-ok-circle");
            return tag;
        }

        public static HtmlTag GlyphiconSearchSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.HtmlTag("span");
            tag.AddCssClass("glyphicon glyphicon-search");
            return tag;
        }

        public static HtmlTag GlyphiconEjectSpanTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.HtmlTag("span");
            tag.AddCssClass("glyphicon glyphicon-eject");
            return tag;
        }

        #endregion

        public static HtmlTag ActionAnchorButtonHtmlTag(this HtmlHelper helper, string href)
        {
            HtmlTag tag = helper.HtmlTag("a");
            tag.AddCssClass("btn btn-default").SetAttribute("role", "button").SetAttribute("href", href);
            return tag;
        }

        public static HtmlTag ActionButtonHtmlTag(this HtmlHelper helper)
        {
            HtmlTag tag = helper.HtmlTag("button");
            tag.AddCssClass("btn btn-default");
            return tag;
        }
    }
}