using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Windows.Controls;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PowerToysForXP
{
    public partial class Home : Form
    {
        // I have learned these declarations from ai. Ai Lhelped me learn but the code is written by me afetr fully understaing the concept.
        [DllImport("user32.dll")] private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        //vk = virtual key code , fsModifiers is for special keys like ctrl,alt or windows key
        [DllImport("user32.dll")] private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        


        //Constants for hotkeys
        private const uint MOD_NONE = 0x0000; //(none)
        private const uint MOD_ALT = 0x0001; //ALT KEY
        private const uint MOD_CTRL = 0x0002; //CTRL KEY
        private const uint MOD_SHIFT = 0x0004; //SHIFT KEY 
        private const uint MOD_WINDOWS = 0X0008; //WINDOWS KEY

        //Unique id for my hotkey.
        private const int COLOUR_PICKER_HOTKEY_ID = 26;


        //booleans for color picker
        bool unregisteredColorPicker;

        //boolean for sidebar
        bool sidebarExpand;
        public Home()
        {
            
            InitializeComponent();
            
        }


        private void RegisterColorPickerKey()
        {
            //Registring the hotkey
            //Modifier keys
            uint modifiers = MOD_CTRL | MOD_SHIFT; //Control + Shift Key
            Keys key = Keys.C; //C key for color picker tool
            bool result = RegisterHotKey(this.Handle, COLOUR_PICKER_HOTKEY_ID, modifiers, (uint)key);
            if (result)
            {
                Console.WriteLine("Colour Picker Hotkey has been Registered Successfully.");
            }
            else
            {
                Console.WriteLine("Error while Registering Colour Picker Hotkey.");
            }
        }
        private void Home_Load(object sender, EventArgs e)
        {
            RegisterColorPickerKey();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void homeSPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        protected override void WndProc(ref Message m)
        {
            //It represents a Windows message that the operating system sends to a window when a registered hotkey is pressed.
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY)
            {
                //checking if the hotkey pressed is colour pickey hotkey
                if (m.WParam.ToInt32() == COLOUR_PICKER_HOTKEY_ID)
                {
                    Console.WriteLine("Colour Picker Hotkey is Pressed");
                    CaptureAndShowColor();
                }
            }
            //This is very Important Line.
            //It took me 30 minutes to solve the error and then I got to know I just neede this line
            base.WndProc(ref m);
        }

        private void CaptureAndShowColor()
        {
            //Getting the Mouse Position
            Point cursorPoint;
            colourPickerNativeMethods.GetCursorPos(out cursorPoint);

            //Getting the color of Pixel at that Position
            IntPtr screenDC = colourPickerNativeMethods.GetDC(IntPtr.Zero);
            uint colorRef = colourPickerNativeMethods.GetPixel(screenDC, cursorPoint.X, cursorPoint.Y);
            // I learned this from ai
            colourPickerNativeMethods.ReleaseDC(IntPtr.Zero, screenDC);

            Color pixelColor = Color.FromArgb(
               (int)(colorRef & 0x000000FF),//Red
               (int)(colorRef & 0x0000FF00) >> 8, //Green
               (int)(colorRef & 0x00FF0000) >> 16 //Blue
               );
            //Showing the UI
            using (ColorInfo infoForm = new ColorInfo())
            {
                //SetColor is a custom method in ColorInfo
                infoForm.SetColor(pixelColor);
                infoForm.ShowDialog();
            }
        }
        private void homebtn_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //if sidebar is expand, minisize
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (browserWindow.CanGoBack)
            {
                browserWindow.GoBack();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            browserWindow.Refresh();
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if (browserWindow.CanGoForward)
            {
                browserWindow.GoForward();
            }
        }

        private void browserPanelView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navigatebtn_Click(object sender, EventArgs e)
        {
            browserWindow.Navigate(url.Text);
        }

        private void sidebarContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void url_Enter(object sender, EventArgs e)
        {
            browserWindow.Navigate(url.Text);
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!unregisteredColorPicker)
            {
                //unregistering Colour Picker Hotkey
                UnregisterHotKey(this.Handle, COLOUR_PICKER_HOTKEY_ID);
            }
        }
        private void unRegisterColorPicker()
        {
            UnregisterHotKey(this.Handle, COLOUR_PICKER_HOTKEY_ID);
        }

        private void colorpickerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (colorpickerCheckBox.Checked)
            {
                RegisterColorPickerKey();
                unregisteredColorPicker = false;
            }
            else
            {
                unRegisterColorPicker();
                unregisteredColorPicker = true;
            }
        }
    }
}
