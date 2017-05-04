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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string oneItem = "";
        string twoItem = "";
        string operation = "";
        double value = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            string s = (string)((Button)e.OriginalSource).Content;
            double temp;
            bool x = double.TryParse(s, out temp);
            if (x==true)
            {
                textCalc.Text += s;
            }
            else
            {
                if (s=="=")
                {
                    if (oneItem != "" && textCalc.Text!=null)
                    {
                        twoItem = textCalc.Text;
                        textblock.Text += textCalc.Text+s;
                        textCalc.Text = null;
                        textblock.Text += Useoperation(operation);
                        oneItem = "";
                        twoItem = "";
                        operation = "";

                    }
                    else
                    {
                        MessageBox.Show("net znacheniy");
                    }
                }
                else
                {
                    if (oneItem=="" && textCalc.Text!=null)
                    {
                        oneItem = textCalc.Text;
                        textblock.Text = textCalc.Text+s;
                        textCalc.Text = null;
                        operation = s;
                    }
                    else
                    {

                    }
                }
            }

            
        }
        public double Useoperation(string operation)
        {
            double num1 = double.Parse(oneItem);
            double num2 = double.Parse(twoItem);

            switch (operation)
            {
                case "+":
                    value = num1 + num2;
                    break;
                case "-":
                    value = num1 - num2;
                    break;
                case "*":
                    value = num1 * num2;
                    break;
                case "/":
                    value = num1 / num2;
                    break;

                default:
                    break;
            }
            return value;
        }
    }
}
