namespace Eshop.Domain.Models.Item
{
    public class ItemDetails : BaseModel
    {
        public Guid ItemId { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}