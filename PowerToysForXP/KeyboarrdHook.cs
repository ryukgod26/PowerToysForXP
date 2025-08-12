using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Input;


public class KeyboarrdHook
    {
    private const int WH_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 0x0101;
    private const int WM_KEYUP = 0x0104;
    private const int WM_SYSKEYDOWN = 0x0104;
    private const int WM_SYSKEYUP = 0x0105;

    //delegate for hook callback
    private delegate IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam);

    private static HookCallback _proc = HookCallbackMethod;

    private static IntPtr _hookID = IntPtr.Zero;
    private static Keys from;
    private static Keys to;

    public static void Start(Keys fromInput, Keys toInput)
    {
        from = fromInput;
        to = toInput;
        _hookID = SetHook(_proc);
    }

    public static void Stop()
    {
        UnhookWindowsHookEx(_hookID);
    }

    private static IntPtr SetHook(HookCallback proc)
    {
        //Get the current Process
        using (Process curProcess = Process.GetCurrentProcess()) 
        //Get the main module of current process
        using (ProcessModule curModule = curProcess.MainModule)
        {
            return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName),0);
        }
    }

    private static IntPtr HookCallbackMethod(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if(nCode >= 0)
        {
            int vkCode = Marshal.ReadInt32(lParam);
            Keys key = (Keys)vkCode;

            //Reamping the keys (a Single Key)
            if(key == from)
            {
                //Checking if from is pressed down or up
                if(wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_SYSKEYDOWN )
                {
                    //Simulating to Key down
                    keybd_event((byte)to, 0, 0, 0);

                }
                else if(wParam == (IntPtr)WM_KEYUP || wParam == (IntPtr)WM_SYSKEYUP)
                {
                    //Simulating to Key up
                    keybd_event((byte)to, 0, 2, 0);
                }
                //By returning 1 We nullify the original Key from Press
                return (IntPtr)1;
            }
        }

        //Pass the event to the next hook in the chain
        return CallNextHookEx(_hookID, nCode, wParam, lParam);

    }

    //P/Invoke Declarations
    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook, HookCallback lpfn, IntPtr hMod, uint dwThreadid);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    //For Simulating Key Presses
    [DllImport("user32.dll")]
    static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);


}

