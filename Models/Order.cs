
using OnlineShopping.DTOs;

namespace OnlineShopping.Models;

public record Order
{

    public long Id { get; set; }
    public long CustomerId{ get; set; }
    public DateTimeOffset OrderedAt { get; set; }
    public decimal TotalPrice{ get; set; }
    public string ModeOfPayment{ get; set; }


     public OrderDTO asDto => new OrderDTO
    {
        Id = Id,
        OrderedAt = OrderedAt,
        ModeOfPayment = ModeOfPayment,
        TotalPrice = TotalPrice,
        CustomerId = CustomerId,
        

    };
}