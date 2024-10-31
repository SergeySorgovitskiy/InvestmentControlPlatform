using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InvestmentControlPlatform.DataAccess.Models
{
    public class Forecast
    {
        [Key]
        [Column("forecast_id")]
        public int ForecastId { get; set; }

        [Required]
        [Column("asset_id")]
        public int AssetId { get; set; }

        [Required]
        [Column("forecast_date", TypeName = "DATETIME")]
        public DateTime ForecastDate { get; set; }

        [Required]
        [Column("predicted_price", TypeName = "DECIMAL(18,4)")]
        public decimal PredictedPrice { get; set; }

        [Column("model_used", TypeName = "VARCHAR(100)")]
        public string ModelUsed { get; set; }

        public Asset Asset { get; set; }
    }
}
