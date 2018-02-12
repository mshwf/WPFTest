using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTests.ViewModels
{
    public class MyGridViewModel : ViewModelBase
    {
        public MyGridViewModel()
        {
            PubSub<object>.RegisterEvent("TBPresses", ToggledHandler);
        }

        private void ToggledHandler(object sender, PubSubEventArgs<object> args)
        {
            BG = (string)args.Item;
        }

        string _BG;
        public string BG
        {
            get { return _BG; }
            set { Set(ref _BG, value); }
        }
    }
}
