using System;
using System.Windows.Forms;

namespace SpaContentExtractorUsingWebView2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate(textBox1.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webView21.Height = ((Control)sender).Height / 2;
        }

        private void webView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            btnGetTrends.Enabled = e.IsSuccess && webView21.CoreWebView2.Source.StartsWith("https://trends.google.com");
        }

        private async void btnGetTrends_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;

            var html = await webView21.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML");

            var htmlDecoded = System.Text.Json.JsonSerializer.Deserialize<string>(html);

            var regex = new System.Text.RegularExpressions.Regex("<div bidi=\"value\" dir=\"ltr\"><span ng-bind=\"bidiText\">((.)*)</span></div>");
            var matches = regex.Matches(htmlDecoded);

            lstTrends.Items.Clear();
            foreach (System.Text.RegularExpressions.Match m in matches)
            {
                lstTrends.Items.Add(m.Groups[1].Value);
            }

            Application.UseWaitCursor = false;
        }
    }
}
