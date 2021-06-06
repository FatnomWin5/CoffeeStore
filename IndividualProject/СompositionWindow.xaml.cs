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

namespace IndividualProject
{
    /// <summary>
    /// Логика взаимодействия для СompositionWindow.xaml
    /// </summary>
    public partial class СompositionWindow : Window
    {
        

        public СompositionWindow(string k)
        {
            InitializeComponent();
            CoffeeImage.Source = new BitmapImage(new Uri(k, UriKind.Relative)); //Показывает состав кофе из заказа картинкой.
        }
    }
}
