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
            var allSigns = AppData.db.SignForm.ToList();

            allSigns.Insert(0, new SignForm
            {
                form_name = "Все формы"
            });

            CMBForm.ItemsSource = allSigns;
            CMBForm.SelectedIndex = 0;
        }

        private void UpdateOrders()
        {
            //int userId = App.IdUser;
            //var currentOrder = AppData.db.Orders.Where(u => u.id_user == userId).ToList();

            //if (CMBForm.SelectedIndex > 0)
            //{
            //    // Получаем выбранную форму из ComboBox
            //    var selectedForm = CMBForm.SelectedItem as SignForm;

            //    // Фильтруем заказы на основе выбранной формы
            //    currentOrder = currentOrder.Where(o => o.SignForm.form_name.Contains(selectedForm.form_name)).ToList();
            //    currentOrder = currentOrder.Where(o => o.NeonColor.color.ToLower().Contains(selectedForm.form_name.ToLower())).ToList();
            //    OrdersListView.ItemsSource = currentOrder;
            //}

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

        private void TextSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
           // UpdateOrders();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //UpdateOrders();
        }
    }
}
