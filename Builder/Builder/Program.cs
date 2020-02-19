using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var ceva = Person.Builder
                .WithProperty(p => p.LastName = "Popescu")
                .WithProperty(p => p.Name = "Ionel")
                .WithProperty(p => p.Address = "Str. 1 Zimbru 1928")
                .BuildAsImmutable();

            Console.WriteLine(ceva.Get(p => p.LastName));
            Console.WriteLine(ceva.Get(p => p.Name));
            Console.WriteLine(ceva.Get(p => p.Address));
            Console.WriteLine(ceva.Get(p => p.Phone));
        }
    }
}