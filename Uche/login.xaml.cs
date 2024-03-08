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
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            var userlogi = Appconnect.baza.User.FirstOrDefault(x => x.Login == Log.Text && x.Password == Pass.Password);

            if(userlogi == null)
            {
                MessageBox.Show("Erro, please rite Login and Passsword");
            }
            else
            {
                switch(userlogi.RoleID)
                {
                    case 1:
                        MessageBox.Show("Hello"+" "+userlogi.Login);
                        MainWindow.frame.Content = new MainPage();
                        break;

                    case 2:
                        MessageBox.Show("Hello" + " " + userlogi.Login);
                     //   MainWindow.frame.Content = new MainPage();
                        break;

                    case 3:
                        MessageBox.Show("Hello" + " " + userlogi.Login);
                        MainWindow.frame.Content = new UsersPage();
                        break;
                }
            }
        }

        private void Button_Click_Add1(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Content = new Registration();
        }

        private void Tname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
