using System;
using System.Collections.Generic;

namespace GameStoreModel.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Data;

    public class Game
    {
        [Key]
        public Guid GameId { get; set; }

        public string Key { get; set; }   // alias for link creating

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Comment> ListOfComments { get; set; }

        public ICollection<GameGenre> GameGenre { get; set; }

        public ICollection<GamePlatform> GamePlatform { get; set; }





    }
}
