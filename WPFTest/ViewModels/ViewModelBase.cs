using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfTests.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public void Set<T>(ref T member, T value, [CallerMemberName] string propName = "")
        {
            if (!Equals(value, member))
            {
                member = value;
                OnPropertyChanged(propName);
            }
        }
    }
}