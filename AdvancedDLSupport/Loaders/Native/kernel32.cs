﻿using System.Runtime.InteropServices;
using FARPROC = System.IntPtr;
using HMODULE = System.IntPtr;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1300 // Elements should begin with an uppercase letter
#pragma warning disable SA1600, CS1591 // Elements should be documented

namespace AdvancedDLSupport
{
    internal static class kernel32
    {
        [DllImport("kernel32")]
        public static extern HMODULE LoadLibrary(string fileName);

        [DllImport("kernel32")]
        public static extern FARPROC GetProcAddress(HMODULE module, string procName);

        [DllImport("kernel32")]
        public static extern int FreeLibrary(HMODULE module);
    }
}