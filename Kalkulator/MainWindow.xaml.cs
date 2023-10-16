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

namespace Kalkulator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "0";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            resultBox.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "1";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "2";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "3";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "4";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "5";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "6";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "7";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "8";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "9";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
                string content = resultBox.Text;
                string[] operators = new string[] { "+", "-", "*", "/" };

                    // Mencari operator dalam ekspresi untuk memisahkan angka.
                    foreach (string op in operators)
                    {
                        string[] operands = content.Split(new string[] { op }, StringSplitOptions.RemoveEmptyEntries);
                        if (operands.Length == 2)
                        {
                            double first = double.Parse(operands[0]);
                            double second = double.Parse(operands[1]);
                            double result = 0;

                            // Melakukan perhitungan sesuai operator.
                            switch (op)
                            {
                                case "+":
                                    result = first + second;
                                    break;
                                case "-":
                                    result = first - second;
                                    break;
                                case "*":
                                    result = first * second;
                                    break;
                                case "/":
                                    result = first / second;
                                    break;
                            }

                            // Menampilkan hasil perhitungan pada layar.
                            resultBox.Text = result.ToString();
                            return;
                        }
                    }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {    
            resultBox.Text = resultBox.Text + "/";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "*";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "-";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "+";
        }
    }
}
