using System;

namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer();

            computer.Add(new Ram());
            computer.Add(new Hdd());
            computer.Add(new Hdd());
            computer.Add(new Cpu());
            computer.Add(new Gpu());

            computer.Buy();

            Console.WriteLine($"The computer costed us {computer.Price}");
        }
    }
}
