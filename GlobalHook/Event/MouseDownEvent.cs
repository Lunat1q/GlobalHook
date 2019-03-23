namespace GlobalHook.Event
{
    public class MouseDownEvent : KeyEvent, IEvent
    {
        public MouseButtons Button { get; set; }
    }
}