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
                .WithProperty("phone", 123456)
                .Build();

            Console.WriteLine(ceva.Name);
            Console.WriteLine(ceva.LastName);
            Console.WriteLine(ceva.Address);
            Console.WriteLine(ceva.Phone);
        }
    }
}