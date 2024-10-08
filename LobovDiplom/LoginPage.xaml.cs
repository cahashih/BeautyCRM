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

namespace LobovDiplom
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginForm_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LoginForm.Text == "" && !LoginForm.Focusable)
            {
                LoginText.Visibility = Visibility.Visible;
            }
            else
            {
                LoginText.Visibility = Visibility.Hidden;
            }
        }

        private void PasswordForm_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PasswordForm.Password == "")
            {
                PasswordText.Visibility = Visibility.Visible;
            }
            else
            {
                PasswordText.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.AuthFrame.Navigate(new Register());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            Window.GetWindow(this).Close();
        }
    }
}
