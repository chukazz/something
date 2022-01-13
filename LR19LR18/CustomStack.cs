using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR19LR18
{

    

    class Counter
    {
        int value;
        public int Value {  get; set; }

     
    }

    public class CustomStack<T> 
    {
        List<T> data;
  
        public List<T> Data
        {
            get => data;
        }


        public bool IsEmpty
        {
            get { return data.Count == 0; }
        }
        public int Count
        {
            get { return data.Count; }
        }

        public CustomStack()
        {
            data = new List<T>();
        }

        public CustomStack(List<T> data)
        {
            this.data = data;
        }

        public CustomStack(CustomStack<T> a)
        {
            this.data = new List<T>();
            this.data.AddRange(a.data);
        }

        public static CustomStack<T> operator +(CustomStack<T> stack, T value)
        {
            CustomStack<T> toReturn = new CustomStack<T>();
            toReturn.Data.AddRange(stack.Data);
            toReturn.Push(value);
            return toReturn;
        }

        public static CustomStack<T> operator -(CustomStack<T> stack)
        {
            stack.Pop();
            return stack;

        }



        public static bool operator true(CustomStack<T> value)
        {
            return value.IsEmpty ? true : false;
        }

        public static bool operator false(CustomStack<T> value)
        {
            return false;
        }

        public T AvarageValue()
        {
            return data[data.Count / 2];
        }
     

        // с > не работает
        public static CustomStack<T> operator ++(CustomStack<T> stack)
        {
            List<T> values = stack.data;
            values.Sort();
            CustomStack<T> customStack = new CustomStack<T>(values);
            return customStack;
        }

        public static CustomStack<T> operator --(CustomStack<T> stack)
        {
            return stack;
        }

        public void Push(T item)
        {
            data.Add(item);  
        }


        public T Pop()
        {
            
            if (IsEmpty)
                throw new InvalidOperationException("пустой стек");
            T tmp = data[0];
            data.RemoveAt(0);
            return tmp;
            
            
        }


        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("пустой стек");
            return data[0];
        }

       

       
    }
}
