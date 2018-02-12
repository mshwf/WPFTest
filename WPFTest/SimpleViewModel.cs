using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest
{
    public class SimpleViewModel
    {
        public SimpleModel Model { get; set; }
        public string TrueTitle { get; set; }
        public SimpleViewModel()
        {
            Model = new SimpleModel { Title = "Hello MVVM" };
            TrueTitle = "true title";
        }
    }
}
