namespace Eshop.Domain.Models.Order
{
    public class OrderDetails : BaseModel
    {
        public Guid OrderId { get; set; }
        public Guid ItemId { get; set; }
        public int ItemAmount { get; set; }
    }
}
