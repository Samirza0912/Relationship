using ASP_ViewComponent.DAL;
using ASP_ViewComponent.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_ViewComponent.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();

            homeVM.Groups = _context.Groups.ToList();
            homeVM.Students = _context.Students.ToList();
            homeVM.Users = _context.Users.ToList();
            homeVM.SocialAccounts = _context.SocialAccounts.ToList();
            return View(homeVM);
        }
    }
}
