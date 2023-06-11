namespace ShoppingList.Model
{
    public class DataProduct
    {
        public static List<Product> Products = new List<Product>
        {
            new Product {ProductId = 1, ProductName = "Milk", ProductAmount = 2},
            new Product {ProductId = 2, ProductName = "Apple", ProductAmount = 4},
            new Product {ProductId = 3, ProductName = "Beer", ProductAmount = 1},
            new Product {ProductId = 4, ProductName = "Water 1L", ProductAmount = 2},
            new Product {ProductId = 5, ProductName = "Cereal", ProductAmount = 1},
            new Product {ProductId = 6, ProductName = "Nutella", ProductAmount = 1},
            new Product {ProductId = 7, ProductName = "Bread", ProductAmount = 2},
        };
    }
}
