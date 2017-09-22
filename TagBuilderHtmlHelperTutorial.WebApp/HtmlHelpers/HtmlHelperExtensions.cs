using System;
using System.Web.Mvc;
using Techeasy.Framework.Web.Mvc;
using Techeasy.Framework.Web.Mvc.Bootstrap;

namespace Techeasy.TagBuilderHtmlHelperTutorial.WebApp.HtmlHelpers
{
    public static class HtmlHelperExtensions
    {
        public static HtmlTag SaveActionSubmitButtonHtmlTag(this HtmlHelper helper)
        {
            return helper.ButtonHtmlTag().SetTypeAttribute("submit").SetInnerText("Enregistrer");
        }

        public static HtmlTag AnchorButtonHtmlTag(this HtmlHelper helper, string href, HtmlTag iconTag, String tooltip)
        {
            HtmlTag tag = helper.AnchorButtonHtmlTag(href);
            tag.SetInnerHtml(iconTag).SetTooltip(tooltip);
            return tag;
        }

        public static HtmlTag ButtonHtmlTag(this HtmlHelper helper, HtmlTag iconTag, String tooltip)
        {
            HtmlTag tag = helper.ButtonHtmlTag();
            tag.SetInnerHtml(iconTag).SetTooltip(tooltip);
            return tag;
        }

        public static HtmlTag ListActionAnchorButtonHtmlTag(this HtmlHelper helper, string href, string tooltip)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconListSpanTag();
            return helper.AnchorButtonHtmlTag(href, glyphiconSpanTag, tooltip);
        }

        public static HtmlTag ModifyActionAnchorButtonHtmlTag(this HtmlHelper helper, string href)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconPencilSpanTag();
            return helper.AnchorButtonHtmlTag(href, glyphiconSpanTag, "Modifier");
        }

        public static HtmlTag RemoveActionAnchorButtonHtmlTag(this HtmlHelper helper, string href)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconTrashSpanTag();
            return helper.AnchorButtonHtmlTag(href, glyphiconSpanTag, "Supprimer");
        }

        public static HtmlTag CancelActionAnchorButtonHtmlTag(this HtmlHelper helper, string href)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconBanCircleSpanTag();
            return helper.AnchorButtonHtmlTag(href, glyphiconSpanTag, "Annuler");
        }

        public static HtmlTag BackActionAnchorButtonHtmlTag(this HtmlHelper helper, string href, string text)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconEjectSpanTag();
            return helper.AnchorButtonHtmlTag(href, glyphiconSpanTag, text);
        }

        public static HtmlTag BackActionAnchorButtonHtmlTag(this HtmlHelper helper, string href)
        {
            return helper.BackActionAnchorButtonHtmlTag(href, "Retour");
        }

        public static HtmlTag AddActionSubmitButtonHtmlTag(this HtmlHelper helper)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconPlusSpanTag();
            return helper.ButtonHtmlTag(glyphiconSpanTag, "Ajouter").SetTypeAttribute("submit");
        }

        public static HtmlTag AddActionAnchorButtonHtmlTag(this HtmlHelper helper, string href)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconPlusSpanTag();
            return helper.AnchorButtonHtmlTag(href, glyphiconSpanTag, "Ajouter");
        }
    }
}