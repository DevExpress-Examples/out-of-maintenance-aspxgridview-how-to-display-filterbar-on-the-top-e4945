<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128533882/13.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4945)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - How to display FilterBar on the top
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4945/)**
<!-- run online end -->


<p>ASPxGridView currently does not support this to be done natively. But we can emulate a custom FilterBar in the TitleTemplate.</p><p>First we need to display the default FilterBar and Title Panel with this markup tag:</p>

```aspx
<Settings ShowFilterBar="Visible" ShowTitlePanel="True" />
```

<p> </p><p>Then we will add the following css style to the page to hide the FilterBar:</p>

```css
        #ASPxGridView1_DXFilterBar {
            display: none;
        } 

```

<p> We need it to be rendered to handle the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_CustomFilterExpressionDisplayTexttopic"><u>CustomFilterExpressionDisplayText</u></a> event. In this event handler we will set the text of the ASPxLabel, contained in the TitleTemplate.</p><br />
<p>Additionally we can add a link, which will show the default visual expression editor to this template:</p>

```aspx
<a style="font-size: small" href="#" onclick="grid.ShowFilterControl();">Edit</a>
```

<p> </p><p>Also we can implement a custom "Clear" button, which will hide/display automatically.</p>

<br/>


