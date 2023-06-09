﻿using System;
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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Login != null && Properties.Settings.Default.Password != null)
            {
                LoginTb.Text = Properties.Settings.Default.Login;
                PasswordTb.Password = Properties.Settings.Default.Password;
            }
        }

        private void AutorBt_Click(object sender, RoutedEventArgs e)
        {
            var employee = App.DB.User.FirstOrDefault(emp => emp.Login == LoginTb.Text);
            if (employee == null)
            {
                MessageBox.Show("Логин неверный");
                return;
            }

            if (employee.Password != PasswordTb.Password)
            {
                MessageBox.Show("Пароль неверный");
                return;
            }

            App.LoginigUsers = employee;

            if (employee.RoleId == 1)
            {
                if (SaveCb.IsChecked == true)
                {
                    Properties.Settings.Default.Login = LoginTb.Text;
                    Properties.Settings.Default.Password = employee.Password;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Login = null;
                    Properties.Settings.Default.Password = null;
                    Properties.Settings.Default.Save();
                }

                NavigationService.Navigate(new HomePage());
            }

            if (employee.RoleId == 2)
            {
                if (SaveCb.IsChecked == true)
                {
                    Properties.Settings.Default.Login = LoginTb.Text;
                    Properties.Settings.Default.Password = employee.Password;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Login = null;
                    Properties.Settings.Default.Password = null;
                    Properties.Settings.Default.Save();
                }

                NavigationService.Navigate(new HomePage());
            }

        }

        private void RegBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage(new Model.User()));
        }
    }
}
