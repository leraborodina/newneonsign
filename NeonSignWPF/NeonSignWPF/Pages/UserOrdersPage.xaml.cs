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
            int userId = App.IdUser;
            var currentOrders = AppData.db.Orders.Where(o => o.id_user == userId).ToList();
        }

        private void UpdateOrders()
        {
            // Получаем заказы для текущего пользователя
            int userId = App.IdUser;
            var currentOrders = AppData.db.Orders.Where(o => o.id_user == userId).ToList();

            if (CMBForm.SelectedIndex > 0)
            {
                var selectedForm = CMBForm.SelectedItem as SignForm;
                currentOrders = currentOrders.Where(o => o.SignForm.form_name == selectedForm.form_name).ToList();
            }

            string searchText = Txt_search.Text.Trim().ToLower();
            currentOrders = currentOrders.Where(o =>
                o.NeonColor.color.ToLower().Contains(searchText) ||
                o.NeonType.type.ToLower().Contains(searchText)).ToList();
            OrdersListView.ItemsSource = currentOrders;
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            int userId = App.IdUser;
            OrdersListView.ItemsSource = AppData.db.Orders.Where(u => u.id_user == userId).ToList();
            var allForms = AppData.db.SignForm.OrderBy(f => f.form_name).ToList();

            // Добавляем "Все формы" в начало списка
            allForms.Insert(0, new SignForm { form_name = "Все формы" });

            // Заполняем ComboBox формами
            CMBForm.ItemsSource = allForms;
            CMBForm.DisplayMemberPath = "form_name"; // Указываем свойство для отображения в ComboBox
            CMBForm.SelectedIndex = 0;
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
           UpdateOrders();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateOrders();
        }
    }
}
