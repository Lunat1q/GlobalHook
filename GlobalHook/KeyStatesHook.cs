using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHook
{
    public static class KeyStatesHook
    {
        [DllImport("USER32.dll")]
        private static extern short GetKeyState(VirtualKeyStates nVirtKey);

        public static bool IsLeftMouseDown()
        {
            return GetKeyState(VirtualKeyStates.VK_LBUTTON) < 0;
        }
    }
}
