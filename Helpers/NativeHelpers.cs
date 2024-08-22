using System;
using System.Runtime.InteropServices;

namespace JMWToolkit.MVVM.Helpers;

/// <summary>
/// A set of Win32 helpers
/// </summary>
internal static partial class NativeHelpers
{
    /// <summary>
    /// Retrieves the current double-click time for the mouse.
    /// </summary>
    /// <returns>he return value specifies the current double-click time, in milliseconds. The maximum return value is 5000 milliseconds.</returns>
    [LibraryImport("user32.dll")]
    internal static partial uint GetDoubleClickTime();

    [StructLayout(LayoutKind.Sequential)]
    internal struct Rect
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    [LibraryImport("user32.dll", EntryPoint = "GetWindowRect")]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static partial bool GetWindowRect(IntPtr hMonitor, ref Rect windowRect);


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    internal struct MonitorInfo
    {
        public MonitorInfo() { }
        public int SizeInBytes = Marshal.SizeOf(typeof(NativeHelpers.MonitorInfo));
        public Rect MonitorRect;
        public Rect WorkRect;
        public int Flags;
    }

    [DllImport("user32.dll")]
    internal static extern Int32 GetMonitorInfo(IntPtr hMonitor, out MonitorInfo monitorInfo);

    internal static UInt32 MONITOR_DEFAULTTONULL    = 0x00000000;
    internal static UInt32 MONITOR_DEFAULTTOPRIMARY = 0x00000001;
    internal static UInt32 MONITOR_DEFAULTTONEAREST = 0x00000002;

    [LibraryImport("user32.dll", EntryPoint = "MonitorFromWindow")]
    internal static partial IntPtr MonitorFromWindow(IntPtr hWnd, UInt32 dwFlags);

    internal static UInt32 SWP_NOSIZE         = 0x0001;
    internal static UInt32 SWP_NOMOVE         = 0x0002;
    internal static UInt32 SWP_NOZORDER       = 0x0004;
    internal static UInt32 SWP_NOREDRAW       = 0x0008;
    internal static UInt32 SWP_NOACTIVATE     = 0x0010;
    internal static UInt32 SWP_FRAMECHANGED   = 0x0020; /* The frame changed: send WM_NCCALCSIZE */
    internal static UInt32 SWP_SHOWWINDOW     = 0x0040;
    internal static UInt32 SWP_HIDEWINDOW     = 0x0080;
    internal static UInt32 SWP_NOCOPYBITS     = 0x0100;
    internal static UInt32 SWP_NOOWNERZORDER  = 0x0200; /* Don't do owner Z ordering */
    internal static UInt32 SWP_NOSENDCHANGING = 0x0400; /* Don't send WM_WINDOWPOSCHANGING */

