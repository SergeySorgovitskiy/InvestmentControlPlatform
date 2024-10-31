using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InvestmentControlPlatform.DataAccess.Models
{
    public class News
    {
        [Key]
        [Column("news_id")]
        public int NewsId { get; set; }

        [Column("source", TypeName = "VARCHAR(100)")]
        public string Source { get; set; }

        [Required]
        [Column("title", TypeName = "VARCHAR(500)")]
        public string Title { get; set; }

        [Column("content", TypeName = "TEXT")]
        public string Content { get; set; }

        [Column("published_date", TypeName = "DATETIME")]
        public DateTime PublishedDate { get; set; } = DateTime.UtcNow;

        [Column("asset_id")]
        public int? AssetId { get; set; }

        public Asset Asset { get; set; }
    }
}
