using Domain.Builder;
using Domain.Entity;

public class Program
{
    public static void Main(string[] args)
    {
        Order myOrder = new OrderBuilder()
                            .WithCustomerName("Davi")
                            .WithCustomerEmail("davidias@gmail.com")
                            .WithAddress("Rua 4")
                            .WithCity("Ribeirão Preto")
                            .Build();

        Console.WriteLine(myOrder.CustomerName);
        Console.WriteLine(myOrder.PaymentMethod);
        Console.WriteLine(myOrder.CustomerEmail);
        Console.WriteLine(myOrder.City);
        Console.WriteLine(myOrder.Address);




    }
}