using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFTest.Models;

namespace WPFTest.Cmds
{
    public class ChangeColorCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => (parameter as Book) != null;

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
