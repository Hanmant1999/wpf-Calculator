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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
      
    public partial class MainWindow : Window
    {
        static Double num1;
        static Double num2;
        static string oper;
    public MainWindow()
        {
            InitializeComponent();

    }
 // Button Methods
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            input.Text += Convert.ToString((sender as Button).Content);
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            input.Text += Convert.ToString((sender as Button).Content);

        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            insertnumber((sender as Button));
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            insertnumber((sender as Button));
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            insertnumber((sender as Button));
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            insertnumber((sender as Button));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            insertnumber((sender as Button));
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            insertnumber((sender as Button));
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            insertnumber((sender as Button));
        }
        private void point_Click(object sender, RoutedEventArgs e)
        {
            insertnumber((sender as Button));
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            insertnumber((sender as Button));
        }

        private void berij_Click(object sender, RoutedEventArgs e)
        {
            oper = Convert.ToString((sender as Button).Content);
            takeaction();
            ans.Content = oper;

        }
        private void div_Click(object sender, RoutedEventArgs e)
        {
            oper = Convert.ToString((sender as Button).Content);
            takeaction();
            ans.Content = oper;


        }
        private void modelus_Click(object sender, RoutedEventArgs e)
        {
            oper = Convert.ToString((sender as Button).Content);
            takeaction();
            ans.Content = oper;
        }
        private void vaja_Click(object sender, RoutedEventArgs e)
        {
            oper = Convert.ToString((sender as Button).Content);
            takeaction();
            ans.Content = oper;
        }
        private void mult_Click(object sender, RoutedEventArgs e)
        {
            oper = Convert.ToString((sender as Button).Content);
            takeaction();
            ans.Content = oper;

        }
        private void power_Click(object sender, RoutedEventArgs e)
        {
            oper = Convert.ToString((sender as Button).Content);
            takeaction();
            ans.Content = oper;

        }
        private void squarerrot_Click(object sender, RoutedEventArgs e)
        {
            oper = Convert.ToString((sender as Button).Content);
            takeaction();
            ans.Content = oper;

        }
        //Doing work is Here
        private void equal_Click(object sender, RoutedEventArgs e)
        {
            num2 = Convert.ToDouble(input.Text);
            switch (oper) {
                case "+":
                    input.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    input.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    input.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        input.Text = Convert.ToString((Double)num1 / num2);
                    }
                    else
                    {
                        input.Text = "It's Infinity (∞)";
                    }
                    break;
                case "%":
                    input.Text = Convert.ToString(num1 % num2);
                    break;
                case "^":
                    input.Text = Convert.ToString(Math.Pow(num1,num2));
                    break;
                case "√":
                    input.Text = Convert.ToString(Math.Pow(num1, 1/num2));
                    break;


                default:
                    input.Text = "Sorry !!Something Went Wrong !!";
                    break;

            }
           

        }
//defined Methods 
        private void takeaction()
        {
            num1 = Convert.ToDouble(input.Text);
            input.Clear();
        }

        private void insertnumber(object m)
        {
            input.Text += Convert.ToString((m as Button).Content);

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            input.Clear();
            ans.Content = "";
        }

    }
    }

