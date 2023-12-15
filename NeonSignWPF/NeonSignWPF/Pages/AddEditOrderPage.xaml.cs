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
    /// Логика взаимодействия для AddEditOrderPage.xaml
    /// </summary>
    public partial class AddEditOrderPage : Page
    {

        Orders order = new Orders();

        public AddEditOrderPage(Orders selectedOrder)
        {
            InitializeComponent();
            if (selectedOrder != null)
            {
                order = selectedOrder;
            }
            DataContext = order;
            SelectNeonTypeCMB.ItemsSource = AppData.db.NeonType.ToList();
            SelectFormCMB.ItemsSource = AppData.db.SignForm.ToList();
            SelectColorCMB.ItemsSource = AppData.db.NeonColor.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void AddEditButton(object sender, RoutedEventArgs e)
        {
            if (SelectNeonTypeCMB.SelectedItem == null || SelectColorCMB.SelectedItem == null || SelectFormCMB.SelectedItem == null)
            {
                MessageBox.Show("Заполните пустые поля", "Уведомление", MessageBoxButton.OK);
            }
            else
            {
                int userId = App.IdUser;
                order.id_user = userId;
                var CurrentForm = SelectFormCMB.SelectedItem as SignForm;
                order.id_form = CurrentForm.id_form;

                var CurrentNeonType = SelectNeonTypeCMB.SelectedItem as NeonType;
                order.id_neon_type = CurrentNeonType.id_neon_type;

                var CurrentColor = SelectColorCMB.SelectedItem as NeonColor;
                order.id_color = CurrentColor.id_color;
                if(order.id_order == 0)
                {
                    AppData.db.Orders.Add(order);
                }

                try
                {
                    AppData.db.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены!");
                    NavigationService.GoBack();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
