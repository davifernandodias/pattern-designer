using Domain.Builder;
using Domain.Entity;

// use example
Person p1 = PersonBuilder
            .Builder()
            .WithName("Davi Dias")
            .WithAge(20)
            .Build();

Console.WriteLine(p1.Name); Console.WriteLine(p1.Age);