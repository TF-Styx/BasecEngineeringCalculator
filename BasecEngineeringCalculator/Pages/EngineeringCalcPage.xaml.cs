using System.Numerics;
using System.Windows;
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

        double argumentOne;
        double argumentTwo;
        string sign;
        double result;

        private void Button_Click_Get_Number(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            txtBox.Text += (string)button.Content;
        }

        private void Button_Click_Clear_All(object sender, RoutedEventArgs e)
        {
            argumentOne = double.NaN;
            argumentTwo = double.NaN;
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

        private void Button_Click_Get_Sign(object sender, RoutedEventArgs e)
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
                        sign = signButton;
                    }
                    catch { }
                    break;

                case "*":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        txtBox.Text = string.Empty;
                        lableMain.Content = argumentOne + "*";
                        sign = signButton;
                    }
                    catch { }
                    break;

                case "-":
                    try
                    {
                        if (txtBox.Text == "") txtBox.Text += "-";

                        argumentOne = double.Parse(txtBox.Text);
                        txtBox.Text = string.Empty;
                        lableMain.Content = argumentOne + "-";
                        sign = signButton;
                    }
                    catch { }
                    break;

                case "+":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        txtBox.Text = string.Empty;
                        lableMain.Content = argumentOne + "+";
                        sign = signButton;
                    }
                    catch { }
                    break;

                case "^":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        txtBox.Text = string.Empty;
                        lableMain.Content = argumentOne + "^";
                        sign = signButton;
                    }
                    catch { }
                    break;

                case "n!":
                    try
                    {
                        BigInteger x = BigInteger.Parse(txtBox.Text);
                        txtBox.Text = Factorial(x).ToString();
                        lableMain.Content = x + "!";
                        sign = signButton;
                    }
                    catch { }
                    break;

                case "±":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        txtBox.Text = (argumentOne * -1).ToString();
                    }
                    catch { }
                    break;

                case "asin":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        if (argumentOne <= 1 || argumentTwo >= -1)
                        {
                            txtBox.Text = Math.Asin(argumentOne).ToString();
                            lableMain.Content = $"Asin({argumentOne}) = ";
                            sign = signButton;
                        }
                        else
                        {
                            lableMain.Content = "Число должно быть от -1 до +1";
                            txtBox.Text = string.Empty;
                        }
                    }
                    catch { }
                    break;

                case "sin":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        double angleRadians = (Math.PI * argumentOne) / 180;
                        txtBox.Text = Math.Sin(angleRadians).ToString();
                        lableMain.Content = $"Sin({argumentOne}) = ";
                        sign = signButton;
                    }
                    catch { }
                    break;

                case "1/x":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        txtBox.Text = (1 / argumentOne).ToString();
                        lableMain.Content = $"1/{argumentOne} = "; ;
                        sign = signButton;
                    }
                    catch { }
                    break;

                case "acos":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        if (argumentOne <= 1 || argumentTwo >= -1)
                        {
                            txtBox.Text = Math.Acos(argumentOne).ToString();
                            lableMain.Content = $"Acos({argumentOne}) = ";
                            sign = signButton;
                        }
                        else
                        {
                            lableMain.Content = "Число должно быть от -1 до +1";
                            txtBox.Text = string.Empty;
                        }
                    }
                    catch { }
                    break;

                case "cos":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        double angleRadians = (Math.PI * argumentOne) / 180;
                        txtBox.Text = Math.Cos(angleRadians).ToString();
                        lableMain.Content = $"Cos({argumentOne}) = ";
                        sign = signButton;
                    }
                    catch { }
                    break;

                case "√":
                    try
                    {
                        if (argumentOne >= 1)
                        {
                            argumentOne = double.Parse(txtBox.Text);
                            txtBox.Text = Math.Sqrt(argumentOne).ToString();
                            lableMain.Content = $"√{argumentOne} = ";
                            sign = signButton;
                        }
                        else
                        {
                            lableMain.Content = "Число должно быть > 0";
                            txtBox.Text = string.Empty;
                        }
                    }
                    catch { }
                    break;

                case "atan":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        txtBox.Text = Math.Atan(argumentOne).ToString();
                        lableMain.Content = $"Atan({Math.Atan(argumentOne) * 180 / Math.PI})°";
                        sign = signButton;
                    }
                    catch { }
                    break;

                case "tan":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        double angleRadians = (Math.PI * argumentOne) / 180;
                        txtBox.Text = Math.Tan(angleRadians).ToString();
                        lableMain.Content = $"Tan({Math.Atan(argumentOne) * 180 / Math.PI})°";
                        sign = signButton;
                    }
                    catch { }
                    break;

                case "ln":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        txtBox.Text = Math.Log(argumentOne).ToString();
                        lableMain.Content = $"ln({Math.Log10(argumentOne)})";
                        sign = signButton;
                    }
                    catch { }
                    break;

                case "lg":
                    try
                    {
                        argumentOne = double.Parse(txtBox.Text);
                        txtBox.Text = Math.Log10(argumentOne).ToString();
                        lableMain.Content = $"lg({Math.Log10(argumentOne)})";
                        sign = signButton;
                    }
                    catch { }
                    break;

                case "π":
                    try
                    {
                        txtBox.Text = Math.PI.ToString();
                        lableMain.Content = "Знак π = ";
                    }
                    catch { }
                    break;

                case "e":
                    try
                    {
                        txtBox.Text = Math.E.ToString();
                        lableMain.Content = "Знак e = ";
                    }
                    catch { }
                    break;
            }
        }

        private void Button_Click_Equls(object sender, RoutedEventArgs e)
        {
            lableMain.Content = txtBox.Text == "" ? "Нету аргументов" : argumentTwo = double.Parse(txtBox.Text);

            switch (sign)
            {
                case "/":
                    result = argumentOne / argumentTwo;
                    txtBox.Text = result.ToString("F2");
                    lableMain.Content = $"{argumentOne} / {argumentTwo} = ";
                    break;

                case "*":
                    result = argumentOne * argumentTwo;
                    txtBox.Text = result.ToString("F2");
                    lableMain.Content = $"{argumentOne} * {argumentTwo} = ";
                    break;

                case "-":
                    result = argumentOne - argumentTwo;
                    txtBox.Text = result.ToString("F2");
                    lableMain.Content = $"{argumentOne} - {argumentTwo} = ";
                    break;

                case "+":
                    result = argumentOne + argumentTwo;
                    txtBox.Text = result.ToString("F2");
                    lableMain.Content = $"{argumentOne} + {argumentTwo} = ";
                    break;

                case "^":
                    result = Math.Pow(argumentOne, argumentTwo);
                    txtBox.Text = result.ToString("F2");
                    lableMain.Content = $"{argumentOne}^{argumentTwo} = ";
                    break;

                case "n!": // ДОДЕЛАТЬ
                    //result = Math.Pow(argumentOne, argumentTwo);
                    txtBox.Text = result.ToString("F2");
                    lableMain.Content = $"{argumentOne}^{argumentTwo} = ";
                    break;
            }
        }
        public static BigInteger Factorial(BigInteger number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
