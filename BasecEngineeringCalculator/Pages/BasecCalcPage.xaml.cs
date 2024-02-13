using BasecEngineeringCalculator.Pages;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasecEngineeringCalculator.Pages
{
    /// <summary>
    /// Логика взаимодействия для BasecCalcPage.xaml
    /// </summary>
    public partial class BasecCalcPage : Page
    {
        public BasecCalcPage()
        {
            InitializeComponent();
        }

        double argumentOne;
        double argumentTwo;
        char sign;
        double result;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            txtBox.Text += (string)button.Content;
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            txtBox.Clear();
            lableMain.Content = "";
        }

        private void Button_Click_Clean_Last(object sender, RoutedEventArgs e)
        {
            if (txtBox.Text != "")
            {
                txtBox.Text = txtBox.Text.Remove(txtBox.Text.Length - 1);
            }
        }

        private void Button_Click_Division(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string signButton = (string)button.Content;

            switch (signButton)
            {
                case "/":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        txtBox.Text = string.Empty;
                        lableMain.Content = argumentOne + "/";
                        sign = char.Parse(signButton);
                    }
                    catch { }
                    break;

                case "*":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        txtBox.Text = string.Empty;
                        lableMain.Content = argumentOne + "*";
                        sign = char.Parse(signButton);
                    }
                    catch { }
                    break;

                case "-":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        txtBox.Text = string.Empty;
                        lableMain.Content = argumentOne + "-";
                        sign = char.Parse(signButton);
                    }
                    catch { }
                    break;

                case "+":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        txtBox.Text = string.Empty;
                        lableMain.Content = argumentOne + "+";
                        sign = char.Parse(signButton);
                    }
                    catch { }
                    break;
            }
        }

        private void Button_Click_Equls(object sender, RoutedEventArgs e)
        {
            argumentTwo = double.Parse(txtBox.Text);

            switch (sign)
            {
                case '/':
                    result = argumentOne / argumentTwo;
                    txtBox.Text = result.ToString();
                    break;

                case '*':
                    result = argumentOne * argumentTwo;
                    txtBox.Text = result.ToString();
                    break;

                case '-':
                    result = argumentOne - argumentTwo;
                    txtBox.Text = result.ToString();
                    break;

                case '+':
                    result = argumentOne + argumentTwo;
                    txtBox.Text = result.ToString();
                    break;
            }
        }
    }
}
