using System.Runtime.InteropServices;

namespace DetachedConsoleDemo
{
    internal static class ConsoleExt
    {
        public static bool Free() => FreeConsole();

        public static bool Alloc() => AllocConsole();

        public static uint ConsoleOwnerProcessId
        {
            get
            {
                GetWindowThreadProcessId(GetConsoleWindow(), out var pid);
                return pid;
            }
        }


        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        private static extern bool FreeConsole();
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
    }
}
