using GlobalHook.Event;

namespace GlobalHook
{
    public delegate void EventDelegate(IEvent evt);

    public interface IEventDispatcher
    {
        event EventDelegate EventReceived;
        void Send(IEvent evt);
        bool HaveSubs();
    }

    public class EventDispatcher : IEventDispatcher
    {
        public event EventDelegate EventReceived;

        public void Send(IEvent evt)
        {
            EventReceived?.Invoke(evt);
        }

        public bool HaveSubs()
        {
            return EventReceived != null;
        }
    }
}
