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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _pass = "2733";
        private string _inputPass = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello bro");
            Window1 window = new Window1();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _inputPass = passwTxt.ToString();
            if (_inputPass == _pass)
            {
                txtDisplay.Text = "Добро";
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }

        private void UserTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
