using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knigga
{
    public class Book
    {
        internal string avtor;
        internal string name;
        public string code;
        public int stranics;
        public bool Kollection;

        public Book(string code, int stranics, bool Kollection)
        {
            avtor = "Автор_конструкт";
            name = "Название_конструкт";
            this.code = code;
            this.stranics = stranics;
            this.Kollection = Kollection;
        }

        public Book(string avtor, string name, string code, int stranics, bool Kollection)
        {
            this.avtor = avtor;
            this.name = name;
            this.code = code;
            this.stranics = stranics;
            this.Kollection = Kollection;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Book BookOne = new Book("none", 0, true);
            Book BookTwo = new Book("Джоан Роулинг", "Гарри-Поттер и философский камень", "949494-9494949-3333", 1300, false);

            bool KollectionOnen = BookOne.Kollection;
            bool KollectionTwon = BookTwo.Kollection;

            string KollectionOne;
            string KollectionTwo;

            if (KollectionOnen)
            {
                KollectionOne = "Коллекционное";
            }
            else
            {
                KollectionOne = "Не коллекционное";
            }

            if (KollectionTwon)
            {
                KollectionTwo = "Коллекционное";
            }
            else
            {
                KollectionTwo = "Не коллекционное";
            }

            Console.WriteLine($"{BookOne.avtor} \n" +
                              $"{BookOne.name} \n" +
                              $"{BookOne.code} \n" +
                              $"{BookOne.stranics} \n" +
                              $"{KollectionOne}\n");

            Console.WriteLine($"{BookTwo.avtor} \n" +
                              $"{BookTwo.name} \n" +
                              $"{BookTwo.code} \n" +
                              $"{BookTwo.stranics} \n" +
                              $"{KollectionTwo}");
            Console.ReadKey();
        }
    }
}
