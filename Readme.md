# ASPxGridView - How to display FilterBar on the top


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


