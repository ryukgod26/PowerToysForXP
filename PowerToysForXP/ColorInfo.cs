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
    public partial class ColorInfo : Form
    {
        public ColorInfo()
        {
            InitializeComponent();
        }

        public void SetColor(Color color)
        {
            //Setting the background Color of the Color watch panel
            colorWatchPanel.BackColor = color;

            //Displaying the Color Codes
            colorHexCode.Text = $"#{color.R:X2}";
            colorRgbCode.Text = $"RGB({color.R},{color.G},{color.B})";
            colorName.Text = color.Name;

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void colorName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(colorName.Text);
        }

        private void colorRgbCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(colorRgbCode.Text);
        }

        private void colorHexCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(colorHexCode.Text);
        }
    }
}