    [DllImport("user32.dll", SetLastError = true)]
    internal static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, UInt32 uFlags);

    internal static bool SetWindowPos(IntPtr hWnd, Rect newRect, UInt32 uFlags = 0x0)
    {
        return SetWindowPos(hWnd, IntPtr.Zero,
                            (Int32)newRect.Left, (Int32)newRect.Top,
                            (Int32)(newRect.Right - newRect.Left + 1),
                            (Int32)(newRect.Bottom - newRect.Top + 1), uFlags);
    }

    [LibraryImport("user32.dll", EntryPoint = "GetSystemMetrics")]
    internal static partial Int32 GetSystemMetrics(int nIndex);

    internal static Int32 SM_CXSCREEN = 0;
    internal static Int32 SM_CYSCREEN = 1;
    internal static Int32 SM_CXVSCROLL = 2;
    internal static Int32 SM_CYHSCROLL = 3;
    internal static Int32 SM_CYCAPTION = 4;
    internal static Int32 SM_CXBORDER = 5;
    internal static Int32 SM_CYBORDER = 6;
    internal static Int32 SM_CXDLGFRAME = 7;
    internal static Int32 SM_CYDLGFRAME = 8;
    internal static Int32 SM_CYVTHUMB = 9;
    internal static Int32 SM_CXHTHUMB = 10;
    internal static Int32 SM_CXICON = 11;
    internal static Int32 SM_CYICON = 12;
    internal static Int32 SM_CXCURSOR = 13;
    internal static Int32 SM_CYCURSOR = 14;
    internal static Int32 SM_CYMENU = 15;
    internal static Int32 SM_CXFULLSCREEN = 16;
    internal static Int32 SM_CYFULLSCREEN = 17;
    internal static Int32 SM_CYKANJIWINDOW = 18;
    internal static Int32 SM_MOUSEPRESENT = 19;
    internal static Int32 SM_CYVSCROLL = 20;
    internal static Int32 SM_CXHSCROLL = 21;
    internal static Int32 SM_DEBUG = 22;
    internal static Int32 SM_SWAPBUTTON = 23;
    internal static Int32 SM_RESERVED1 = 24;
    internal static Int32 SM_RESERVED2 = 25;
    internal static Int32 SM_RESERVED3 = 26;
    internal static Int32 SM_RESERVED4 = 27;
    internal static Int32 SM_CXMIN = 28;
    internal static Int32 SM_CYMIN = 29;
    internal static Int32 SM_CXSIZE = 30;
    internal static Int32 SM_CYSIZE = 31;
    internal static Int32 SM_CXFRAME = 32;
    internal static Int32 SM_CYFRAME = 33;
    internal static Int32 SM_CXMINTRACK = 34;
    internal static Int32 SM_CYMINTRACK = 35;
    internal static Int32 SM_CXDOUBLECLK = 36;
    internal static Int32 SM_CYDOUBLECLK = 37;
    internal static Int32 SM_CXICONSPACING = 38;
    internal static Int32 SM_CYICONSPACING = 39;
    internal static Int32 SM_MENUDROPALIGNMENT = 40;
    internal static Int32 SM_PENWINDOWS = 41;
    internal static Int32 SM_DBCSENABLED = 42;
    internal static Int32 SM_CMOUSEBUTTONS = 43;
    internal static Int32 SM_CXFIXEDFRAME = SM_CXDLGFRAME;  /* ;win40 name change */
    internal static Int32 SM_CYFIXEDFRAME = SM_CYDLGFRAME;  /* ;win40 name change */
    internal static Int32 SM_CXSIZEFRAME = SM_CXFRAME;     /* ;win40 name change */
    internal static Int32 SM_CYSIZEFRAME = SM_CYFRAME;    /* ;win40 name change */
    internal static Int32 SM_SECURE = 44;
    internal static Int32 SM_CXEDGE = 45;
    internal static Int32 SM_CYEDGE = 46;
    internal static Int32 SM_CXMINSPACING = 47;
    internal static Int32 SM_CYMINSPACING = 48;
    internal static Int32 SM_CXSMICON = 49;
    internal static Int32 SM_CYSMICON = 50;
    internal static Int32 SM_CYSMCAPTION = 51;
    internal static Int32 SM_CXSMSIZE = 52;
    internal static Int32 SM_CYSMSIZE = 53;
    internal static Int32 SM_CXMENUSIZE = 54;
    internal static Int32 SM_CYMENUSIZE = 55;
    internal static Int32 SM_ARRANGE = 56;
    internal static Int32 SM_CXMINIMIZED = 57;
    internal static Int32 SM_CYMINIMIZED = 58;
    internal static Int32 SM_CXMAXTRACK = 59;
    internal static Int32 SM_CYMAXTRACK = 60;
    internal static Int32 SM_CXMAXIMIZED = 61;
    internal static Int32 SM_CYMAXIMIZED = 62;
    internal static Int32 SM_NETWORK = 63;
    internal static Int32 SM_CLEANBOOT = 67;
    internal static Int32 SM_CXDRAG = 68;
    internal static Int32 SM_CYDRAG = 69;
    internal static Int32 SM_SHOWSOUNDS = 70;
    internal static Int32 SM_CXMENUCHECK = 71   /* Use instead of GetMenuCheckMarkDimensions()! */;
    internal static Int32 SM_CYMENUCHECK = 72;
    internal static Int32 SM_SLOWMACHINE = 73;
    internal static Int32 SM_MIDEASTENABLED = 74;
    internal static Int32 SM_MOUSEWHEELPRESENT = 75;
    internal static Int32 SM_XVIRTUALSCREEN = 76;
    internal static Int32 SM_YVIRTUALSCREEN = 77;
    internal static Int32 SM_CXVIRTUALSCREEN = 78;
    internal static Int32 SM_CYVIRTUALSCREEN = 79;
    internal static Int32 SM_CMONITORS = 80;
    internal static Int32 SM_SAMEDISPLAYFORMAT = 81;
    internal static Int32 SM_IMMENABLED = 82;
    internal static Int32 SM_CXFOCUSBORDER = 83;
    internal static Int32 SM_CYFOCUSBORDER = 84;
    internal static Int32 SM_TABLETPC = 86;
    internal static Int32 SM_MEDIACENTER = 87;
    internal static Int32 SM_STARTER = 88;
    internal static Int32 SM_SERVERR2 = 89;
    internal static Int32 SM_MOUSEHORIZONTALWHEELPRESENT = 91;
    internal static Int32 SM_CXPADDEDBORDER = 92;
    internal static Int32 SM_DIGITIZER = 94;
    internal static Int32 SM_MAXIMUMTOUCHES = 95;
    internal static Int32 SM_CMETRICS = 93;
    internal static Int32 SM_REMOTESESSION = 0x1000;
    internal static Int32 SM_SHUTTINGDOWN = 0x2000;
    internal static Int32 SM_REMOTECONTROL = 0x2001;
    internal static Int32 SM_CARETBLINKINGENABLED = 0x2002;
    internal static Int32 SM_CONVERTIBLESLATEMODE = 0x2003;
    internal static Int32 SM_SYSTEMDOCKED = 0x2004;
}
