using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTests.ViewModels
{
    public class MyToggleButtonViewModel : ViewModelBase
    {
        public event PubSubEventHandler<object> TogglePressed;
        public MyToggleButtonViewModel()
        {
            PubSub<object>.AddEvent("TBPresses", TogglePressed);
        }

        bool _IsToggled;
        public bool IsToggled
        {
            get { return _IsToggled; }
            set
            {
                Set(ref _IsToggled, value);
                if(value)
                {
                    PubSub<object>.RaiseEvent("TBPresses", this, new PubSubEventArgs<object>("Red"));
                }
                else
                    PubSub<object>.RaiseEvent("TBPresses", this, new PubSubEventArgs<object>("Blue"));

            }
        }
    }
}
