using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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
using DataLib;

namespace Money_2._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal d, r;
        decimal user_r;
        Funcs funcs = new Funcs();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CountRubToUsdButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                r = Variables.RUB = decimal.Parse(RubTextBox.Text);  
                UsdAnswerTextBox.Text = (funcs.RubToUsd(r)).ToString();
            }
            catch(FormatException fex)
            {
                ErrorBlock.Text = fex.Message;
                using (StreamWriter sw = new StreamWriter("logs.log", true))
                {
                    sw.Write("=========== Errors in CountRubToUsdButton_Click===========");
                    sw.WriteLine();
                    sw.WriteLine(DateTime.Now + fex.Message + " ");
                };
            }
        }

        private void CountUsdToRubButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                d = Variables.USD = decimal.Parse(UsdTextBox.Text);
                RubAnswerTextBox.Text = (funcs.UsdToRub(d)).ToString();
            }
            catch(FormatException fex)
            {
                ErrorBlock.Text = fex.Message;
                using (StreamWriter sw = new StreamWriter("logs.log", true))
                {
                    sw.Write("=========== Errors in CountUsdToRubButton_Click===========");
                    sw.WriteLine();
                    sw.WriteLine(DateTime.Now + fex.Message + " " + fex.Source);
                };
            }
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                user_r = Variables.RUB = decimal.Parse(Course.Text);
                d = decimal.Parse(UsdTextBox.Text);
                RubAnswerTextBox.Text = (funcs.UserCourse(user_r, d)).ToString();
            }
            catch(FormatException fex)
            {
                ErrorBlock.Text = fex.Message;
                using (StreamWriter sw = new StreamWriter("logs.log", true))
                {
                    sw.Write("=========== Errors in AcceptButton_Click===========");
                    sw.WriteLine();
                    sw.WriteLine(DateTime.Now + fex.Message + " " + fex.Source);
                };
            }
        }

    }
}
