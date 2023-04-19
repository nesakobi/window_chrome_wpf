using System.Windows;
using WpfApp2.MVM;
using WpfCustomControlLibrary1;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NormalWindowButtonClick(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            var content = new WindowContent()
            {
                DataContext = new ContentViewModel()
            };
            window.Content = content;
            window.Show();
        }

        private void ChromeWindowButtonClick(object sender, RoutedEventArgs e)
        {
            var window = new CustomChromeWindow();
            var content = new WindowContent()
            {
                DataContext = new ContentViewModel()
            };
            window.Content = content;
            window.Show();
        }
    }
}
