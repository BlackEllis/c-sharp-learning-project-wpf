using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_learning_project_wpf.Models
{
    class Debuger : INotifyPropertyChanged
    {
        public static void Write_Console<T>(T src)
        {
#if DEBUG
            Console.WriteLine(src.ToString());
#endif 
        }

        public Queue<string> log_buffer { get; set; }
        public string get_log_str()
        {
            string dst_log = "";
            foreach (string str in log_buffer)
                dst_log += (str + "\n");

            return dst_log;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName]string property_name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
