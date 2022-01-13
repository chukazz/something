using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR19LR18
{
    internal class Product
    {
        string name;
        int countOnStore;
        string aboutProduct;

        public string Name { get => name; }
        public int CountOnStore { get => countOnStore; }
        public string AboutProduct { get => aboutProduct; }

        public Product(string n, int c, string a)
        {
            name = n;
            countOnStore = c;
            aboutProduct = a;
        }

        public void Print() => Console.WriteLine($"{name} {countOnStore} {aboutProduct}");
    }
}
