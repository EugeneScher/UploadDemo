using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace applicationBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            buttonStop.Enabled = false;
        }

        private void textBoxAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) webBrowser.Navigate(textBoxAdress.Text);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string url = textBoxAdress.Text;
            if (!url.StartsWith("http://") && !url.StartsWith("https://")) url = "http://" + url;
            webBrowser.Navigate(new Uri(url));
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(new Uri("http://google.com"));
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            buttonStop.Enabled = true;
        }
    }
}
