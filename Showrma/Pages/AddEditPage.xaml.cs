using Microsoft.Win32;
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
using Showrma.Model;

namespace Showrma.Pages
{
    /// <summary>
    /// Interaction logic for AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        ZakazShava contextemploy;
        public AddEditPage(ZakazShava shav)
        {
            InitializeComponent();
            TypeCB.ItemsSource = App.DB.Type.ToList();
            ColorCb.ItemsSource = App.DB.Color.ToList();
            contextemploy = shav;
            DataContext = contextemploy;
        }

        private void AddImageBt_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                contextemploy.Img = File.ReadAllBytes(dialog.FileName);
                DataContext = null;
                DataContext = contextemploy;
            }
        }

        private void MainClientBt_Click_1(object sender, RoutedEventArgs e)
        {
            var erormasage = "";
            if (LoginTb.Text == "")
            {
                erormasage += "Заполните логин \n";
            }
            if (PasswordTb.Text == "")
            {
                erormasage += "Заполните цену \n";
            }
            if (TypeCB.SelectedItem == null)
            {
                erormasage += "Выберите тип \n";
            }
            
            if (ColorCb.SelectedItem == null)
            {
                erormasage += "Выберите цвет \n";
            }
            if (erormasage == "")
            {

                if (contextemploy.Id == 0)
                {

                    App.DB.ZakazShava.Add(contextemploy);
                }
                App.DB.SaveChanges();

                NavigationService.Navigate(new HomePage());
            }
            else
            {
                MessageBox.Show(erormasage);
            }
        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            DataContext = null;
            NavigationService.Navigate(new HomePage());
        }

        private void PasswordTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void LoginTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}

