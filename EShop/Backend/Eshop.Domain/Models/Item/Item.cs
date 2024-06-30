namespace Eshop.Domain.Models.Item
{
    public class Item : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ThumbnailUri { get; set; } = string.Empty;
        public ItemDetails? Details { get; set; }
    }
}