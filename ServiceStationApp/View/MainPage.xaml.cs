using ServiceStationApp.Controls;
using ServiceStationApp.View;
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
using System.Windows.Shapes;

namespace ServiceStationApp
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // TODO: Сделать нормальную верстку
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Вы клиент");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Вы Сотрудник");
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            AdministratorPage admin = new AdministratorPage();
            admin.Show();
        }

        private void btn_local_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Язык поменяли");
        }
    }
}
