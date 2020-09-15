using System.Windows;
using WpfBroupBoxDemo.Views;

namespace WpfBroupBoxDemo
{
    /// <summary>
    /// https://github.com/barrylapthorn/MvvmLightExamples
    /// https://www.wintellect.com/model-view-viewmodel-mvvm-explained/
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowView();
        }
    }
}
