using NeonSignWPF.Entities;
using NeonSignWPF.Pages;
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
using System.Windows.Shapes;

namespace NeonSignWPF.Windows
{
    /// <summary>
    /// Логика взаимодействия для UserMenuWindow.xaml
    /// </summary>
    public partial class UserMenuWindow : Window
    {
        public UserMenuWindow()
        {
            InitializeComponent();
            UserFrame.Navigate(new UserOrdersPage());
        }

        private void LogOut_btn_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
