

namespace GameStoreModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PlatformType")]
    public class PlatformType
    {
        [Key]
        public Guid PlatformTypeId { get; set; }

        public string Type { get; set; }

        public IList<GamePlatform> GamePlatform { get; set; }
    }
}
