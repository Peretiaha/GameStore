using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStoreModel.Models
{
    public class Comment
    {
        [Key]
        public Guid CommentId { get; set; }

        public string Name { get; set; }

        public string Body { get; set; }

        public Guid GameId { get; set; }

        public Game Game { get; set; }

        public bool IsDeleted { get; set; }

        public Guid BaseCommentId { get; set; }

    }
}
