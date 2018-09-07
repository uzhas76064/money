using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Money_2._0
{
    partial class MainWindow : Window
    {
        private void UsdTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            UsdTextBox.Text = "";
        }

        private void RubAnswerTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            RubAnswerTextBox.Text = "";
        }

        private void RubTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            RubTextBox.Text = "";
        }

        private void UsdAnswerTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            UsdAnswerTextBox.Text = "";
        }

        private void CheckCourse_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckCourse.IsChecked)
            {
                Course.IsEnabled = true;
                AcceptButton.IsEnabled = true;
            }
            else if ((bool)!CheckCourse.IsChecked)
            {
                Course.IsEnabled = false;
                AcceptButton.IsEnabled = false;
            }
        }
    }
}

