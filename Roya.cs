using System;
namespace lesson16
{
    public class Roya : Stduent
    {
        public Roya(string message) : base(message)
        {
            Console.WriteLine($"init form roya {message}");
        }
    }
}
