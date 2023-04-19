using System.Windows;

namespace WpfCustomControlLibrary1
{
    public class CustomChromeWindow : Window
    {
        static CustomChromeWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomChromeWindow), new FrameworkPropertyMetadata(typeof(CustomChromeWindow))); 
        }
    }
}
