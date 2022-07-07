using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_ViewComponent.Models
{
    public class SocialAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }
    }
}
