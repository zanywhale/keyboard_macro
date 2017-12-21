using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        //키보드 이벤트 
        [DllImport("user32.dll")]
        public static extern void keybd_event(
            byte bVk,  //virtual-key code
            byte bScan, //hardware scan code
            int dwFlags,  //function options 
            ref int dwExtraInfo  //additional keystroke data 
            );


        static void Main(string[] args)
        {
            const byte CtrlKey = 0x11;
            const byte WinKey = 0x5B;
            const byte RightKey = 0x27;
            const byte LeftKey = 0x25;
            const byte AltKey = 0x12;
            const int KEYUP = 0x02;
            int info = 0;
            keybd_event(CtrlKey, 0, 0, ref info);
            keybd_event(AltKey, 0, 0, ref info);
            keybd_event(CtrlKey, 0, KEYUP, ref info);
            keybd_event(AltKey, 0, KEYUP, ref info);

            keybd_event(WinKey, 0, 0, ref info);
            keybd_event(CtrlKey, 0, 0, ref info);
            keybd_event(LeftKey, 0, 0, ref info);
            keybd_event(WinKey, 0, KEYUP, ref info);
            keybd_event(CtrlKey, 0, KEYUP, ref info);
            keybd_event(LeftKey, 0, KEYUP, ref info);
        }
    }
}
