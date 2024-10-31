using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestmentControlPlatform.DataAccess.Models
{
    public class User
    {
        [Key]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("username", TypeName = "VARCHAR(50)")]
        public string Username { get; set; }

        [Required]
        [Column("email", TypeName = "VARCHAR(100)")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Column("password_hash", TypeName = "VARCHAR(256)")]
        public string PasswordHash { get; set; }

        [Column("date_created", TypeName = "DATETIME")]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        [Column("last_login_date", TypeName = "DATETIME")]
        public DateTime? LastLoginDate { get; set; }
        public ICollection<Portfolio> Portfolios { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<UserSetting> UserSettings { get; set; }
        public ICollection<TradingStrategy> TradingStrategies { get; set; }
    }
}
