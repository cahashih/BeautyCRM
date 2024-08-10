using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace LobovDiplom
{
    /// <summary>
    /// Логика взаимодействия для OrderInfo.xaml
    /// </summary>
    /// 

    public class PhoneNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Преобразование входящего значения номера телефона в маску "+7(___)___-__-__"
            string phoneNumber = value as string;
            if (!string.IsNullOrEmpty(phoneNumber) && phoneNumber.Length == 11)
            {
                return $"+7({phoneNumber.Substring(1, 3)}){phoneNumber.Substring(4, 3)}-{phoneNumber.Substring(7, 2)}-{phoneNumber.Substring(9, 2)}";
            }
            return phoneNumber;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Удаление форматирования маски и преобразование обратно в строку номера телефона
            string formattedPhoneNumber = value as string;
            if (!string.IsNullOrEmpty(formattedPhoneNumber))
            {
                string plainNumber = Regex.Replace(formattedPhoneNumber, @"[^0-9]", "");
                return plainNumber;
            }
            return formattedPhoneNumber;
        }
    }
    public partial class OrderInfo : Window
    {
        public OrderInfo()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (LoginForm1.Text == "" && !LoginForm1.Focusable)
            {
                LFPText.Visibility = Visibility.Visible;
            }
            else
            {
                LFPText.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Запись успешно оформлена");
            this.Close();
        }
    }
}
