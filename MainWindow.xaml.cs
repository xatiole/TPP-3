using System;
using System.Collections.Generic;
using System.Data;
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

namespace Лабораторная3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int oper = 0;
        string[] digits = new string[10000];
        string[] equals = new string[10000];
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Button_AC.Visibility = Visibility.Hidden;
            history_label.Visibility = Visibility.Hidden;
            AC_one.Visibility = Visibility.Hidden;
            Check_box.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Button_AC.Visibility = Visibility.Visible;
            history_label.Visibility = Visibility.Visible;
            AC_one.Visibility = Visibility.Visible;
            Check_box.Visibility = Visibility.Visible;
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_1.Content;
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_2.Content;
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_3.Content;
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_4.Content;
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_5.Content;
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_6.Content;
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_7.Content;
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_8.Content;
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_9.Content;
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            if (textlabel.Text == "")
            {

            }
            else
            {
                textlabel.Text += Button_0.Content;
            }
        }

        private void Button_AC_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text = "";
            Array.Clear(digits, 0, digits.Length);
            Array.Clear(equals, 0, equals.Length);
            history_label.Text = "";
        }

        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_plus.Content;
        }

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_minus.Content;
        }

        private void Button_multi_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_multi.Content;
        }

        private void Button_div_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_div.Content;
        }

        private void Button_eq_Click(object sender, RoutedEventArgs e)
        {
            if (Check_box.IsChecked == true)
            {

                digits[oper] = textlabel.Text;
                history_label.Text += digits[oper];
                string value = new DataTable().Compute(textlabel.Text, null).ToString();
                textlabel.Text = value;
                history_label.Text += "=";
                equals[oper] += value;
                history_label.Text += value;
                history_label.Text += " ";
                oper += 1;
            }
            else
            {
                string value = new DataTable().Compute(textlabel.Text, null).ToString();
                textlabel.Text = value;

            }
        }

        private void Button_AC_one_Click(object sender, RoutedEventArgs e)
        {
            if (Check_box.IsChecked == true)
            {
                digits[oper - 1] = null;
                equals[oper - 1] = null;
                oper -= 1;
                history_label.Text = "";
                for (int i = 0; i < oper; i++)
                {
                    history_label.Text += digits[i];
                    history_label.Text += "=";
                    history_label.Text += equals[i];
                    history_label.Text += " ";
                }

                textlabel.Text = "";
            }
            else
            {
                textlabel.Text = "";
            }
        }
    }
}
