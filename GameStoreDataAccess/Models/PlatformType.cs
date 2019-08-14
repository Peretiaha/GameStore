using System;
using System.Collections.Generic;

namespace GameStoreModel.Models
{
    using System.ComponentModel.DataAnnotations;

    public class PlatformType
    {
        [Key]
        public Guid PlatformTypeId { get; set; }

        public string Type { get; set; }

        public IList<GamePlatform> GamePlatform { get; set; }
    }
}
