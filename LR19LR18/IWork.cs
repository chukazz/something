using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR19LR18
{

    class MyFactExeption : Exception
    {
        public MyFactExeption(string message) : base(message)
        {

        }
    }


    interface IWork<T>
    {
        public void Add(T item);
        public void Remove(T item);
        public void Print(int index);
        public void RemoveAt(int index);
    }
}
