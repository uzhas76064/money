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
using MahApps.Metro.Controls;
using DataLib;

namespace Money_2._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        decimal usd, rub;
        decimal userRub;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void CountRubToUsdButton_Click(object sender, RoutedEventArgs e)
        {
            Funcs funcs = new Funcs();

            try
            {
                rub = Variables.RUB = decimal.Parse(RubTextBox.Text);  
                UsdAnswerTextBox.Text = (funcs.RubToUsd(rub)).ToString();
            }
            catch(FormatException fex)
            {
                ErrorBlock.Text = fex.Message;
                using (StreamWriter sw = new StreamWriter("logs.log", true))
                {
                    sw.WriteLine(DateTime.Now + fex.Message + " ");
                };
            }
            finally
            {
                funcs = null;
            }
        }

        private void CountUsdToRubButton_Click(object sender, RoutedEventArgs e)
        {
            Funcs funcs = new Funcs();

            try
            {
                usd = Variables.USD = decimal.Parse(UsdTextBox.Text);
                RubAnswerTextBox.Text = (funcs.UsdToRub(usd)).ToString();
            }
            catch(FormatException fex)
            {
                ErrorBlock.Text = fex.Message;
                using (StreamWriter sw = new StreamWriter("logs.log", true))
                {
                    sw.WriteLine(DateTime.Now + fex.Message + " " + fex.Source);
                };
            }
            finally
            {
                funcs = null;
            }
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            Funcs funcs = new Funcs();

            try
            {
                userRub = Variables.RUB = decimal.Parse(Course.Text);
                usd = decimal.Parse(UsdTextBox.Text);
                RubAnswerTextBox.Text = (funcs.UserCourse(userRub, usd)).ToString();
            }
            catch(FormatException fex)
            {
                ErrorBlock.Text = fex.Message;
                using (StreamWriter sw = new StreamWriter("logs.log", true))
                {
                    sw.WriteLine(DateTime.Now + fex.Message + " " + fex.Source);
                };
            }
            finally
            {
                funcs = null;
            }
        }

    }
}
