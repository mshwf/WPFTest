using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTests
{
    public delegate void PubSubEventHandler<T>(object sender, PubSubEventArgs<T> args);
    public class PubSubEventArgs<T> : EventArgs
    {
        public T Item { get; set; }
        public PubSubEventArgs(T item)
        {
            Item = item;
        }
    }
}
