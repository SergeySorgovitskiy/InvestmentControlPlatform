using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InvestmentControlPlatform.DataAccess.Models
{
    public class Notification
    {
        [Key]
        [Column("notification_id")]
        public int NotificationId { get; set; }

        [Required]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("type", TypeName = "VARCHAR(50)")]
        public string Type { get; set; }

        [Required]
        [Column("message", TypeName = "VARCHAR(500)")]
        public string Message { get; set; }

        [Column("is_read", TypeName = "BIT")]
        public bool IsRead { get; set; } = false;

        [Column("created_date", TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public User User { get; set; }
    }
}
