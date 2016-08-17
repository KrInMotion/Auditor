using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Auditor.Data;

namespace Auditor.Migrations
{
    [DbContext(typeof(AuditorDbContext))]
    [Migration("20160817084044_V1")]
    partial class V1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("Address");

                    b.Property<int?>("ResponsibleId");

                    b.HasKey("Id");

                    b.HasIndex("ResponsibleId");

                    b.ToTable("WifiChecks");
                });

            modelBuilder.Entity("Auditor.Models.WifiCheck", b =>
                {
                    b.HasOne("Auditor.Models.User", "Responsible")
                        .WithMany()
                        .HasForeignKey("ResponsibleId");
                });
        }
    }
}
