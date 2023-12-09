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
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        Context db = new Context();
        public AddClient()
        {
            InitializeComponent();
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RegistrationClick(object sender, RoutedEventArgs e)
        {
            User user = new User(firstName.Text, lastName.Text, middleName.Text, passport.Text);
            db.Users.Add(user);
            db.SaveChanges();

            MessageBox.Show("Успешное добавление пользователя!");

            this.Close();
        }
    }
}
