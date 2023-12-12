using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace GlikoLog.BL
{
    public static class NativeWinAPI
    {
        public static readonly int GWL_EXSTYLE = -20;
        public static readonly int WS_EX_COMPOSITED = 0x02000000;

        [DllImport("user32")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
    }
}
