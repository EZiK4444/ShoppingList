using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShoppingList.Model;

namespace ShoppingList.Pages
{
    public class UserCartDashboardModel : PageModel
    {
        public List<Product> Products { get; set; }
        public User User { get; set; }
        [BindProperty(Name = "userID" , SupportsGet = true)]
        public int UserId { get; set; }

        public void OnGet()
        {
            User = Data.Users.FirstOrDefault(x => x.UserId == UserId) ?? new User();
            Products = DataProduct.Products.ToList().FindAll(x => x.UserId == UserId);
        }
    }
}
