using System.Windows.Controls;

namespace BasecEngineeringCalculator.Pages
{
    /// <summary>
    /// Логика взаимодействия для EngineeringCalcPage.xaml
    /// </summary>
    public partial class EngineeringCalcPage : Page
    {
        public EngineeringCalcPage()
        {
            InitializeComponent();
        }

        private void Button_Click_Get_Sign(object sender, System.Windows.RoutedEventArgs e)
        {
            Button button = sender as Button;
            txtBox.Text += button.Content.ToString();
        }
    }
}
