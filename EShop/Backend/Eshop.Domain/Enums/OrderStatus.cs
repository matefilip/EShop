namespace Eshop.Domain.Enums
{
    public enum OrderStatus
    {
        Unknown = 0,
        Pending = 1,
        Confirmed = 2,
        Shipped = 3,
        Delivered = 4,
        Cancelled = 5,
        Returned = 6,
        Refunded = 7
    }
}