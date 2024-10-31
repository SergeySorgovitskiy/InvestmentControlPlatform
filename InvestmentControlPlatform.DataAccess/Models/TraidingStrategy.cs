using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestmentControlPlatform.DataAccess.Models
{
    public class TradingStrategy
    {
        [Key]
        [Column("strategy_id")]
        public int StrategyId { get; set; }

        [Required]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("name", TypeName = "VARCHAR(100)")]
        public string Name { get; set; }

        [Column("description", TypeName = "TEXT")]
        public string Description { get; set; }

        [Column("parameters", TypeName = "TEXT")]
        public string Parameters { get; set; }

        public User User { get; set; }
    }
}
