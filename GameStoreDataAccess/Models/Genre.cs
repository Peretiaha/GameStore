using System;
using System.Collections.Generic;

namespace GameStoreModel.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Genre
    {
        [Key]
        public Guid GenreId { get; set; }

        public string BaseGenreId { get; set; }

        public string Name { get; set; }

        public IList<GameGenre> GameGenres { get; set; }

    }
}
