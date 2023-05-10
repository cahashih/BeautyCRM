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

namespace LobovDiplom
{
    /// <summary>
    /// Логика взаимодействия для ViewService.xaml
    /// </summary>
    public partial class ViewService : Page
    {
        public ViewService()
        {
            InitializeComponent();
            for(int i = 0; i < 10; i++)
            {
                // Создание Border
                var border = new Border
                {
                    BorderBrush = Brushes.Black,
                    BorderThickness = new Thickness(1),
                    CornerRadius = new CornerRadius(5),
                    Padding = new Thickness(5),
                };

                // Создание Grid
                var grid = new Grid();
                border.Child = grid;

                // Определение колонок Grid
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                // Создание Image
                var image = new Image
                {
                    Width = 100,
                    Height = 100
                };
                Grid.SetColumn(image, 0);
                grid.Children.Add(image);

                // Создание Grid внутри Grid
                var nestedGrid = new Grid();
                Grid.SetColumn(nestedGrid, 1);
                grid.Children.Add(nestedGrid);

                // Определение строк Grid
                nestedGrid.RowDefinitions.Add(new RowDefinition());
                nestedGrid.RowDefinitions.Add(new RowDefinition());
                nestedGrid.RowDefinitions.Add(new RowDefinition());

                // Создание TextBlock для названия услуги
                var titleTextBlock = new TextBlock
                {
                    Text = $"Название услуги{i}",
                    FontSize = 20,
                    FontWeight = FontWeights.Bold,
                    Margin = new Thickness(10, 0, 0, 0)
                };
                Grid.SetRow(titleTextBlock, 0);
                nestedGrid.Children.Add(titleTextBlock);

                // Создание TextBlock для описания услуги
                var descriptionTextBlock = new TextBlock
                {
                    TextWrapping = TextWrapping.Wrap,
                    Text = "Описание услуги",
                    Margin = new Thickness(10, 5, 0, 0)
                };
                Grid.SetRow(descriptionTextBlock, 1);
                nestedGrid.Children.Add(descriptionTextBlock);

                // Создание TextBlock для цены услуги
                var priceTextBlock = new TextBlock
                {
                    Text = $"{1000+ 1000*i} руб.",
                    FontSize = 18,
                    FontWeight = FontWeights.Bold,
                    Margin = new Thickness(10, 5, 0, 0),
                    HorizontalAlignment = HorizontalAlignment.Right,
                    VerticalAlignment = VerticalAlignment.Center
                };
                Grid.SetRow(priceTextBlock, 0);
                nestedGrid.Children.Add(priceTextBlock);

                // Создание Button
                var button = new Button
                {
                    Content = "Записаться",
                    HorizontalAlignment = HorizontalAlignment.Right
                };
                Grid.SetRow(button, 2);
                nestedGrid.Children.Add(button);

                // Добавление Border на страницу
                myGrid.Children.Add(border);
            }
        }
    }
}
