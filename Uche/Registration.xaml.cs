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

namespace Uche
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click_Add1(object sender, RoutedEventArgs e)
        {
           using (ChatEntities registration = new ChatEntities())
            {
                User users = new User();
                users.Login = Log.Text;
                users.Password = Pass.Password;
                users.RoleID = 3;

                registration.User.Add(users);
                registration.SaveChanges();
                MessageBox.Show("Вы зарегистрировались, сейчас вас перекинут на страницу входа");
                MainWindow.frame.Content = new login();
            }
        }

        private void Tname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {

        }
    }
}
