using c_sharp_learning_project_wpf.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
            //obj = new ObservableCollection<Debuger>() { debug_model };
        }

        //public string log_text
        //{
        //    set
        //    {
        //        if (value.Equals("")) return;
        //        debug_model.log_text = value;
        //    }
        //    get { return debug_model.log_text; }
        //}

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
                return debug_model.log_texts;
            }
        }
    }
}
