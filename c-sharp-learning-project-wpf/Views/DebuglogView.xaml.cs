using c_sharp_learning_project_wpf.Models;
using c_sharp_learning_project_wpf.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace c_sharp_learning_project_wpf.Views
{
    /// <summary>
    /// DebugLogView.xaml の相互作用ロジック
    /// </summary>
    public partial class DebugLogView : Window
    {
        private readonly DebuglogViewModel _debuger_vm;

        public DebugLogView()
        {
            InitializeComponent();
        }
        
    }
}
