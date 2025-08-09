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
    public partial class Sidebar : Form
    {
        bool sidebarExpand;
        public Sidebar()
        {
            InitializeComponent();
        }
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    // Check for our custom "Advanced Paste" shortcut: Ctrl + Shift + V
        //    if (keyData == (Keys.Control | Keys.Shift | Keys.V))
        //    {
        //        // Check if the active control is our RichTextBox
        //        if (this.ActiveControl == richTextBox1)
        //        {
        //            ShowAdvancedPasteMenu();
        //            return true; // We've handled the key press
        //        }
        //    }

        //    // Allow other key combinations to be processed as usual
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        // Event handler for "Paste as JSON"
        //private void PasteAsJson_Click(object sender, EventArgs e)
        //{
        //    if (!Clipboard.ContainsText()) return;

        //    string clipboardText = Clipboard.GetText();
        //    try
        //    {
        //        // Parse the JSON string
        //        using var jsonDoc = System.Text.Json.JsonDocument.Parse(clipboardText);

        //        // Re-serialize it with formatting (indentation)
        //        var options = new System.Text.Json.JsonSerializerOptions { WriteIndented = true };
        //        string formattedJson = System.Text.Json.JsonSerializer.Serialize(jsonDoc.RootElement, options);

        //        richTextBox1.SelectedText = formattedJson;
        //    }
        //    catch (System.Text.Json.JsonException)
        //    {
        //        // If text is not valid JSON, just paste it as plain text
        //        MessageBox.Show("Clipboard content is not valid JSON. Pasting as plain text.", "Paste Error");
        //        richTextBox1.SelectedText = clipboardText;
        //    }
        //}

        // Event handler for "Paste as Markdown"
        //private void PasteAsMarkdown_Click(object sender, EventArgs e)
        //{
        //    // The clipboard can contain multiple formats for the same content.
        //    // We check for HTML format first.
        //    if (Clipboard.ContainsData(DataFormats.Html))
        //    {
        //        string htmlContent = Clipboard.GetData(DataFormats.Html).ToString();

        //        // The HTML on the clipboard has a header; we don't need it.
        //        // A simple way to get just the body fragment:
        //        int start = htmlContent.IndexOf("<html", StringComparison.OrdinalIgnoreCase);
        //        if (start > 0)
        //        {
        //            htmlContent = htmlContent.Substring(start);
        //        }

        //        var converter = new ReverseMarkdown.Converter();
        //        string markdown = converter.Convert(htmlContent);
        //        richTextBox1.SelectedText = markdown;
        //    }
        //    else if (Clipboard.ContainsText())
        //    {
        //        // If no HTML, inform user and paste as plain text.
        //        MessageBox.Show("No HTML content found on clipboard. Pasting as plain text.", "Paste Info");
        //        richTextBox1.SelectedText = Clipboard.GetText();
        //    }
        //}

        // Event handler for "Paste as Plain Text"
        //private void PastePlainText_Click(object sender, EventArgs e)
        //{
        //    if (Clipboard.ContainsText())
        //    {
        //        // GetText() automatically returns plain text
        //        richTextBox1.SelectedText = Clipboard.GetText();
        //    }
        //}



        //private void InitializeAdvancedPasteMenu()
        //{
        //    advancedPasteMenu = new ContextMenuStrip();

        //    // Option 1: Paste as Plain Text
        //    var pastePlainTextItem = new ToolStripMenuItem("Paste as Plain Text");
        //    pastePlainTextItem.Click += PastePlainText_Click;
        //    advancedPasteMenu.Items.Add(pastePlainTextItem);

        //    //// Option 2: Paste as JSON (formatted)
        //    //var pasteJsonItem = new ToolStripMenuItem("Paste as JSON (formatted)");
        //    //pasteJsonItem.Click += PasteAsJson_Click;
        //    //advancedPasteMenu.Items.Add(pasteJsonItem);

        //    //// Option 3: Paste from HTML to Markdown
        //    //var pasteMarkdownItem = new ToolStripMenuItem("Paste from HTML to Markdown");
        //    //pasteMarkdownItem.Click += PasteAsMarkdown_Click;
        //    //advancedPasteMenu.Items.Add(pasteMarkdownItem);
        //}


        //private void ShowAdvancedPasteMenu()
        //{
        //    // Show the menu at the current cursor position in the RichTextBox
        //    Point cursorPosition = richTextBox1.GetPositionFromCharIndex(richTextBox1.SelectionStart);
        //    advancedPasteMenu.Show(richTextBox1, cursorPosition);
        //}
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            // Set the minimum and maximum size of sidebar Panel
            if (sidebarExpand)
            {
                //if sidebar is expand, minisize
                sidebarContainer.Width -= 10;
                if(sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if(sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sidebar_Load(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            aboutPanel.Visible = false;
            helpPanel.Visible = false;
            settingPanel.Visible = false;
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            aboutPanel.Visible = false;
            helpPanel.Visible = false;
            settingPanel.Visible = false;
            Console.WriteLine("home");
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            aboutPanel.Visible = true;
            helpPanel.Visible = false;
            settingPanel.Visible = false;
            Console.WriteLine("About");

        }

        private void helpbtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            helpPanel.Visible = true;
            aboutPanel.Visible = false;
            settingPanel.Visible = false;
            Console.WriteLine("Help");

        }

        private void settingbtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            settingPanel.Visible = true;
            aboutPanel.Visible = false;
            helpPanel.Visible = false;
            Console.WriteLine("setting");

        }
    }
}
