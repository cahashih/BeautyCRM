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

namespace LobovDiplom
{
    /// <summary>
    /// Логика взаимодействия для TimeOrder.xaml
    /// </summary>
    public partial class TimeOrder : Window
    {
        public TimeOrder()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window newwin = new OrderInfo();
            newwin.Show();
            this.Close();
        }
    }
}
