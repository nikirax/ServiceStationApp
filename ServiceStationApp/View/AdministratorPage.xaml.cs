using ServiceStationApp.Controls;
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

namespace ServiceStationApp.View
{
    /// <summary>
    /// Логика взаимодействия для AdministratorPage.xaml
    /// </summary>
    public partial class AdministratorPage : Window
    {
        List<User> users;
        List<Car> cars;
        List<Order> orders;
        Context db = new Context();
        public AdministratorPage()
        {
            InitializeComponent();
            
            db = new Context();

            users = db.Users.ToList();
            cars = db.Cars.ToList();
            orders = db.Orders.ToList();

            dataGrid.ItemsSource = users;
        }

        private void addClient_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
