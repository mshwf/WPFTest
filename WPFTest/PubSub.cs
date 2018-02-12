using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTests
{
    public static class PubSub<T>
    {
        static Dictionary<string, PubSubEventHandler<T>> events = new Dictionary<string, PubSubEventHandler<T>>();

        public static void AddEvent(string name, PubSubEventHandler<T> handler)
        {
            events.Add(name, handler);
        }

        public static void RegisterEvent(string name, PubSubEventHandler<T> handler)
        {
            if (events.ContainsKey(name))
                events[name] += handler;
        }

        public static void RaiseEvent(string name, object sender, PubSubEventArgs<T> args)
        {
            if (events.ContainsKey(name))
                events[name](sender, args);
        }
    }
}
