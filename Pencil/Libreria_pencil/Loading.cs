﻿using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace loading
{
    class Loading
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
        UIntPtr dwExtraInfo);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);

        private const int KEYEVENTF_EXTENDEDKEY = 0x1;
        private const int KEYEVENTF_KEYUP = 0x2;

        static ConsoleEventDelegate handler;
        private delegate bool ConsoleEventDelegate(int eventType);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCtrlHandler(ConsoleEventDelegate callback, bool add);
        static void Main()
        {
            handler = new ConsoleEventDelegate(ConsoleEventCallback);
            SetConsoleCtrlHandler(handler, true);
            while (true)
            {
                ClearActive();
                Activate(0x90);
                Thread.Sleep(100);
                Activate(0x14);
                Thread.Sleep(100);
                Activate(0x91);
                Thread.Sleep(100);
                Activate(0x90);
                Thread.Sleep(100);
                Activate(0x14);
                Thread.Sleep(100);
                Activate(0x91);
                Thread.Sleep(100);
            }
        }
        public static void ClearActive()
        {
            if ((((ushort)GetKeyState(0x90)) & 0xffff) != 0)
            {
                Activate(0x90);
            }
            if ((((ushort)GetKeyState(0x14)) & 0xffff) != 0)
            {
                Activate(0x14);
            }
            if ((((ushort)GetKeyState(0x91)) & 0xffff) != 0)
            {
                Activate(0x91);
            }
        }

        public static void Activate(byte key)
        {

            keybd_event(key, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            keybd_event(key, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP,
            (UIntPtr)1);
        }

        static bool ConsoleEventCallback(int eventType)
        {
            if (eventType == 2)
            {
                ClearActive();
            }
            return false;
        }
    }
}
