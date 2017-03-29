using c_sharp_learning_project_wpf.Views;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace c_sharp_learning_project_wpf.ViewModels
{
    public partial class MainViewModel : INotifyPropertyChanged
    {
        DebugLogView dw = null;
        DebuglogViewModel dvm = null;

        public event PropertyChangedEventHandler PropertyChanged;
        public void add_log(List<string> strs)
        {
            dvm.log_text = strs;
        }

        public MainViewModel()
        {
            dw = new DebugLogView();
            dvm = new DebuglogViewModel();

            dw.DataContext = dvm;
            dw.Show();
        }
    }
}
