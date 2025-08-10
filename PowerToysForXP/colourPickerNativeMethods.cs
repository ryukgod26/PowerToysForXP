using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace PowerToysForXP
{
    public static class colourPickerNativeMethods
    {
        //To get the mouse Position for clour Picker Tool
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(out Point lpPoint);

        //For getting the color of the pixel
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);


        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);



        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        //To hold the coordinated x and y
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
        }

    }
}
