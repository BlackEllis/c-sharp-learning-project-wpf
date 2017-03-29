using System.Collections.Generic;
using System.Windows;

namespace c_sharp_learning_project_wpf.Views
{
    /// <summary>
    /// MainView.xaml の相互作用ロジック
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        private ViewModels.MainViewModel VM { get { return this.DataContext as ViewModels.MainViewModel; } }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.VM.add_log(new List<string>() { "ホゲホゲ" });
        }
    }
}
