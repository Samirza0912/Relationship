using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_ViewComponent.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
    }
}
