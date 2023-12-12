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
    /// Логика взаимодействия для AddRolePage.xaml
    /// </summary>
    public partial class AddRolePage : Page
    {
        Roles roles = new Roles();
        public AddRolePage()
        {
            InitializeComponent();
        }

        private void Conf_Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (TextRole.Text == "")
                errors.AppendLine("Заполните пустое поле");
            if (AppData.db.Roles.Count(u => u.role == TextRole.Text) > 0)
                errors.AppendLine("Такая роль уже существует");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else
            {
                roles.role = TextRole.Text;
                AppData.db.Roles.Add(roles);
                AppData.db.SaveChanges();
                TextRole.Text = "";
                MessageBox.Show("Роль успешно сохранена");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
