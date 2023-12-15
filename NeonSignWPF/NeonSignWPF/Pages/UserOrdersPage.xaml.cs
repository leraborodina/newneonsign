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
    /// Логика взаимодействия для UserOrdersPage.xaml
    /// </summary>
    public partial class UserOrdersPage : Page
    {
        public UserOrdersPage()
        {
            InitializeComponent();
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            int userId = App.IdUser;
            OrdersListView.ItemsSource = AppData.db.Orders.Where(u => u.id_user == userId).ToList();
        }

        private void AddOrderButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditOrderPage(null));
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditOrderPage((sender as Button).DataContext as Orders));
        }
    }
}
