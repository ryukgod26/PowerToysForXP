using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;


    public class KeyboarrdHook
    {
    private const int WH_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 0x0101;
    private const int WM_KEYUP = 0x0104;
    private const int WM_SYSKEYUP = 0x0105;

    //delegate for hook callback
    private delegate IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam);

    //private static HookCallback _proc = HookCallbackMethod;


    //private static IntPtr HookCallbackMethod(int nCode, IntPtr wParam, IntPtr lParam)
    //{

    //}

}

