<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClockVisualWebPart.ascx.cs" Inherits="SimpleVisualWebPart.ClockVisualWebPart.ClockVisualWebPart" %>


<%--Here we add the tow scripts that we use and also the css for the web part.--%>
<SharePoint:CssRegistration ID="CssRegistration1" Name="/_layouts/15/SimpleVisualWebPart/Styles/ClockVWP.css" runat="server" After="corev15.css" />
<sharepoint:scriptlink ID="Scriptlink2" runat="server" name="~SiteCollection/_layouts/15/SimpleVisualWebPart/Scripts/jquery-1.10.2.min.js" > </sharepoint:scriptlink>
<sharepoint:scriptlink ID="Scriptlink1" runat="server" name="~SiteCollection/_layouts/15/SimpleVisualWebPart/Scripts/ClockVWP.js" > </sharepoint:scriptlink>

<%--Inline style coming here!--%>
<style>
    .clock { color:<%=ClockTextColor%>; background-color:<%=ClockBackgroundColor%>; } <%--As you can see here we call the settings and ask for the color.--%>
</style>

<%--Here starts the HTML that we use to show the clock.--%>
<div class="clock">
<div id="Date"></div>
  <ul>
      <li id="hours"></li>
      <li id="point">:</li>
      <li id="min"></li>
      <li id="Li1">:</li>
      <li id="sec"></li>
  </ul>
</div>