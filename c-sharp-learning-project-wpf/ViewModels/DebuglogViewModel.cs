using c_sharp_learning_project_wpf.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace c_sharp_learning_project_wpf.ViewModels
{
    class DebuglogViewModel : INotifyPropertyChanged
    {
        public Debuger debug_model { set; get; }
        public event PropertyChangedEventHandler PropertyChanged;
        private static readonly PropertyChangedEventArgs property_change_e_args = new PropertyChangedEventArgs(nameof(log_text));
        public DebuglogViewModel()
        {
            debug_model = new Debuger();
        }

        public List<string> log_text
        {
            set
            {
                if ((value == null) || (value.Count == 0)) return;
                foreach (string str in value)
                {
                    debug_model.log_text = str;
                }
                PropertyChanged?.Invoke(this, property_change_e_args);
            }
            get
            {
                return new List<string>(debug_model.log_texts);
            }
        }
    }
}
