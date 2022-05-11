using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Lab04_Nhom1_19521982
{
    public partial class Bai4_Lab04 : Form
    {
        public Bai4_Lab04()
        {
            InitializeComponent();
        }

        private void WebBrower_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webBrowser.DocumentTitle;
        }

        private void WebTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webTab.DocumentTitle;
        }

        private void btnNewtab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("http://www.google.com");
            tbUrl.Text = "http://www.google.com";
            webTab.DocumentCompleted += WebTab_DocumentCompleted;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Bai4_Lab4_Download form = new Bai4_Lab4_Download();
            form.MyProperty = tbUrl.Text;
            form.Show();
        }

        private void btnViewcode_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Bai4_Lab4_ViewCode form = new Bai4_Lab4_ViewCode();
            form.MyProperty = client.DownloadString(tbUrl.Text);
            form.Show();
        }
        WebBrowser webTab = null;
        private void btnGo_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                web.Navigate(tbUrl.Text);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            Bai4_Lab4_Download form = new Bai4_Lab4_Download();
            form.MyProperty = tbUrl.Text;
            form.Show();
        }

        private void Bai4_Lab4_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("http://www.google.com");
            tbUrl.Text = "http://www.google.com";
            webBrowser.DocumentCompleted += WebBrower_DocumentCompleted;
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void URLtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    web.Navigate(tbUrl.Text);
                }
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                {
                    web.GoForward();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoBack)
                {
                    web.GoBack();
                }
            }
        }
    }
}
