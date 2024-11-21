using UnityEngine;

namespace RedShoreGames.EventSystem
{
    public abstract class Actor<T> : MonoBehaviour where T : MonoBehaviour 
    {
        public EventManager Manager => EventManager.Instance;

        protected virtual void Push(string eventName, params object[] arguments)
        {
            Manager.Push(eventName, arguments);
        }

        protected virtual void Register(string eventName, Event @event)
        {
            Manager.Register(eventName, @event);
        }

        protected virtual void Unregister(string eventName, Event @event)
        {
            Manager.Unregister(eventName, @event);
        }

        protected virtual void Listen(bool status) { }
    }
}