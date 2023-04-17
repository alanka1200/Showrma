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

namespace Cooker.Pages
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            var allTypes = App.DB.Type.ToList();
            allTypes.Insert(0, new Model.Type
            {
                Name = "Все"
            });
            ViewCb.ItemsSource = allTypes;
            var allColor = App.DB.Color.ToList();
            allColor.Insert(0, new Model.Color
            {
                Name = "Все"
            });
            ColoreCb.ItemsSource = allColor;
            if (App.LoginigUsers.RoleId == 1)
            {
                AddPenBt.Visibility = Visibility.Collapsed;
                EditPenBt.Visibility = Visibility.Collapsed;
                DellBt.Visibility = Visibility.Collapsed;
            }

            LvAccept.ItemsSource = App.DB.ZakazShava.Where(x => x.IsDelete != true).ToList();
        }

        private void EditPenBt_Click(object sender, RoutedEventArgs e)
        {
            var selectedclient = LvAccept.SelectedItem as ZakazShava;
            if (selectedclient == null)
            {
                MessageBox.Show("Выберете блюдо");
                return;
            }

            NavigationService.Navigate(new AddEditPage(selectedclient));
        }

        private void AddPenBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditPage(new ZakazShava()));
        }

        private void ProfilBt_Click(object sender, RoutedEventArgs e)
        {
            App.LoginigUsers = null;
            NavigationService.Navigate(new AutorizatPages());
        }

        private void SelectedTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refreh();
        }

        private void DellBt_Click_1(object sender, RoutedEventArgs e)
        {
            var selectedclient = LvAccept.SelectedItem as ZakazShava;
            if (selectedclient == null)
            {
                MessageBox.Show("Выберете блюдо");
                return;
            }

            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Уведомление", MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                selectedclient.IsDelete = true;
                App.DB.SaveChanges();
                NavigationService.Navigate(new HomePage());
            }

        }

        private void Refreh()
        {
            IEnumerable<ZakazShava> filterService = App.DB.ZakazShava.Where(x => x.IsDelete != true).ToList();
            if (ColoreCb.SelectedIndex > 0)
            {
                filterService = filterService.Where(x => x.ColorId == ColoreCb.SelectedIndex).ToList();
            }
            if (SelectedTb.Text.Length > 0)
            {
                filterService = filterService.Where(a => a.Name.ToLower().Contains(SelectedTb.Text.ToLower())).ToList();
            }
            LvAccept.ItemsSource = filterService.ToList();

        }

        private void TypeCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refreh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refreh();
        }

        private void AboutBTN_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AboutPage());
        }

        private void ZakazBtn_OnClickAddPenBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CartPage());
        }
    }
}

