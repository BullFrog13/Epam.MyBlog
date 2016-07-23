using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Lesson2.Helpers
{
    public static class ListHelper
    {
        public static MvcHtmlString CreateList(this HtmlHelper html, string [] items)
        {
            TagBuilder ul = new TagBuilder("ul");
            ul.AddCssClass("nav-stacked");
            ul.AddCssClass("nav-pills");
            ul.AddCssClass("nav");
            for(int i = 0; i < items.Length; i++)
            {
                TagBuilder li = new TagBuilder("li");
                TagBuilder refer = new TagBuilder("a");
                if (i == 0)
                {
                    li.AddCssClass("active");
                    refer.MergeAttribute("href", "/Home/Index");
                }
                if (i == 1)
                {
                    refer.MergeAttribute("href", "/Home/HomePage");
                }
                if (i == 2)
                {
                    refer.MergeAttribute("href", "/Home/GuestPage");
                }
                if (i == 3)
                {
                    refer.MergeAttribute("href", "#section" + (i + 1));
                }
                refer.SetInnerText(items[i]);
                li.InnerHtml += refer.ToString();
                ul.InnerHtml += li.ToString();
            }
            return new MvcHtmlString(ul.ToString());
        }
    }
}