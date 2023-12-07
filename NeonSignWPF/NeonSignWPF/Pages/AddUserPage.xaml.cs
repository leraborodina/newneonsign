using NeonSignWPF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Linq;
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
namespace NeonSignWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        Users user = new Users();
        public AddUserPage()
        {
            InitializeComponent();
            SelectRoleComboBox.ItemsSource = AppData.db.Roles.ToList();
        }

        private void Conf_Button_Click(object sender, RoutedEventArgs e)
        {
            if (SelectRoleComboBox.SelectedItem == null || TextLogin.Text == "" || TextPassword.Password == "")
            {
                MessageBox.Show("Заполните пустые поля", "Пустые поля!", MessageBoxButton.OK);
            }
            else if (!CheckPass())
            {
                MessageBox.Show("Пароль должен содержать не менее 5 символов", "Измените пароль!");
            }
            else if (AppData.db.Users.Count(u => u.login == TextLogin.Text) > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует.\nПридумайте новый", "", MessageBoxButton.OK);
            }
            else
            {
                user.login = TextLogin.Text;
                user.password = TextPassword.Password;
                var CurrentRole = SelectRoleComboBox.SelectedItem as Roles;
                user.id_role = CurrentRole.id_role;

                AppData.db.Users.Add(user);
                AppData.db.SaveChanges();
                TextLogin.Text = "";
                TextPassword.Password = "";
                SelectRoleComboBox = null;
                TextLogin.Focus();
                MessageBox.Show("Пользователь успешно сохранен!");

            }
        }

        public Boolean CheckPass()
        {
            string password = TextPassword.Password;
            if(password.Length >= 5)
            {
                return true;
            } else 
            { 
                return false; 
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
