using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_ViewComponent.Models
{
    public class BookAndGenreRelation
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int GenreId { get; set; }
        public Book Books { get; set; }
        public Genre Genres { get; set; }
    }
}
