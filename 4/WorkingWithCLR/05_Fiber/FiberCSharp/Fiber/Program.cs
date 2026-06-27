using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fiber
{
    public static class API
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr ConvertThreadToFiber(IntPtr lpParameter);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr VirtualAlloc(IntPtr lpAddress, IntPtr dwSize, UInt32 flAllocationType, UInt32 flProtect);

        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateFiber(uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter);

        [DllImport("kernel32.dll")]
        public static extern void SwitchToFiber(IntPtr lpFiber);

        [DllImport("Kernel32.dll", EntryPoint = "RtlMoveMemory", SetLastError = false)]
        public static extern void MoveMemory(IntPtr dest, Byte[] src, int size);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("test");
        }
    }
}
