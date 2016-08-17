using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Auditor.Data;

namespace Auditor.Migrations
{
    [DbContext(typeof(AuditorDbContext))]
    [Migration("20160817114250_V3")]
    partial class V3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Auditor.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Regions");
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

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Note");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<int>("RegionId");

                    b.Property<int>("TaskTime");

                    b.Property<int>("UserId");

                    b.Property<int>("ViolationsCount");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.HasIndex("UserId");

                    b.ToTable("WifiChecks");
                });

            modelBuilder.Entity("Auditor.Models.WifiCheck", b =>
                {
                    b.HasOne("Auditor.Models.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Auditor.Models.User", "Responsible")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
