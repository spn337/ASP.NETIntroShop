﻿// <auto-generated />
using IntroShop.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IntroShop.Migrations
{
    [DbContext(typeof(DBContent))]
    [Migration("20200204094858_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IntroShop.Main.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Camera");

                    b.Property<string>("Img");

                    b.Property<string>("Memory");

                    b.Property<string>("Name");

                    b.Property<long>("Price");

                    b.Property<string>("SizeScreen");

                    b.HasKey("Id");

                    b.ToTable("Phone");
                });
#pragma warning restore 612, 618
        }
    }
}
