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
using Calculator.Functions;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double num = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void click_num_7(object sender, RoutedEventArgs e)
        {
            num = Convert.ToDouble(num7.Content);
            SpaceNums.Text += $"{num}";
        }

        private void click_num_8(object sender, RoutedEventArgs e)
        {
            num = Convert.ToDouble(num8.Content);
            SpaceNums.Text += $"{num}";
        }

        private void click_num_9(object sender, RoutedEventArgs e)
        {
            num = Convert.ToDouble(num9.Content);
            SpaceNums.Text += $"{num}";
        }

        private void click_num_Sqt(object sender, RoutedEventArgs e)
        {
            //num = numSqt.Content;
            SpaceNums.Text += $"{numSqt.Content}";
        }

        private void click_num_Proc(object sender, RoutedEventArgs e)
        {
            //num = Convert.ToDouble(numProc.Content);
            SpaceNums.Text += $"{numProc.Content}";
        }

        private void click_num_4(object sender, RoutedEventArgs e)
        {
            num = Convert.ToDouble(num4.Content);
            SpaceNums.Text += $"{num}";
        }

        private void click_num_5(object sender, RoutedEventArgs e)
        {
            num = Convert.ToDouble(num5.Content);
            SpaceNums.Text += $"{num}";
        }

        private void click_num_6(object sender, RoutedEventArgs e)
        {
            num = Convert.ToDouble(num6.Content);
            SpaceNums.Text += $"{num}";
        }

        private void click_num_X(object sender, RoutedEventArgs e)
        {
           // num = Convert.ToDouble(numX.Content);
            SpaceNums.Text += $"{numX.Content}";
        }

        private void click_num_Del(object sender, RoutedEventArgs e)
        {
            SpaceNums.Text += $"{numDel.Content}";
        }

        private void click_num_0(object sender, RoutedEventArgs e)
        {
            num = Convert.ToDouble(num0.Content);
            SpaceNums.Text += $"{num}";
        }

        private void click_num_2(object sender, RoutedEventArgs e)
        {
            num = Convert.ToDouble(num2.Content);
            SpaceNums.Text += $"{num}";
        }

        private void click_num_3(object sender, RoutedEventArgs e)
        {
            num = Convert.ToDouble(num3.Content);
            SpaceNums.Text += $"{num}";
        }

        private void click_num_Min(object sender, RoutedEventArgs e)
        {
            //num = Convert.ToDouble(numMin.Content);
            SpaceNums.Text += $"{numMin.Content}";
        }

        private void click_num_C(object sender, RoutedEventArgs e)
        {
            SpaceNums.Clear();
        }

        private void click_num_0q(object sender, RoutedEventArgs e)
        {
            num = Convert.ToDouble(num0q.Content);
            SpaceNums.Text += $"{num}";
        }

        private void click_num_Point(object sender, RoutedEventArgs e)
        {
            SpaceNums.Text += $",";
        }

        private void click_num_Plus(object sender, RoutedEventArgs e)
        {
            SpaceNums.Text += $"{numPlus.Content}";
        }

        private void click_num_Equals(object sender, RoutedEventArgs e)
        {
            try
            {
                double result = CalculateFunc.Calculate(SpaceNums.Text);
                SpaceNums.Text = Convert.ToString(result);
            }
            catch (Exception ex)
            {
                SpaceNums.Text = ex.Message;
            }
        }
    }
}
