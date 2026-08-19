namespace Domain.Entity;

public class Order
{
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string? ZipCode { get; set; }
    public decimal? Freight { get; set; }
    public decimal? Discount { get; set; }
    public string PaymentMethod { get; set; }
    public string? Observation { get; set; }
}