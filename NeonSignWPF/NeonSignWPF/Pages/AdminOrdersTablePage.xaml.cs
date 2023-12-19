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
    /// Логика взаимодействия для AdminOrdersTablePage.xaml
    /// </summary>
    public partial class AdminOrdersTablePage : Page
    {
        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            OrdersListView.ItemsSource = AppData.db.Orders.ToList();
        }
        public AdminOrdersTablePage()
        {
            InitializeComponent();
        }

        private void DeleteOrder(object sender, RoutedEventArgs e)
        {
            var CurrentOrder = OrdersListView.SelectedItem as Orders;
            if (CurrentOrder == null)
            {
                MessageBox.Show("Выберите заказ для удаления", "Внимание!", MessageBoxButton.OK);
            }
            else if (MessageBox.Show("Вы действительно хотите удалить заказ?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                AppData.db.Orders.Remove(CurrentOrder);
                AppData.db.SaveChanges();
                OrdersListView.ItemsSource = AppData.db.Orders.ToList();
                MessageBox.Show("Заказ успешно удален", "Успешно!", MessageBoxButton.OK);
                
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
