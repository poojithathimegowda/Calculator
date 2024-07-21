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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int firstNumber, secondNumber, finalResult;
        string operationMethod;
        public MainWindow()
        {
            InitializeComponent();
            textBox.Text = "0";
        }

        private void number_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += (sender as Button).Content;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
            finalResult = 0;
        }
        private void operation(object sender, RoutedEventArgs e)
        {
            operationMethod = (sender as Button).Name;
            firstNumber= Int32.Parse(textBox.Text);
            textBox.Text= "0";
        }
        private void result_Click(object sender, RoutedEventArgs e)
        {
            secondNumber = Int32.Parse(textBox.Text);
            switch (operationMethod)
            {
                case "add":
                    finalResult = firstNumber + secondNumber;
                   break;
                case "subtract":
                    finalResult = firstNumber - secondNumber;
                    break;
                case "multiply":
                    finalResult = firstNumber * secondNumber;
                    break;
                case "divide":
                    finalResult = firstNumber / secondNumber;
                    break;

            }
            textBox.Text = finalResult.ToString();

        }
    }
}
