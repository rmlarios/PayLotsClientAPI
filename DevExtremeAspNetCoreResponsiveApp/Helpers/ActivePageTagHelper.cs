using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DevExtremeAspNetCoreResponsiveApp.Helpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement(Attributes = "is-active-page")]
    public class ActivePageTagHelper : TagHelper
    {
        [HtmlAttributeName("href")]
        public string Page { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.AspNetCore.Mvc.Rendering.ViewContext" /> for the current request.
        /// </summary>
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
            output.Attributes.SetAttribute("href", Page);
            if (ShouldBeActive())
            {
                MakeActive(output);
            }

            output.Attributes.RemoveAll("is-active-page");
        }

        private bool ShouldBeActive()
        {
            string currentPage = ViewContext.RouteData.Values["Page"].ToString();
            if (Page == null)
                return false;

            if (!string.IsNullOrWhiteSpace(Page) && Page.ToLower() != currentPage.ToLower())
            {
                return false;
            }

            return true;
        }

        private void MakeActive(TagHelperOutput output)
        {
            var classAttr = output.Attributes.FirstOrDefault(a => a.Name == "class");
            if (classAttr == null)
            {
                classAttr = new TagHelperAttribute("class", "activemenu");
                output.Attributes.Add(classAttr);
            }
            else if (classAttr.Value == null || classAttr.Value.ToString().IndexOf("activemenu") < 0)
            {
                output.Attributes.SetAttribute("class", classAttr.Value == null
                    ? " activemenu"
                    : classAttr.Value.ToString() + " activemenu");
            }
        }
    }
}
