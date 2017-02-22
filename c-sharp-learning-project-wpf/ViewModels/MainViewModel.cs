using c_sharp_learning_project_wpf.Views;
using System.ComponentModel;
using System.Windows.Input;

namespace c_sharp_learning_project_wpf.ViewModels
{
    public partial class MainViewModel : INotifyPropertyChanged
    {
        DebugLogView dw = default(DebugLogView);
        DebuglogViewModel dvm = default(DebuglogViewModel);

        public event PropertyChangedEventHandler PropertyChanged;
        public void add_log(string str)
        {
            dvm.log_text += str;
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
