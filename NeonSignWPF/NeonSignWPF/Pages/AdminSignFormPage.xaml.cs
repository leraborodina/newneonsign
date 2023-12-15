using Microsoft.Win32;
using NeonSignWPF.Entities;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AdminSignFormPage.xaml
    /// </summary>
    public partial class AdminSignFormPage : Page
    {
        private byte[] img = null;
        public AdminSignFormPage()
        {
            InitializeComponent();
        }
        private void SelectImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog photo_img = new OpenFileDialog();
            photo_img.Multiselect = false;
            photo_img.Filter = "Image | *.png; *.jpg; *.jpeg";
            if (photo_img.ShowDialog() == true)
            {
                img = File.ReadAllBytes(photo_img.FileName);

                Image_photo.Source = new ImageSourceConverter().ConvertFrom(img) as ImageSource;
            }
        }

        private void ConfButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextSignForm.Text == "")
            {
                MessageBox.Show("Заполните пустые поля", "Пустые поля!", MessageBoxButton.OK);
            }
            else
            {

                SignForm form = new SignForm();
                form.form_name = TextSignForm.Text;
                form.form_img = img;

                AppData.db.SignForm.Add(form);
                AppData.db.SaveChanges();
                TextSignForm.Text = "";
                img = null;

                MessageBox.Show("Форма успешно добавлена", "Успешно!", MessageBoxButton.OK);
            }
        }

        private void Back_button(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
