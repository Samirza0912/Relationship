using ASP_ViewComponent.DAL;
using ASP_ViewComponent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_ViewComponent.ViewComponents
{
    public class UserAccViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;
        public UserAccViewComponent (AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<SocialAccount> socials = _context.SocialAccounts.Include(p => p.user).ToList();
            return View(await Task.FromResult(socials));
        }
    }
}
