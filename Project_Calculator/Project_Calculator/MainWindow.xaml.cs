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

namespace Project_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string operationPerformed;
        double resultValue;
        bool isOperationPerformed = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((Screen.Text == "0") || (isOperationPerformed))
            Screen.Clear();
            Button button = (Button)sender;
            isOperationPerformed = false;
            if (button.Content.ToString() == ".")
            {
                if (!Screen.Text.Contains("."))
                {
                    Screen.Text = Screen.Text + button.Content;
                }
            }
            else
            {
                Screen.Text = Screen.Text + button.Content;
            }
        }

        private void ClearButton(object sender, RoutedEventArgs e)
        {
            Screen.Clear();
            resultValue = 0;
        }

        private void OperatorClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if(resultValue != 0)
            {
                
            }
            operationPerformed = button.Content.ToString();
            resultValue = double.Parse(Screen.Text);
            isOperationPerformed = true;
            resultLabel.Content = resultValue + " " + operationPerformed;

        }

        private void EqualButtonClick(object sender, RoutedEventArgs e)
        {
           
            switch (operationPerformed)
            {
                case "+":
                    Screen.Text = (resultValue + double.Parse(Screen.Text)).ToString();
                    break;

                case "-":
                    Screen.Text = (resultValue - double.Parse(Screen.Text)).ToString();
                    break;

                case "*":
                    Screen.Text = (resultValue * double.Parse(Screen.Text)).ToString();
                    break;

                case "/":
                    Screen.Text = (resultValue / double.Parse(Screen.Text)).ToString();
                    break;
            }
        }
    }
}
