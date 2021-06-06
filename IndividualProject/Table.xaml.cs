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

namespace IndividualProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Table : Window
    {
        public bool tableone = true;
        public bool tabletwo = true;
        public bool tablethree = true;
        public bool tablefour = true;

        private string dateOne;
        private string dateTwo;
        private string dateThree;
        private string dateFour;

        public Table(bool b1, bool b2, bool b3, bool b4)
        {
            InitializeComponent();
            tableone = b1;
            tabletwo = b2;
            tablethree = b3;
            tablefour = b4;

            if (!b1)
                WarningOne.Visibility = Visibility.Visible;
            if (!b2)
                WarningTwo.Visibility = Visibility.Visible;
            if (!b3)
                WarningThree.Visibility = Visibility.Visible;
            if (!b4)
                WarningFour.Visibility = Visibility.Visible;

            Date.BlackoutDates.AddDatesInPast();
            Date.BlackoutDates.Add(new CalendarDateRange(DateTime.Now));
        }

        private void Reserve(object sender, RoutedEventArgs e) //Бронирование столика
        {
            string res;
            string date;
           
            
            try
            {
                res = ((TextBlock)TableSelection.SelectedItem).Text;
                try
                {
                    date = Date.SelectedDate.Value.ToShortDateString();
                }
                catch(Exception)
                {
                    MessageBox.Show("Вы не выбрали время");
                    return;
                }

                switch (res)
                {
                    case "1":
                        if (tableone)
                        {
                            WarningOne.Visibility = Visibility.Visible;
                            dateOne = date;
                            tableone = false;
                        }
                        else
                        {
                            MessageBox.Show("Этот столик уже занят " + dateOne);
                            break;
                        }
                        break;
                    case "2":
                        if (tabletwo)
                        {
                            WarningTwo.Visibility = Visibility.Visible;
                            dateTwo = date;
                            tabletwo = false;
                        }
                        else
                        {
                            MessageBox.Show("Этот столик уже занят " + dateTwo);
                            break;
                        }
                        break;
                    case "3":
                        if (tablethree)
                        {
                            WarningThree.Visibility = Visibility.Visible;
                            dateThree = date;
                            tablethree = false;
                           
                        }
                        else
                        {
                            MessageBox.Show("Этот столик уже занят " + dateThree);
                            break;
                        }
                        break;
                    case "4":
                        if (tablefour)
                        {
                            WarningFour.Visibility = Visibility.Visible;
                            dateFour = date;
                            tablefour = false;
                        }
                        else
                        {
                            MessageBox.Show("Этот столик уже занят " + dateFour);
                            break;
                        }
                        break;
                    default:
                        break;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали столик");
            }
        }
    }
}
