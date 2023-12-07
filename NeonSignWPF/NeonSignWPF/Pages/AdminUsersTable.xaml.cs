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
    /// Логика взаимодействия для AdminUsersTable.xaml
    /// </summary>
    public partial class AdminUsersTable : Page
    {
        Users users = new Users();
        public AdminUsersTable()
        {
            InitializeComponent();
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            UsersListView.ItemsSource = AppData.db.Users.ToList();
        }
        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new AddUserPage()); 
        }

        private void EditUserButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = UsersListView.SelectedItem as Users;
            bool hasRelatedRecords = CheckForRelatedRecords(CurrentUser);
            if (hasRelatedRecords)
            {
                MessageBox.Show("Невозможно удалить пользователя из-за привязки к другой таблице", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                AppData.db.Users.Remove(CurrentUser);
                AppData.db.SaveChanges();
                UsersListView.ItemsSource = AppData.db.Users.ToList();
                MessageBox.Show("Пользователь успешно удален", "Успешно!", MessageBoxButton.OK);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private bool CheckForRelatedRecords(Users users)//поиск привязки пользователя к другой таблице(в данном случае Orders)
        {
            bool hasRelatedRecords = AppData.db.Orders.Any(u => u.id_user == users.id_user);
            return hasRelatedRecords;
        }
    }
}
