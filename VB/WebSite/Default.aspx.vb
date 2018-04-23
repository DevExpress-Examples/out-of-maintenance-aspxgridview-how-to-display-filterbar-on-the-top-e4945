Imports Microsoft.VisualBasic
Imports DevExpress.Web.ASPxEditors
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub ASPxGridView1_CustomFilterExpressionDisplayText(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxEditors.CustomFilterExpressionDisplayTextEventArgs)
		Dim lbl As ASPxLabel = TryCast(ASPxGridView1.FindTitleTemplateControl("ASPxLabel1"), ASPxLabel)
		lbl.Text = e.DisplayText

		Dim c As Control = lbl.Parent

		If e.DisplayText <> String.Empty Then
			c.Controls.AddAt(1, New LiteralControl("<a style=""font-size:small"" href=""#"" onclick=""grid.ApplyFilter();"">Clear</a>&nbsp::&nbsp"))
		Else
			c.Controls.RemoveAt(1)
		End If
	End Sub
End Class