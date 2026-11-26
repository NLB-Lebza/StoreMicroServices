namespace StoreMS.DTOs
{
    public class ProductDto
    {
        public int CustomerId { get; set; }

        public List<OrderItemDto> Items { get; set; } = new();
    }
}
