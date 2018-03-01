﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using testing.persistence;

namespace testing.Migrations
{
    [DbContext(typeof(TestingDbContext))]
    [Migration("20180228224714_resourcechanges")]
    partial class resourcechanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("testing.Models.Features", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Automatic");

                    b.Property<bool>("GPS");

                    b.Property<int>("ModelID");

                    b.Property<string>("Name");

                    b.Property<bool>("PowerSteering");

                    b.HasKey("Id");

                    b.HasIndex("ModelID");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("testing.Models.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Make");
                });

            modelBuilder.Entity("testing.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MakeId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("testing.Models.Features", b =>
                {
                    b.HasOne("testing.Models.Model", "Model")
                        .WithMany("Features")
                        .HasForeignKey("ModelID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("testing.Models.Model", b =>
                {
                    b.HasOne("testing.Models.Make", "Make")
                        .WithMany("Model")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
