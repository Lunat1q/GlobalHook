using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHook.Event
{
    public class KeyEventArguments
    {
        public KeyModifier Modifiers;
        public int KeyPressed;
    }

    [Flags]
    public enum KeyModifier
    {
        None = 0,
        Shift = 2,
        Ctrl = 4,
        Alt = 8
    }
}
