
using System;

namespace lesson16
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // var obj = new Roya("bye 2020");



            //Circle circle = new Circle();
            //Shape shape = circle;

            Shape shape = new Shape();
            Circle circle = (Circle)shape;



            Console.ReadKey();


        }
    }
}
