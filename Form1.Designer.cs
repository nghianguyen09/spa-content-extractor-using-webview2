
namespace SpaContentExtractorUsingWebView2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lstTrends = new System.Windows.Forms.ListBox();
            this.btnGetTrends = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.BackColor = System.Drawing.SystemColors.Window;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webView21.Location = new System.Drawing.Point(0, 64);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1392, 386);
            this.webView21.Source = new System.Uri("https://www.microsoft.com", System.UriKind.Absolute);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            this.webView21.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView21_NavigationCompleted);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(876, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "https://trends.google.com/trends/yis/2020/US/";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(936, 10);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(112, 34);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lstTrends
            // 
            this.lstTrends.FormattingEnabled = true;
            this.lstTrends.ItemHeight = 25;
            this.lstTrends.Location = new System.Drawing.Point(12, 64);
            this.lstTrends.Name = "lstTrends";
            this.lstTrends.Size = new System.Drawing.Size(876, 154);
            this.lstTrends.TabIndex = 3;
            // 
            // btnGetTrends
            // 
            this.btnGetTrends.Enabled = false;
            this.btnGetTrends.Location = new System.Drawing.Point(936, 64);
            this.btnGetTrends.Name = "btnGetTrends";
            this.btnGetTrends.Size = new System.Drawing.Size(112, 34);
            this.btnGetTrends.TabIndex = 4;
            this.btnGetTrends.Text = "Get Trends";
            this.btnGetTrends.UseVisualStyleBackColor = true;
            this.btnGetTrends.Click += new System.EventHandler(this.btnGetTrends_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 450);
            this.Controls.Add(this.btnGetTrends);
            this.Controls.Add(this.lstTrends);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webView21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListBox lstTrends;
        private System.Windows.Forms.Button btnGetTrends;
    }
}

