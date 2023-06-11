namespace ShoppingList.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int ProductAmount { get; set; }
        public bool IsInCart { get; set; }
    }
}
