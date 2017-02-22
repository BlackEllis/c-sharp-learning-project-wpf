using c_sharp_learning_project_wpf.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace c_sharp_learning_project_wpf.ViewModels
{
    class DebuglogViewModel : INotifyPropertyChanged
    {
        private string _log_text;

        public event PropertyChangedEventHandler PropertyChanged;
        private static readonly PropertyChangedEventArgs property_change_e_args = new PropertyChangedEventArgs(nameof(log_text));

        public string log_text
        {
            get { return this._log_text; }
            set {
                if (value.Equals("")) return;

                this._log_text = value;
                PropertyChanged?.Invoke(this, property_change_e_args);
            }
        }

        public DebuglogViewModel(){}
    }
}
