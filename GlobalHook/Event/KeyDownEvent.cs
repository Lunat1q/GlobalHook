namespace GlobalHook.Event
{
    public class KeyDownEvent : KeyEvent, IEvent
    {
        public KeyEventArguments Keys { get; set; }
    }
}
