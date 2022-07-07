using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_ViewComponent.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        List<Genre> genres { get; set; }
        public List<BookAndGenreRelation> BookGenres { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
        [NotMapped]
        public List<int> AuthorIds { get; set; }
        [NotMapped]
        public List<int> GenreIds { get; set; }
    }
}
