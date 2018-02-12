using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTests
{
    class MagicButtonVM : INotifyPropertyChanged
    {
        public MagicButtonVM()
        {
            Movies = new List<string>
            {
                "The Dark Knight",
                "The Big Lebowski",
                "The Shawshank Redemption",
                "Schindler's List",
                "Pulp Fiction",
                "Fight Club"
            };
        }
        public List<string> Movies { get; set; }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

    }
}
