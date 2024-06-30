using Eshop.Domain.Enums;

namespace Eshop.Domain.Models.Order
{
    internal class Order : BaseModel
    {
        public Guid UserId { get; set; }
        public Address? DeliveryAddress { get; set; }
        public DateTime? OrderDate { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Unknown;
        public List<OrderDetails>? Details { get; set; }
    }
}
