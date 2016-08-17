using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Auditor.Data;

namespace Auditor.Migrations
{
    [DbContext(typeof(AuditorDbContext))]
    [Migration("20160817120855_V5")]
    partial class V5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Auditor.Models.Territory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Capital")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<int>("DistrictId");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.HasKey("Id");

                    b.ToTable("Territories");
                });

            modelBuilder.Entity("Auditor.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("FullName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("ShortName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Auditor.Models.WifiCheck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<DateTime>("CheckDate");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Note");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<int>("TaskTime");

                    b.Property<int>("TerritoryId");

                    b.Property<int>("UserId");

                    b.Property<int>("ViolationsCount");

                    b.HasKey("Id");

                    b.HasIndex("TerritoryId");

                    b.HasIndex("UserId");

                    b.ToTable("WifiChecks");
                });

            modelBuilder.Entity("Auditor.Models.WifiCheck", b =>
                {
                    b.HasOne("Auditor.Models.Territory", "Territory")
                        .WithMany()
                        .HasForeignKey("TerritoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Auditor.Models.User", "Responsible")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
