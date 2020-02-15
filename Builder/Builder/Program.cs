using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var ceva = Person.Builder
                .WithProperty("name", "ionel")
                .WithProperty("lastname", "popescu")
                .WithProperty("address", "Sf. Iorga")
                .WithProperty("phone", 123456)
                .Build();

            Console.WriteLine(ceva.Name);
            Console.WriteLine(ceva.LastName);
            Console.WriteLine(ceva.Address);
            Console.WriteLine(ceva.Phone);

        }
    }
}