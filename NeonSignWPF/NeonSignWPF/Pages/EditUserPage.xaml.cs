using NeonSignWPF.Entities;
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

namespace NeonSignWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditUserPage.xaml
    /// </summary>
    public partial class EditUserPage : Page
    {
        Users user = new Users();
        public EditUserPage(Users selectedUser)
        {
            InitializeComponent();
            if(selectedUser != null )
            {
                user = selectedUser;
            }
            DataContext = user;
            user = selectedUser;
            SelectRoleComboBox.ItemsSource = AppData.db.Roles.ToList();
            TextLogin.Text = user.login;
            TextPassword.Password = user.password;
        }

        private void Conf_Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (SelectRoleComboBox.SelectedItem == null || TextLogin.Text == "" || TextPassword.Password == "")
                errors.AppendLine("Заполните пустые поля");
            if (TextPassword.Password.Length < 5)
                errors.AppendLine("Пароль должен содержать не менее 5 символов");
            if (AppData.db.Users.Count(u => u.login == TextLogin.Text && u.id_user != user.id_user) > 0)
                errors.AppendLine("Пользователь с таким логином уже существует.");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else
            {
                user.login = TextLogin.Text;
                user.password = TextPassword.Password;
                var CurrentRole = SelectRoleComboBox.SelectedItem as Roles;
                user.id_role = CurrentRole.id_role;
                AppData.db.SaveChanges();
                MessageBox.Show("Все изменения сохранены!");
                NavigationService.GoBack();
            }
        }
    }
}
