using EasyTabs;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bunifu_Browser
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();

            //Upgrade the default web browser
            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                Key.SetValue(appName, 99999, RegistryValueKind.DWord);

            //open google .com
            webBrowser1.Navigate("https://www.google.com/");
        
        }

        // 2. Important: Declare ParentTabs
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            btnRefresh.Image = imgRefresh.Image;
            txtSerachOrUrl.Text = webBrowser1.Url.AbsoluteUri;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack) webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward) webBrowser1.GoForward();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            btnRefresh.Image = imgSpinner.Image;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            btnRefresh.Image = imgRefresh.Image;
        }

        private void txtSerachOrUrl_KeyUp(object sender, KeyEventArgs e)
        {
           if(e.KeyCode==Keys.Enter && txtSerachOrUrl.Text.Trim().Length > 0)
            {
                //detect url
                if(txtSerachOrUrl.Text.Contains("."))
                {
                    //ites a url
                    webBrowser1.Navigate(txtSerachOrUrl.Text.Trim());

                }
                else
                {
                    //its a search
                    webBrowser1.Navigate("https://www.google.com/search?client=opera&q="+txtSerachOrUrl.Text.Trim().Replace(" ","+")+"&sourceid=opera&ie=UTF-8&oe=UTF-8");
                }
            }
        }
    }
}
