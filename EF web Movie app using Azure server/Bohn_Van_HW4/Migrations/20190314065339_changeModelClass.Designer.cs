﻿// <auto-generated />
using System;
using Bohn_Van_HW4.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bohn_Van_HW4.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190314065339_changeModelClass")]
    partial class changeModelClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bohn_Van_HW4.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<int>("MovieRating");

                    b.Property<string>("Notes");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<bool>("SpecialRelease");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("MovieID");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
