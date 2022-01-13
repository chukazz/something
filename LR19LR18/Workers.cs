using Hangfire.Server;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR19LR18
{

    class Worker<T>
    {
        public string name { get; set; }
        public T date { get; set; }

        public Worker(string name, T date)
        {
            this.name = name;
            this.date = date;
        }

        public void Display()
        {
            Console.WriteLine($"Должность - {name}, стаж - {date}");
        }

        public override string ToString()
        {
            return String.Format("Имя {0} Стаж {1}", name, date);
        }
    }

    class Administrator<T> : Worker<T>
    {
        public Administrator(string name, T date) : base(name, date)
        {
            this.name = name;
            this.date = date;
        }
    }

    class Programmer<T> : Worker<T>
    {
        public Programmer(string name, T date) : base(name, date)
        {
            this.name = name;
            this.date = date;
        }
    }

    class Manager<T> : Worker<T>
    {
        public Manager(string name, T date) : base(name, date)
        {
            this.name = name;
            this.date = date;
        }
    }
}
