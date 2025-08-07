using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PowerToysForXP
{
    public partial class webBrowser : Form
    {
        public webBrowser()
        {
            InitializeComponent();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void navigatebtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(url.Text);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {

                webBrowser1.GoBack();
            }

        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }
    }
}
