using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
            this.VM.add_log("ホゲホゲ");
        }
    }
}
