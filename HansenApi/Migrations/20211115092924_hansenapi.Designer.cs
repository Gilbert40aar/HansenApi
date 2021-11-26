﻿// <auto-generated />
using HansenApi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HansenApi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211115092924_hansenapi")]
    partial class hansenapi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HansenApi.Models.Admin", b =>
                {
                    b.Property<int>("adminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("adminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("HansenApi.Models.Contact", b =>
                {
                    b.Property<int>("contactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("contactId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("HansenApi.Models.Education", b =>
                {
                    b.Property<int>("educationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("addRess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripTion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("educationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("school")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("startDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("educationId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("HansenApi.Models.Genre", b =>
                {
                    b.Property<int>("genreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("genreTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("genreId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("HansenApi.Models.Location", b =>
                {
                    b.Property<int>("locationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("addRess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("locationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("HansenApi.Models.Profile", b =>
                {
                    b.Property<int>("profileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("birthDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("contactId")
                        .HasColumnType("int");

                    b.Property<string>("descripTion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("locationId")
                        .HasColumnType("int");

                    b.Property<string>("secondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("statusId")
                        .HasColumnType("int");

                    b.HasKey("profileId");

                    b.HasIndex("contactId");

                    b.HasIndex("locationId");

                    b.HasIndex("statusId");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("HansenApi.Models.Projects", b =>
                {
                    b.Property<int>("projectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripTion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("genreId")
                        .HasColumnType("int");

                    b.Property<string>("projectTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("projectYear")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("projectId");

                    b.HasIndex("genreId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("HansenApi.Models.Settings", b =>
                {
                    b.Property<int>("settingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slogan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tech")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("settingId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("HansenApi.Models.SkillOptions", b =>
                {
                    b.Property<int>("skillOptionsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("opTion01")
                        .HasColumnType("int");

                    b.Property<int>("opTion02")
                        .HasColumnType("int");

                    b.Property<int>("opTion03")
                        .HasColumnType("int");

                    b.Property<int>("opTion04")
                        .HasColumnType("int");

                    b.Property<int>("opTion05")
                        .HasColumnType("int");

                    b.Property<int>("opTion06")
                        .HasColumnType("int");

                    b.Property<int>("opTion07")
                        .HasColumnType("int");

                    b.Property<int>("opTion08")
                        .HasColumnType("int");

                    b.Property<int>("opTion09")
                        .HasColumnType("int");

                    b.Property<int>("opTion10")
                        .HasColumnType("int");

                    b.Property<int>("skillId")
                        .HasColumnType("int");

                    b.HasKey("skillOptionsId");

                    b.ToTable("SkillOptions");
                });

            modelBuilder.Entity("HansenApi.Models.Skills", b =>
                {
                    b.Property<int>("skillsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("skillOptionsId")
                        .HasColumnType("int");

                    b.Property<string>("skillsTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("skillsId");

                    b.HasIndex("skillOptionsId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("HansenApi.Models.Status", b =>
                {
                    b.Property<int>("statusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("employee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("work")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("statusId");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("HansenApi.Models.Work", b =>
                {
                    b.Property<int>("workId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("addRess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripTion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("skillsId")
                        .HasColumnType("int");

                    b.Property<string>("startDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("workTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("workId");

                    b.ToTable("Work");
                });

            modelBuilder.Entity("HansenApi.Models.Profile", b =>
                {
                    b.HasOne("HansenApi.Models.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("contactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HansenApi.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("locationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HansenApi.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("statusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("Location");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("HansenApi.Models.Projects", b =>
                {
                    b.HasOne("HansenApi.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("genreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("HansenApi.Models.Skills", b =>
                {
                    b.HasOne("HansenApi.Models.SkillOptions", "skillOptions")
                        .WithMany()
                        .HasForeignKey("skillOptionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("skillOptions");
                });
#pragma warning restore 612, 618
        }
    }
}
