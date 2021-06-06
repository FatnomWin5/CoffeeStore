using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library
{
    public class TypesOfCoffee : ICoffee
    {
        private string name;
        private int price;

        
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }

        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value < 0)
                throw new ArgumentException("Ошибка данных");
                
                price = value;
            }

        }
    }
}
