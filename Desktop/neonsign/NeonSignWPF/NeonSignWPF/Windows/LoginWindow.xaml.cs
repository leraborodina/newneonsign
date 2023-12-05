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
using System.Windows.Shapes;

namespace NeonSignWPF.Windows
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUserAdmin = AppData.db.Users.FirstOrDefault(u => u.login == login_txt.Text && u.password == password_txt.Password && u.id_role == 1);
            var CurrentUser = AppData.db.Users.FirstOrDefault(u => u.login == login_txt.Text && u.password == password_txt.Password && u.id_role == 2);

            if(CurrentUserAdmin != null)//если админ - главное окно со страницей админа
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            } else if (CurrentUser != null)//если пользователь - окно меню со страницей пользователя
            {
                UserMenuWindow userMenuWindow = new UserMenuWindow();
                userMenuWindow.Show();
                this.Close();
            } else if (login_txt.Text == "" || password_txt.Password == "")
            {
                MessageBox.Show("Заполните все пустые поля", "Пустые поля!");
            } else
            {
                MessageBox.Show("Аккаунта с таким логином или паролем не существует!", "", MessageBoxButton.OK);
                login_txt.Clear();
                password_txt.Clear();
                login_txt.Focus();    
                
            }        
        }

        private void Loginpage_close_button_click(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
