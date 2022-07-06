using System;
using ProxyPattern.Example_1.Proxsy;
namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proxsy proxsy = new Proxsy();
            if (1 == 1)
            {
                proxsy.DoAction();
            }
            Console.WriteLine();
        }
    }
}
