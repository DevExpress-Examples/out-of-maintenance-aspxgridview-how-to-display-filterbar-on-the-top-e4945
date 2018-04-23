using DevExpress.Web.ASPxEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void ASPxGridView1_CustomFilterExpressionDisplayText(object sender, DevExpress.Web.ASPxEditors.CustomFilterExpressionDisplayTextEventArgs e) {
        ASPxLabel lbl = ASPxGridView1.FindTitleTemplateControl("ASPxLabel1") as ASPxLabel;
        lbl.Text = e.DisplayText;

        Control c = lbl.Parent;

        if (e.DisplayText != String.Empty) {
            c.Controls.AddAt(1, new LiteralControl("<a style=\"font-size:small\" href=\"#\" onclick=\"grid.ApplyFilter();\">Clear</a>&nbsp::&nbsp"));
        } else {
            c.Controls.RemoveAt(1);
        }
    }
}