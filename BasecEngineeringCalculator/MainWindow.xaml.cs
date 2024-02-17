using BasecEngineeringCalculator.Pages;
using System.Windows;

namespace BasecEngineeringCalculator
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

        private void Calculater_Click(object sender, RoutedEventArgs e)
        {
            //Window window = Window.GetWindow(this);
            //window.SizeToContent = SizeToContent.WidthAndHeight;
            MainFrame.NavigationService.Navigate(new BasecCalcPage());
        }

        private void IngineeringCalculator_Click(object sender, RoutedEventArgs e)
        {
            //Window window = Window.GetWindow(this);
            //window.SizeToContent = SizeToContent.WidthAndHeight;
            MainFrame.NavigationService.Navigate(new EngineeringCalcPage());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButton.YesNoCancel, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}