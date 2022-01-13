using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR19LR18
{
    enum Marka
    {
        Lada,
        Kia,
        Mersedes,
        Hyndai,
        Bmw
    }


    internal class Car
    {
        int maxSpeed;
        string color;
        int countPass;
        Marka marka;

        public int MaxSpeed { get => maxSpeed; }
        public string Color { get => color; }
        public int CountPass { get => countPass; }
        public Marka Marka { get => marka; }

        public Car(int speed, string col, int count, Marka mark)
        {
            maxSpeed = speed;
            color = col;
            countPass = count;
            marka = mark;
        }

        public void Print() => Console.WriteLine($"{maxSpeed} {color} {countPass} {marka}");


    }
}
