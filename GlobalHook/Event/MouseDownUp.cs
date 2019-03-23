namespace GlobalHook.Event
{
    public class MouseDownUp : KeyEvent, IEvent
    {
        public MouseButtons Button { get; set; }
    }
}