using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NumLock
{
    internal class Program
    {
        private const int KEYEVENTF_EXTENDEDKEY = 0x1;
        private const int KEYEVENTF_KEYUP = 0x2;

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);


        private static void Main(string[] args)
        {
            keybd_event((byte) Keys.NumLock, 0, KEYEVENTF_EXTENDEDKEY, 0);
            keybd_event((byte) Keys.NumLock, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }
    }
}