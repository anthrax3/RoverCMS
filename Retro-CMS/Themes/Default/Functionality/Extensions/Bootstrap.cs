using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Default.Functionality.Extensions
{
    public static class Bootstrap
    {
        public static MvcHtmlString BootstrapTextBoxFor<TModel, TProperty> (this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression )
        {
            return htmlHelper.TextBoxFor(expression, new {@class = "form-control"});
        }

        public static MvcHtmlString BootstrapPasswordFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            return htmlHelper.PasswordFor(expression, new { @class = "form-control" });
        }

        public static MvcHtmlString BootstrapTextBox(this HtmlHelper htmlHelper, string name)
        {
            return htmlHelper.TextBox(name, null, new { @class = "form-control" });
        }

        public static MvcHtmlString BootstrapLabelFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            return htmlHelper.LabelFor(expression, null, new { @class = "control-label" });
        }

        public static MvcHtmlString BootstrapLabel<TModel>(this HtmlHelper<TModel> htmlHelper, string expression)
        {
            return htmlHelper.Label(expression, new { @class = "control-label" });
        }
        public static IHtmlString BootstrapDescription(this HtmlHelper htmlHelper, string expression)
        {
            return htmlHelper.Raw(string.Format("<small>{0}</small>", expression));
        }
    }
}
