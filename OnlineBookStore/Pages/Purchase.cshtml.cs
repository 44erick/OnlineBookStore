using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineBookStore.Infrastructure;
using OnlineBookStore.Models;

namespace OnlineBookStore.Pages
{
    //inherited from pagemodel
    public class PurchaseModel : PageModel
    {
        private IBookRepository repository;
        //constructor
        public PurchaseModel(IBookRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        //property
        public Cart Cart { get; set; }
        //property
        public string ReturnUrl { get; set; }

        //methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = ReturnUrl ?? "/";
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Project project = repository.Projects.FirstOrDefault(predicate => predicate.BookID == bookId);
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(project, 1);
            //HttpContext.Session.SetJson("cart", Cart);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl => cl.Project.BookID == bookId).Project);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
