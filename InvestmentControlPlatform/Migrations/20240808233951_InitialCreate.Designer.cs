﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InvestmentControlPlatform.Migrations
{
    [DbContext(typeof(InvestmentControlPlatformDbContext))]
    [Migration("20240808233951_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.Asset", b =>
                {
                    b.Property<int>("AssetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("asset_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AssetId"));

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("VARCHAR(3)")
                        .HasColumnName("currency");

                    b.Property<string>("Exchange")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("exchange");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("name");

                    b.Property<string>("Sector")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("sector");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("symbol");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("type");

                    b.HasKey("AssetId");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.AssetPrice", b =>
                {
                    b.Property<int>("AssetPriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("asset_price_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AssetPriceId"));

                    b.Property<int>("AssetId")
                        .HasColumnType("int")
                        .HasColumnName("asset_id");

                    b.Property<decimal>("ClosePrice")
                        .HasColumnType("DECIMAL(18,4)")
                        .HasColumnName("close_price");

                    b.Property<DateTime>("Date")
                        .HasColumnType("DATETIME")
                        .HasColumnName("date");

                    b.Property<decimal>("HighPrice")
                        .HasColumnType("DECIMAL(18,4)")
                        .HasColumnName("high_price");

                    b.Property<decimal>("LowPrice")
                        .HasColumnType("DECIMAL(18,4)")
                        .HasColumnName("low_price");

                    b.Property<decimal>("OpenPrice")
                        .HasColumnType("DECIMAL(18,4)")
                        .HasColumnName("open_price");

                    b.Property<long>("Volume")
                        .HasColumnType("BIGINT")
                        .HasColumnName("volume");

                    b.HasKey("AssetPriceId");

                    b.HasIndex("AssetId");

                    b.ToTable("AssetPrices");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("comment_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<int?>("AssetId")
                        .HasColumnType("int")
                        .HasColumnName("asset_id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("created_date");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("CommentId");

                    b.HasIndex("AssetId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.Forecast", b =>
                {
                    b.Property<int>("ForecastId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("forecast_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ForecastId"));

                    b.Property<int>("AssetId")
                        .HasColumnType("int")
                        .HasColumnName("asset_id");

                    b.Property<DateTime>("ForecastDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("forecast_date");

                    b.Property<string>("ModelUsed")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("model_used");

                    b.Property<decimal>("PredictedPrice")
                        .HasColumnType("DECIMAL(18,4)")
                        .HasColumnName("predicted_price");

                    b.HasKey("ForecastId");

                    b.HasIndex("AssetId");

                    b.ToTable("Forecasts");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.News", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("news_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("NewsId"));

                    b.Property<int?>("AssetId")
                        .HasColumnType("int")
                        .HasColumnName("asset_id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("content");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("published_date");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("source");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(500)")
                        .HasColumnName("title");

                    b.HasKey("NewsId");

                    b.HasIndex("AssetId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("notification_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("NotificationId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("created_date");

                    b.Property<ulong>("IsRead")
                        .HasColumnType("BIT")
                        .HasColumnName("is_read");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("VARCHAR(500)")
                        .HasColumnName("message");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("type");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("NotificationId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.Portfolio", b =>
                {
                    b.Property<int>("PortfolioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("portfolio_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PortfolioId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("created_date");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("VARCHAR(3)")
                        .HasColumnName("currency");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(500)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("name");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("PortfolioId");

                    b.HasIndex("UserId");

                    b.ToTable("Portfolios");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.PortfolioAsset", b =>
                {
                    b.Property<int>("PortfolioAssetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("portfolio_asset_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PortfolioAssetId"));

                    b.Property<int>("AssetId")
                        .HasColumnType("int")
                        .HasColumnName("asset_id");

                    b.Property<decimal?>("CurrentPrice")
                        .HasColumnType("DECIMAL(18,4)")
                        .HasColumnName("current_price");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("int")
                        .HasColumnName("portfolio_id");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("purchase_date");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("DECIMAL(18,4)")
                        .HasColumnName("purchase_price");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("DECIMAL(18,4)")
                        .HasColumnName("quantity");

                    b.HasKey("PortfolioAssetId");

                    b.HasIndex("AssetId");

                    b.HasIndex("PortfolioId");

                    b.ToTable("PortfolioAssets");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.TradingStrategy", b =>
                {
                    b.Property<int>("StrategyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("strategy_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("StrategyId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("name");

                    b.Property<string>("Parameters")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("parameters");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("StrategyId");

                    b.HasIndex("UserId");

                    b.ToTable("TradingStrategies");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("transaction_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("TransactionId"));

                    b.Property<int>("AssetId")
                        .HasColumnType("int")
                        .HasColumnName("asset_id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("DATETIME")
                        .HasColumnName("date");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("int")
                        .HasColumnName("portfolio_id");

                    b.Property<decimal>("Price")
                        .HasColumnType("DECIMAL(18,4)")
                        .HasColumnName("price");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("DECIMAL(18,4)")
                        .HasColumnName("quantity");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasColumnType("VARCHAR(4)")
                        .HasColumnName("transaction_type");

                    b.HasKey("TransactionId");

                    b.HasIndex("AssetId");

                    b.HasIndex("PortfolioId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("DATETIME")
                        .HasColumnName("date_created");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("email");

                    b.Property<DateTime?>("LastLoginDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("last_login_date");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARCHAR(256)")
                        .HasColumnName("password_hash");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.UserSetting", b =>
                {
                    b.Property<int>("UserSettingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_setting_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UserSettingId"));

                    b.Property<string>("SettingKey")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("setting_key");

                    b.Property<string>("SettingValue")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("setting_value");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("UserSettingId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSettings");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.AssetPrice", b =>
                {
                    b.HasOne("InvestmentControlPlatform.DataAccess.Models.Asset", "Asset")
                        .WithMany("AssetPrices")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.Comment", b =>
                {
                    b.HasOne("InvestmentControlPlatform.DataAccess.Models.Asset", "Asset")
                        .WithMany("Comments")
                        .HasForeignKey("AssetId");

                    b.HasOne("InvestmentControlPlatform.DataAccess.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");

                    b.Navigation("User");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.Forecast", b =>
                {
                    b.HasOne("InvestmentControlPlatform.DataAccess.Models.Asset", "Asset")
                        .WithMany("Forecasts")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.News", b =>
                {
                    b.HasOne("InvestmentControlPlatform.DataAccess.Models.Asset", "Asset")
                        .WithMany("News")
                        .HasForeignKey("AssetId");

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.Notification", b =>
                {
                    b.HasOne("InvestmentControlPlatform.DataAccess.Models.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.Portfolio", b =>
                {
                    b.HasOne("InvestmentControlPlatform.DataAccess.Models.User", "User")
                        .WithMany("Portfolios")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.PortfolioAsset", b =>
                {
                    b.HasOne("InvestmentControlPlatform.DataAccess.Models.Asset", "Asset")
                        .WithMany("PortfolioAssets")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvestmentControlPlatform.DataAccess.Models.Portfolio", "Portfolio")
                        .WithMany("PortfolioAssets")
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.TradingStrategy", b =>
                {
                    b.HasOne("InvestmentControlPlatform.DataAccess.Models.User", "User")
                        .WithMany("TradingStrategies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.Transaction", b =>
                {
                    b.HasOne("InvestmentControlPlatform.DataAccess.Models.Asset", "Asset")
                        .WithMany("Transactions")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvestmentControlPlatform.DataAccess.Models.Portfolio", "Portfolio")
                        .WithMany("Transactions")
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.UserSetting", b =>
                {
                    b.HasOne("InvestmentControlPlatform.DataAccess.Models.User", "User")
                        .WithMany("UserSettings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.Asset", b =>
                {
                    b.Navigation("AssetPrices");

                    b.Navigation("Comments");

                    b.Navigation("Forecasts");

                    b.Navigation("News");

                    b.Navigation("PortfolioAssets");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.Portfolio", b =>
                {
                    b.Navigation("PortfolioAssets");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("InvestmentControlPlatform.DataAccess.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Notifications");

                    b.Navigation("Portfolios");

                    b.Navigation("TradingStrategies");

                    b.Navigation("UserSettings");
                });
#pragma warning restore 612, 618
        }
    }
}
