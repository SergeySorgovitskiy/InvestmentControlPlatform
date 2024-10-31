using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestmentControlPlatform.DataAccess.Models
{
    public class UserSetting
    {
        [Key]
        [Column("user_setting_id")]
        public int UserSettingId { get; set; }

        [Required]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("setting_key", TypeName = "VARCHAR(50)")]
        public string SettingKey { get; set; }

        [Required]
        [Column("setting_value", TypeName = "TEXT")]
        public string SettingValue { get; set; }

        public User User { get; set; }
    }
}
