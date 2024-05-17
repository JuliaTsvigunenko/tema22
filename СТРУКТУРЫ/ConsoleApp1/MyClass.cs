using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        //1
        //struct MyStruct
        //{
        //    public string change;
        //}

        //class MyClass1
        //{
        //    public string change;
        //}


        //2
        struct Notebook
    {
        // Поля структуры
            string Model; 
            string Proizvoditel;
            double Price;

        public Notebook(string model, string proizvoditel, double price)
        {
            this.Model = model;
            this.Proizvoditel = proizvoditel;
            this.Price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Модель:{Model}\nПроизводитель:{Proizvoditel}\nЦена:{Price}");
        }
        
    }

        



}
