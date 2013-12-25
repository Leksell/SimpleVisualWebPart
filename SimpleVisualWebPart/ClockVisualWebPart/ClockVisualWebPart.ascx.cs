using Microsoft.SharePoint;
using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;

namespace SimpleVisualWebPart.ClockVisualWebPart
{
    [ToolboxItemAttribute(false)]
    public partial class ClockVisualWebPart : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public ClockVisualWebPart()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

// If you have another name on your project and web part, then copy only the things under here and replace what you have under the base.OnInit above here.

        //Countdown settings

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

        //Countdown settings

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


