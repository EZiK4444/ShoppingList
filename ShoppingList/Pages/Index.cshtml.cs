using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShoppingList.Model;

namespace ShoppingList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public bool IsError { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            var uname = Username;
            var pass = Password;

            var user = Data.Users.FirstOrDefault(x => x.Username == uname && x.Password == pass);
            if (user != null)
            {
                //ShoppingListPage
                return RedirectToPage("UserCartDashboard", new { userId = user.UserId});
            }
            else
            {
                IsError = true;
                return Page();
            }
        }
    }
}