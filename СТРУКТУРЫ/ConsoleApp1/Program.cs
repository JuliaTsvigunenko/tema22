using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            //1
            //MyClass1 myclass = new MyClass1();
            //myclass.change = "изменино";
            //MyStruct myStruct = new MyStruct();
            //myStruct.change = "изменино";
            //ClassTacer(myclass);
            //StruktTacer(myStruct);
            //Console.WriteLine($"Объект класса:{myclass.change}");
            //Console.WriteLine($"Объект структуры:{myStruct.change}");


            //2
            List<Notebook> notebooks = new List<Notebook>();
            notebooks.Add(new Notebook("MackBook 16 Pro", "Apple", 20000.00));
            notebooks.Add(new Notebook("NoteBook", "Asus", 19000.99));
            notebooks.Add(new Notebook("NoteBook", "Lenovo", 15000.87));

            foreach (var notebook in notebooks)
            {
                notebook.ShowInfo();
                Console.WriteLine(); // Добавим пустую строку для разделения информации о каждом ноутбуке
            }

            Console.ReadKey();

        }

        //1
        //public static void ClassTacer(MyClass1 myClass)
        //{
        //    myClass.change = "изменено";
        //}
        //public static void StruktTacer(MyStruct myStruct)
        //{
        //    myStruct.change = "изменено";
        //}

    }
}
