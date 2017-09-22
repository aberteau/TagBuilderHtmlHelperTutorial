using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        public static HtmlTag AnchorButtonHtmlTag(this HtmlHelper helper, string href, HtmlTag iconTag, String text, ContentDisplayMode contentDisplayMode)
        {
            HtmlTag tag = helper.AnchorButtonHtmlTag(href);
            tag.SetInnerHtml(iconTag, text, contentDisplayMode);
            return tag;
        }

        public static HtmlTag ActionButtonHtmlTag(this HtmlHelper helper, HtmlTag iconTag, String text, ContentDisplayMode contentDisplayMode)
        {
            HtmlTag tag = helper.ButtonHtmlTag();
            tag.SetInnerHtml(iconTag, text, contentDisplayMode);
            return tag;
        }

        public static HtmlTag ListActionAnchorButtonHtmlTag(this HtmlHelper helper, string href, string text)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconListSpanTag();
            return helper.AnchorButtonHtmlTag(href, glyphiconSpanTag, text, ContentDisplayMode.IconAndText);
        }

        public static HtmlTag ModifyActionAnchorButtonHtmlTag(this HtmlHelper helper, string href, ContentDisplayMode contentDisplayMode = ContentDisplayMode.IconAndText)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconPencilSpanTag();
            return helper.AnchorButtonHtmlTag(href, glyphiconSpanTag, "Modifier", contentDisplayMode);
        }

        public static HtmlTag RemoveActionAnchorButtonHtmlTag(this HtmlHelper helper, string href, ContentDisplayMode contentDisplayMode)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconTrashSpanTag();
            return helper.AnchorButtonHtmlTag(href, glyphiconSpanTag, "Supprimer", contentDisplayMode);
        }

        public static HtmlTag CancelActionAnchorButtonHtmlTag(this HtmlHelper helper, string href, ContentDisplayMode contentDisplayMode)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconBanCircleSpanTag();
            return helper.AnchorButtonHtmlTag(href, glyphiconSpanTag, "Annuler", contentDisplayMode);
        }

        public static HtmlTag BackActionAnchorButtonHtmlTag(this HtmlHelper helper, string href, string text, ContentDisplayMode contentDisplayMode)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconEjectSpanTag();
            return helper.AnchorButtonHtmlTag(href, glyphiconSpanTag, text, contentDisplayMode);
        }

        public static HtmlTag BackActionAnchorButtonHtmlTag(this HtmlHelper helper, string href, ContentDisplayMode contentDisplayMode)
        {
            return helper.BackActionAnchorButtonHtmlTag(href, "Retour", contentDisplayMode);
        }

        public static HtmlTag SaveActionSubmitButtonHtmlTag(this HtmlHelper helper, ContentDisplayMode contentDisplayMode)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconOkCircleSpanTag();
            return helper.ActionButtonHtmlTag(glyphiconSpanTag, "Enregistrer", contentDisplayMode).SetTypeAttribute("submit");
        }

        public static HtmlTag AddActionSubmitButtonHtmlTag(this HtmlHelper helper, ContentDisplayMode contentDisplayMode)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconPlusSpanTag();
            return helper.ActionButtonHtmlTag(glyphiconSpanTag, "Ajouter", contentDisplayMode).SetTypeAttribute("submit");
        }

        public static HtmlTag AddActionAnchorButtonHtmlTag(this HtmlHelper helper, string href, ContentDisplayMode contentDisplayMode = ContentDisplayMode.IconAndText)
        {
            HtmlTag glyphiconSpanTag = helper.GlyphiconPlusSpanTag();
            return helper.AnchorButtonHtmlTag(href, glyphiconSpanTag, "Ajouter", contentDisplayMode);
        }
    }
}