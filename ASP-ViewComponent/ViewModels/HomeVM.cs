using ASP_ViewComponent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_ViewComponent.ViewModels
{
    public class HomeVM
    {
        public List<Group> Groups { get; set; }
        public List<Student> Students { get; set; }
        public List<User> Users { get; set; }
        public List<SocialAccount> SocialAccounts { get; set; }
    }
}
