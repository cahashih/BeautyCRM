using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    class ImagingService
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public ImagingService(string title, string description, decimal price, string imagePath)
        {
            Title = title;
            Description = description;
            Price = price;
            ImagePath = imagePath;
        }
    }
public partial class ViewService : Page
    {
        

        public ViewService(int category)
        {
            InitializeComponent();



            List<ImagingService> imagingServices = new List<ImagingService>();
            if(category == 1)
            {
                // Добавление услуг в список
                imagingServices.Add(new ImagingService("Стрижка женская", "Классическая женская стрижка", 500, "serviceone"));
                imagingServices.Add(new ImagingService("Стрижка мужская", "Классическая мужская стрижка", 400, "service (2)"));
                imagingServices.Add(new ImagingService("Стрижка детская", "Стрижка для детей до 12 лет", 300, "service (3)"));
                imagingServices.Add(new ImagingService("Стрижка под машинку", "Стрижка волос под машинку", 200, "service (4)"));
                imagingServices.Add(new ImagingService("Стрижка каре", "Стрижка волос в стиле каре", 600, "service (5)"));
                imagingServices.Add(new ImagingService("Стрижка боб", "Стрижка волос в стиле боб", 550, "service (66)"));
                imagingServices.Add(new ImagingService("Стрижка градуированная", "Стрижка волос с градуированными каскадами", 700, "service (6)"));
                imagingServices.Add(new ImagingService("Стрижка лесенка", "Стрижка волос по типу лесенки", 650, "service (7)"));
                imagingServices.Add(new ImagingService("Стрижка французская", "Стрижка волос в стиле французской косы", 550, "service (8)"));
                imagingServices.Add(new ImagingService("Стрижка и окрашивание", "Стрижка волос и окрашивание", 800, "service (9)"));
                imagingServices.Add(new ImagingService("Стрижка и укладка", "Стрижка волос и укладка прически", 750, "service (10)"));
                imagingServices.Add(new ImagingService("Стрижка и плетение", "Стрижка волос и плетение кос", 700, "service (11)"));
                imagingServices.Add(new ImagingService("Стрижка горячими ножницами", "Стрижка волос с использованием горячих ножниц", 900, "service (12)"));
                imagingServices.Add(new ImagingService("Стрижка машинкой с насадками", "Стрижка волос с использованием машинки и различных насадок", 400, "service (3)"));
                imagingServices.Add(new ImagingService("Стрижка и выпрямление", "Стрижка волос и выпрямление прядей", 850, "service (3)"));
                imagingServices.Add(new ImagingService("Стрижка и завивка", "Стрижка волос и создание завитков", 800, "service (3)"));
                imagingServices.Add(new ImagingService("Стрижка и барберинг", "Стрижка волос и выполнение барберских процедур", 1000, "service (3)"));
                imagingServices.Add(new ImagingService("Стрижка и омбре", "Стрижка волос и окрашивание в стиле омбре", 950, "service (3)"));
                imagingServices.Add(new ImagingService("Стрижка и мелирование", "Стрижка волос и нанесение мелирования", 900, "service (3)"));
                imagingServices.Add(new ImagingService("Стрижка и тонирование", "Стрижка волос и тонирование прядей", 850, "service (3)"));

            }
            else if(category == 4)
            {
                imagingServices.Add(new ImagingService("Омолаживающая процедура лица", "Устранение морщин и повышение упругости кожи", 1500, "imaging (1)"));
                imagingServices.Add(new ImagingService("Чистка лица", "Очищение пор и удаление комедонов", 800, "imaging (2)"));
                imagingServices.Add(new ImagingService("Очищение кожи", "Удаление нежелательных дефектов", 2000, "imaging (3)"));
                imagingServices.Add(new ImagingService("Ультразвуковая чистка лица", "Очищение пор с помощью ультразвука", 900, "imaging (6)"));
                imagingServices.Add(new ImagingService("Пилинг лица", "Удаление ороговевших клеток и выравнивание тонуса кожи", 1200, "imaging (6)"));
                imagingServices.Add(new ImagingService("Микродермабразия", "Полировка верхнего слоя кожи для улучшения текстуры", 100, "imaging (6)"));


            }
            else if (category == 2)
            {
                imagingServices.Add(new ImagingService("Релаксационный массаж тела", "Глубокий массаж всего тела для расслабления и снятия напряжения.", 500, "spa (1)"));
                imagingServices.Add(new ImagingService("Ароматерапия", "Процедура, включающая использование эфирных масел для достижения расслабления и гармонии.", 1000, "spa (2)"));
                imagingServices.Add(new ImagingService("СПА-педикюр", "Комплексные процедуры для ухода за стопами и ногтями, включающие массаж и оздоровительные процедуры.", 400, "spa (3)"));
                imagingServices.Add(new ImagingService("Гидромассаж", "Массаж с использованием водных струй для расслабления и улучшения кровообращения.", 300, "spa (4)"));
                imagingServices.Add(new ImagingService("СПА-комплекс", "Полный комплекс процедур, включающий массаж, банные ритуалы, ароматерапию и другие методы релаксации и оздоровления.", 1500, "spa (5)"));


            }
            else if (category == 3)
            {
                imagingServices.Add(new ImagingService("Шугаринг", "Метод удаления нежелательных волос с использованием сахарной пасты.", 500, "epil (1)"));
                imagingServices.Add(new ImagingService("Восковая эпиляция", "Метод удаления волос с использованием воска.", 700, "epil (1)"));
                imagingServices.Add(new ImagingService("Лазерная эпиляция", "Метод удаления волос с использованием лазерного излучения.", 900, "epil"));
                imagingServices.Add(new ImagingService("Электроэпиляция", "Метод удаления волос с использованием электрического тока.", 800, "epil (2)"));
                imagingServices.Add(new ImagingService("Интимная эпиляция", "Метод удаления волос в интимной зоне.", 2000, "epil (1)"));

            }


            foreach (var service in imagingServices)
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
                string imagePath = $"pack://application:,,,/Resource/{service.ImagePath}.jpg";

                // Создание объекта BitmapImage
                BitmapImage bitmapImage = new BitmapImage(new Uri(imagePath));

                // Установка источника изображения для Image
                image.Source = bitmapImage;
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
                    Text = $"{service.Title}",
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
                    Text = service.Description,
                    Margin = new Thickness(10, 5, 0, 0)
                };
                Grid.SetRow(descriptionTextBlock, 1);
                nestedGrid.Children.Add(descriptionTextBlock);

                // Создание TextBlock для цены услуги
                var priceTextBlock = new TextBlock
                {
                    Text = $"{service.Price} руб.",
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
                    HorizontalAlignment = HorizontalAlignment.Right,
                    Style = (Style)FindResource("SignUpButtonStyle"),
                    
                    

                };
                button.Click += Button_Click;
                Grid.SetRow(button, 2);
                nestedGrid.Children.Add(button);

                // Добавление Border на страницу
                myGrid.Children.Add(border);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window order = new TimeOrder();
            order.Show();
        }
    }
}
