using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.MVVM.ViewModels
{
    public class CommandViewModel
    {
        public ICommand ClickCommand { get; }
        public ICommand ClickCommand1 { get; }
        public CommandViewModel()
        {
            ClickCommand = new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("Title", "mensaje", "OK");
            });
            ClickCommand1 = new Command((s) =>
            {
                Application.Current.MainPage.DisplayAlert("Title", s.ToString(), "OK");
            });
        }
    }
}
