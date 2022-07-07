using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_ViewComponent.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<BookAndGenreRelation> BookGenres { get; set; }
    }
}
