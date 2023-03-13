﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model;

#nullable disable

namespace Albums.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20230313143840_OneToMany")]
    partial class OneToMany
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Model.Album", b =>
                {
                    b.Property<long>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("AlbumId"));

                    b.Property<int?>("ArtistId")
                        .HasColumnType("int");

                    b.Property<long>("ArtistId1")
                        .HasColumnType("bigint");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfTracks")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("RecordLabel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearOFRelease")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumId");

                    b.HasIndex("ArtistId1");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("Model.Artist", b =>
                {
                    b.Property<long>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ArtistId"));

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainGenre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordLabel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("Model.RecordLabel", b =>
                {
                    b.Property<long>("RecordLabelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RecordLabelId"));

                    b.Property<string>("CEO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfEstablishment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfArtists")
                        .HasColumnType("int");

                    b.HasKey("RecordLabelId");

                    b.ToTable("RecordLabel");
                });

            modelBuilder.Entity("Model.Album", b =>
                {
                    b.HasOne("Model.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });
#pragma warning restore 612, 618
        }
    }
}
