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
    public class ItemViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;
        public ItemViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Student> students = _context.Students.Include(p => p.group).ToList();
            return View(await Task.FromResult(students));
        }
    }
}
