namespace GlobalHook.Event
{
    public class KeyUpEvent : KeyEvent, IEvent
    {
        public KeyEventArguments Keys { get; set; }
    }
}
