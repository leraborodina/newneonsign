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
    /// Логика взаимодействия для AdminMenuPage.xaml
    /// </summary>
    public partial class AdminMenuPage : Page
    {
        public AdminMenuPage()
        {
            InitializeComponent();
        }

        private void Users_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminUsersTable());
        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminOrdersTablePage());
        }

        private void Roles_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminRolesTablePage());
        }

        private void SignForm_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminSignFormPage());
        }
    }
}
