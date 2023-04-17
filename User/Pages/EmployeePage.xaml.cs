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

namespace User.Pages
{
    /// <summary>
    /// Interaction logic for EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        public EmployeePage()
        {
            InitializeComponent();

            LVEmployees.ItemsSource = App.DB.Employee.Where(x => x.IsDelete != false).ToList();

        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            if (string.IsNullOrWhiteSpace(TBSearch.Text))
            {
                LVEmployees.ItemsSource = App.DB.Employee.Where(x => x.IsDelete != false).ToList();
            }
            else
            {
                LVEmployees.ItemsSource =
                    App.DB.Employee.Where(x => x.IsDelete != false).Where(
                        a => a.Name.ToString().Contains(TBSearch.Text.ToLower())).ToList();
            }

        }

        private void BackBtn_OnClickBackBtn_OnClickBRemove_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HomePage());
        }
    }
}

