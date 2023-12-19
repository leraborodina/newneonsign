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
    /// Логика взаимодействия для AdminRolesTablePage.xaml
    /// </summary>
    public partial class AdminRolesTablePage : Page
    {
        public AdminRolesTablePage()
        {
            InitializeComponent();
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            RolesListView.ItemsSource = AppData.db.Roles.ToList();
        }

        private void AddRoleButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddRolePage());
        }

        private void DeleteRoleButton_Click(object sender, RoutedEventArgs e)
        {
            var CurrentRole = RolesListView.SelectedItem as Roles;
            if(CurrentRole == null)
            {
                MessageBox.Show("Выберите роль для удаления", "Внимание!", MessageBoxButton.OK);
            } else if (MessageBox.Show("Вы действительно хотите удалить роль?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                bool hasRelatedRecords = CheckForRelatedRecords(CurrentRole);
                if (hasRelatedRecords)
                {
                    MessageBox.Show("Невозможно удалить пользователя из-за привязки к другой таблице", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    AppData.db.Roles.Remove(CurrentRole);
                    AppData.db.SaveChanges();
                    RolesListView.ItemsSource = AppData.db.Roles.ToList();
                    MessageBox.Show("Роль успешно удалена", "Успешно!", MessageBoxButton.OK);
                }
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private bool CheckForRelatedRecords(Roles role)//поиск привязки пользователя к таблице Users
        {
            bool hasRelatedRecords = AppData.db.Users.Any(u => u.id_role == role.id_role);
            return hasRelatedRecords;
        }
    }
}
