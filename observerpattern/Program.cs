using System;

namespace observerpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrot carrot = new Carrot(1.2);
            carrot.Add(new Resturant("Elmak"));
            carrot.Add(new Resturant("haperMAreket"));

            carrot.Price = 1.4;
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
