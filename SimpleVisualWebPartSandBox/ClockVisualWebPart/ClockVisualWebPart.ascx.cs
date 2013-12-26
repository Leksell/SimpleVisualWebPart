using Microsoft.SharePoint;
using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;

namespace SimpleVisualWebPartSandBox.ClockVisualWebPart
{
    [ToolboxItemAttribute(false)]
    public partial class ClockVisualWebPart : WebPart
    {
     
        public ClockVisualWebPart()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

// If you have another name on your project and web part, then copy only the things under here and replace what you have under the base.OnInit above here.

        // Adding the Scripts/style links
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            writer.Write(BindScript("/Style Library/ClockVisualWebPart/Scripts/jquery-1.10.2.min.js", true));
            writer.Write(BindScript("/Style Library/ClockVisualWebPart/Scripts/ClockVWP.js", true));
            writer.Write(BindStyle("/Style Library/ClockVisualWebPart/Styles/ClockVWP.css", true));
            base.Render(writer);
        }
        // Loading the scripts
        private string BindScript(string ScriptUrl, bool PickFromSiteCollection)
        {
            if (PickFromSiteCollection)
                ScriptUrl = Microsoft.SharePoint.Utilities.SPUrlUtility.CombineUrl(SPContext.Current.Site.RootWeb.Url, ScriptUrl);
            else
                ScriptUrl = Microsoft.SharePoint.Utilities.SPUrlUtility.CombineUrl(SPContext.Current.Web.Url, ScriptUrl);

            return string.Format(@"<script type=""text/javascript"" src=""{0}""></script>", ScriptUrl);

        }

        // Load the style
        private string BindStyle(string StyleUrl, bool PickFromSiteCollection)
        {
            if (PickFromSiteCollection)
                StyleUrl = Microsoft.SharePoint.Utilities.SPUrlUtility.CombineUrl(SPContext.Current.Site.RootWeb.Url, StyleUrl);
            else
                StyleUrl = Microsoft.SharePoint.Utilities.SPUrlUtility.CombineUrl(SPContext.Current.Web.Url, StyleUrl);

            return string.Format(@"<link rel=""stylesheet"" href=""{0}"" type=""text/css"" />", StyleUrl);
        }


        //Clock background color settings

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        private string _ClockBackgroundColor;

        [Personalizable(PersonalizationScope.Shared), WebBrowsable(true),
        WebDisplayName("Clock background color should use HEX (#999999)"),
        WebDescription("Choose your background color (#999999)")]
        public string ClockBackgroundColor
        {
            get
            {
                return _ClockBackgroundColor;
            }
            set
            {
                _ClockBackgroundColor = value;
            }
        }

        //Clock text color settings

        private string _ClockTextColor;

        [Personalizable(PersonalizationScope.Shared), WebBrowsable(true),
        WebDisplayName("Clock text color should use HEX (#ffffff)"),
        WebDescription("Choose your text color (#ffffff)")]
        public string ClockTextColor
        {
            get
            {
                return _ClockTextColor;
            }
            set
            {
                _ClockTextColor = value;
            }
        }
    }
}

