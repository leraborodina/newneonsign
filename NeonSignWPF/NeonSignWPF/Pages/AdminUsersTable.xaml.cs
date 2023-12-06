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

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
