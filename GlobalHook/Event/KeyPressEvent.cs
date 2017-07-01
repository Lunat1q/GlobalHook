namespace GlobalHook.Event
{
    public class KeyPressEvent : KeyEvent, IEvent
    {
        public KeyEventArguments Keys { get; set; }
        public char Key { get; set; }
    }
}
