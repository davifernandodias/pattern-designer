using Domain.Entity;

namespace Domain.Builder;

public class OrderBuilder
{
    private Order order;

    public OrderBuilder()
    {
        order = new Order();
    }

    public OrderBuilder WithCustomerName(string customerName)
    {
        order.CustomerName = customerName;
        return this;
    }
    public OrderBuilder WithCustomerEmail(string customerEmail)
    {
        order.CustomerEmail = customerEmail;
        return this;
    }
    public OrderBuilder WithAddress(string address)
    {
        order.Address = address;
        return this;
    }

    public OrderBuilder WithCity(string city)
    {
        return this;
    }

    public OrderBuilder WithZipCode(string? zipCode)
    {
        return this;
    }

    public OrderBuilder WithFreight(decimal? freight)
    {
        return this;
    }


    public OrderBuilder WithDiscount(decimal? discount)
    {
        return this;
    }

    public OrderBuilder WithObservation(string? observation)
    {
        return this;
    }

    public OrderBuilder WithPaymentMethod(string paymentMethod)
    {
        order.PaymentMethod = paymentMethod;
        return this;
    }

    public Order Build()
    {
        if (order.PaymentMethod == null || order.City == null || order.CustomerEmail == null || order.Address == null || order.CustomerName == null) throw new ArgumentException("falta de parâmetros");
        return order;
    }
}