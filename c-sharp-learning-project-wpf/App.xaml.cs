using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace c_sharp_learning_project_wpf
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private const string PARA_DEBUG = "debug";
        private Dictionary<string, string> hash_array ;
        public static string[] Args { get; set; }

        private void Application_Startup(Object sender, StartupEventArgs e)
        {
            bool disp_flg = true;
            hash_array = new Dictionary<string, string>();
            foreach (String arg in e.Args)
            {
                Console.WriteLine(arg.ToString());
                // コマンド引数
                string element = arg.ToString();
                // コマンド引数からパラメータ名と値分割する
                string[] str_array = element.Split('=');
                if (str_array.Count() > 1) // パラメータ名と値が切り分けれない
                    hash_array.Add(str_array[0], str_array[1]); // 切り分けたキーと値の格納
                else
                    hash_array.Add(str_array[0], str_array[0]); // キー名と値が同じ

                if ((hash_array.ContainsKey(PARA_DEBUG)) && hash_array[PARA_DEBUG].Equals(1)) // デバッグパラメータが設定されているか？
                    disp_flg = false;
            }
        }

        [STAThread]
        public static void Main(string[] args)
        {
            Args = args;

            var app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
