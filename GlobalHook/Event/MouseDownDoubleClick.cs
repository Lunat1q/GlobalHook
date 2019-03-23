namespace GlobalHook.Event
{
    public class MouseDownDoubleClick : KeyEvent, IEvent
    {
        public MouseButtons Button { get; set; }
    }
}