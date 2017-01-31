using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_learning_project_wpf.Models
{
    class Debuger
    {
        private Queue<string> log_buffer;
        
        public static void Write_Console<T>(T src)
        {
#if DEBUG
            Console.WriteLine(src.ToString());
#endif 
        }

        public Queue<string> get_log_buffer()
        {
            return log_buffer;
        }

        public string get_log_str()
        {
            string dst_log = "";
            foreach (string str in log_buffer)
                dst_log += (str + "\n");

            return dst_log;
        }
    }
}
