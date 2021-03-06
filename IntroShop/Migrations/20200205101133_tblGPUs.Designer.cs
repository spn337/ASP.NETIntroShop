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
    [Migration("20200205101133_tblGPUs")]
    partial class tblGPUs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IntroShop.Main.Models.CPU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ClockFrequency");

                    b.Property<long>("CoreNumber");

                    b.Property<string>("Img");

                    b.Property<string>("Name");

                    b.Property<long>("Price");

                    b.Property<long>("ThreadNumber");

                    b.HasKey("Id");

                    b.ToTable("CPUs");
                });

            modelBuilder.Entity("IntroShop.Main.Models.GPU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CoreFrequency");

                    b.Property<string>("Img");

                    b.Property<long>("MemoryBusBit");

                    b.Property<long>("MemoryFrequency");

                    b.Property<long>("MemorySize");

                    b.Property<string>("Name");

                    b.Property<long>("Price");

                    b.HasKey("Id");

                    b.ToTable("GPUs");
                });

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

                    b.ToTable("Phones");
                });
#pragma warning restore 612, 618
        }
    }
}
