using Library;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml;
using System.Linq;

namespace IndividualProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool b1 = true;
        private bool b2 = true;
        private bool b3 = true;
        private bool b4 = true;

        private List<ICoffee> coffeeList = new List<ICoffee>();
        private List<ICoffee> choice = new List<ICoffee>();
        СompositionWindow composition;
        Table tables;
        public MainWindow()
        {
            InitializeComponent();
            GetInfo();
            CoffeeDataGrid.ItemsSource = coffeeList;
            
        }

        private void GetInfo() //Загрузка кофе из файла.
        {
            try
            {
                String a;
                String[] b;
                String[] str = File.ReadAllLines("../../Types.TXT");
                for (int i = 0; i < str.Length; i++)
                {
                    a = str[i];
                    b = a.Split(',');
                    if (b.Length != 2)
                    {
                        throw new Exception("Ошибка данных");
                    }
                    TypesOfCoffee cof = new TypesOfCoffee();
                    cof.Name = b[0];
                    cof.Price = int.Parse(b[1]);
                    coffeeList.Add(cof);
                }

                coffeeList = (from k in coffeeList orderby k.Name select k).ToList(); //Cортировка по алфавиту с помощью Linq.
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка данных");
                return;
            }
        }

        private void Add(object sender, RoutedEventArgs e) //Добавляет выбранный пользователем кофе в заказ.
        {
            int k = CoffeeDataGrid.SelectedIndex;

            if (k < 0)
            {
                MessageBox.Show("Вы еще ничего не выбрали");
                return;
            }

            choice.Add(coffeeList[k]);
            YourChoice.Items.Add("Кофе: " + coffeeList[k].Name.ToString() + " , Цена: " + coffeeList[k].Price.ToString());
        }

        private void Delete(object sender, RoutedEventArgs e) //Удаляет выбранный пользователем кофе из заказа.
        {
            int k = YourChoice.SelectedIndex;

            if (k < 0)
            {
                MessageBox.Show("Вы еще ничего не выбрали");
                return;
            }
            choice.RemoveAt(k);
            YourChoice.Items.RemoveAt(k);
        }

        private void Order(object sender, RoutedEventArgs e) //Считает цену за заказ.
        {
            int k = 0;

            for (int i = 0; i < choice.Count; i++)
            {
                k += choice[i].Price;
            }

            if (k == 0)
            {
                MessageBox.Show("Вы ничего не выбрали");
                return;
            }

            MessageBox.Show("С Вас " + k + " рублей.\n\n" + "Спасибо за заказ.\n\n" + "Хорошего дня!");
            return;
        }

        private void Information(object sender, RoutedEventArgs e) //Показывает состав кофе из заказа картинкой.
        {

            int g = CoffeeDataGrid.SelectedIndex;

            if (g < 0)
            {
                MessageBox.Show("Вы еще ничего не выбрали");
                return;
            }

            string n = coffeeList[CoffeeDataGrid.SelectedIndex].Name;
            string k = null;

            switch (n)
            {
                case "Эспрессо":
                    k = "Pictures/Эспрессо.png";
                    break;
                case "Доппио":
                    k = "Pictures/Доппио.png";
                    break;
                case "Триппло":
                    k = "Pictures/Триппло.png";
                    break;
                case "Ристретто":
                    k = "Pictures/Ристретто.png";
                    break;
                case "Лунго":
                    k = "Pictures/Лунго.png";
                    break;
                case "Американо":
                    k = "Pictures/Американо.png";
                    break;
                case "Флэт Вайт":
                    k = "Pictures/Флэт Вайт.png";
                    break;
                case "Каппучино":
                    k = "Pictures/Каппучино.png";
                    break;
                case "Маккиато":
                    k = "Pictures/Маккиато.png";
                    break;
                case "Латте":
                    k = "Pictures/Латте.png";
                    break;
                case "Кон панна":
                    k = "Pictures/Кон панна.png";
                    break;
                case "Бреве":
                    k = "Pictures/Бреве.png";
                    break;
                case "Кофе по венски":
                    k = "Pictures/Кофе по венски.png";
                    break;
                case "Латте макиато":
                    k = "Pictures/Латте макиато.png";
                    break;
                case "Фредо":
                    k = "Pictures/Фредо.png";
                    break;
                case "Айриш":
                    k = "Pictures/Айриш.png";
                    break;
                case "Коретто":
                    k = "Pictures/Коретто.png";
                    break;
                case "Раф кофе":
                    k = "Pictures/Раф кофе.png";
                    break;
                case "Романо":
                    k = "Pictures/Романо.png";
                    break;
                case "Медовый раф":
                    k = "Pictures/Медовый раф.png";
                    break;
                case "Гляссе":
                    k = "Pictures/Гляссе.png";
                    break;
                case "Мокко":
                    k = "Pictures/Мокко.png";
                    break;
                case "Марочино":
                    k = "Pictures/Марочино.png";
                    break;
                case "Бичерин":
                    k = "Pictures/Бичерин.png";
                    break;
                default:
                    break;

            };
            
            composition = new СompositionWindow(k);
            composition.Show();
        }

        private void Table(object sender, RoutedEventArgs e) //Бронирование столика.
        {
            tables = new Table(b1,b2,b3,b4);
            tables.ShowDialog();
            b1 = tables.tableone;
            b2 = tables.tabletwo;
            b3 = tables.tablethree;
            b4 = tables.tablefour;
        }
    }
}
