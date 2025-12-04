namespace HW22.Presentation.RazorPages.Models
{
    public class BasketItem
    {
        public int ProductId { get; set; }
        public int Count { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price => UnitPrice * Count;
    }
}
