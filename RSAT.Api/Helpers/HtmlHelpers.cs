using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RSAT.Api.Helpers
{
    /// <summary>
    /// Inspinia admin template http://webapplayers.com/inspinia_admin-v2.7.1/
    /// </summary>
    public static class HtmlHelpers
    {
        public static string IsSelected(this IHtmlHelper html, string controller = null, string action = null, string cssClass = null)
        {
            if (String.IsNullOrEmpty(cssClass))
                cssClass = "active";

            string currentAction = (string)html.ViewContext.RouteData.Values["action"];
            string currentController = (string)html.ViewContext.RouteData.Values["controller"];

            //To lower case
            controller = controller == null ? null : controller.ToLower();
            action = action == null ? null : action.ToLower();
            currentController = currentController == null ? null : currentController.ToLower();
            currentAction = currentAction == null ? null : currentAction.ToLower();

            if (String.IsNullOrEmpty(controller))
                controller = currentController;

            if (String.IsNullOrEmpty(action))
                action = currentAction;

            return controller == currentController && action == currentAction ?
                cssClass : String.Empty;
        }

        public static string PageClass(this IHtmlHelper htmlHelper)
        {
            string currentAction = (string)htmlHelper.ViewContext.RouteData.Values["action"];
            return currentAction;
        }
    }
}