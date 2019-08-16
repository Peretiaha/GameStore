using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreModel.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("GamePlatform")]
    public class GamePlatform
    {
        public Guid GameId { get; set; }

        public Game Game { get; set; }

        public Guid PlatformTypeId { get; set; }

        public PlatformType Platform { get; set; }
    }
}
