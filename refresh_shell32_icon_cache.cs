using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shell32;
using System.Runtime.InteropServices;

namespace ConsoleApplication1 {
    class refresh_shell32_icon_cache {
        [DllImport("Shell32.dll")]
        public static extern int SHChangeNotify(int wEventId, int uFlags, IntPtr dwItem1, IntPtr dwItem2);

        static void Main(string[] args) {
            SHChangeNotify(0x8000000, 0x1000, IntPtr.Zero, IntPtr.Zero);
        }
    }
}
