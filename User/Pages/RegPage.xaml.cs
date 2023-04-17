using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        Model.User contextemloy;
        public RegPage(Model.User user)
        {
            InitializeComponent();
            contextemloy = user;
            DataContext = contextemloy;
        }
        private void RegBt_Click(object sender, RoutedEventArgs e)
        {
            var erormasage = "";
            if (LoginTb.Text.Trim() == "")
            {
                erormasage += "Заполните логин \n";
            }
            if (PasswordTb.Text.Trim() == "")
            {
                erormasage += "Заполните Пароль \n";
            }
            if (NameTb.Text.Trim() == "")
            {
                erormasage += "Заполните имя \n";
            }

            if (App.DB.User.FirstOrDefault(x => x.Login == LoginTb.Text) != null)
            {
                erormasage += "Такой пользователь уже есть \n";
            }
            if (erormasage == " ")
            {

                contextemloy.RoleId = 1;

                App.DB.User.Add(contextemloy);

                App.DB.SaveChanges();

                NavigationService.Navigate(new LoginPage());


            }
            else
            {
                MessageBox.Show(erormasage);
            }
        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }

        private void NameTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Regex.IsMatch(e.Text, @"[А-я]") == false)
            {
                e.Handled = true;
            }
        }

        private void LoginTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Regex.IsMatch(e.Text, @"[A-z0-9]") == false)
            {
                e.Handled = true;
            }
        }

        private void PhoneTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Regex.IsMatch(e.Text, @"[0-9]") == false)
            {
                e.Handled = true;
            }
        }
    }
}

