using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStoreModel.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Genre")]
    public class Genre
    {
        [Key]
        public Guid GenreId { get; set; }

        public string BaseGenreId { get; set; }

        public string Name { get; set; }

        public IList<GameGenre> GameGenre { get; set; }

    }
}
