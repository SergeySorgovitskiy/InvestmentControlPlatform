using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InvestmentControlPlatform.DataAccess.Models
{
    public class Comment
    {
        [Key]
        [Column("comment_id")]
        public int CommentId { get; set; }

        [Required]
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("asset_id")]
        public int? AssetId { get; set; }

        [Required]
        [Column("content", TypeName = "TEXT")]
        public string Content { get; set; }

        [Column("created_date", TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public User User { get; set; }
        public Asset Asset { get; set; }
    }
}
