using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using c_sharp_learning_project_wpf.ViewModels;
using c_sharp_learning_project_wpf.Views;

namespace c_sharp_learning_project_wpf
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        public static string[] Args { get; set; }

        /// <summary>
        /// アプリケーションが開始される時のイベント
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var w = new MainView();
            var vm = new MainViewModel();

            w.DataContext = vm;
            w.Show();
        }

        /// <summary>
        /// アプリケーションが終了する時のイベント
        /// </summary>
        /// <param name="args"></param>
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
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
