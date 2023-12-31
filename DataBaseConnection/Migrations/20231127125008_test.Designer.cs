﻿// <auto-generated />
using System;
using DataBaseConnection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataBaseConnection.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231127125008_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Community.ThreadComment", b =>
                {
                    b.Property<int>("ThreadCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ThreadId")
                        .HasColumnType("int");

                    b.HasKey("ThreadCommentId");

                    b.HasIndex("ThreadId");

                    b.ToTable("ThreadComments");
                });

            modelBuilder.Entity("Core.News.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Core.News.NewsComment", b =>
                {
                    b.Property<int>("NewsCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("NewsId")
                        .HasColumnType("int");

                    b.HasKey("NewsCommentId");

                    b.HasIndex("NewsId");

                    b.ToTable("NewsComments");
                });

            modelBuilder.Entity("Core.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Post");
                });

            modelBuilder.Entity("Core.User.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProfilePicturePath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("Core.Community.Thread", b =>
                {
                    b.HasBaseType("Core.Post");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Thread_Category");

                    b.Property<int>("ThreadId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Thread_Title");

                    b.HasDiscriminator().HasValue("Thread");
                });

            modelBuilder.Entity("Core.News.News", b =>
                {
                    b.HasBaseType("Core.Post");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NewsId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("News");
                });

            modelBuilder.Entity("Core.User.Admin", b =>
                {
                    b.HasBaseType("Core.User.User");

                    b.Property<int>("AdminPrivilegeLevel")
                        .HasColumnType("int");

                    b.Property<string>("AdminTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("Core.User.Guest", b =>
                {
                    b.HasBaseType("Core.User.User");

                    b.Property<int>("UserExperience")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Guest");
                });

            modelBuilder.Entity("Core.User.Moderator", b =>
                {
                    b.HasBaseType("Core.User.User");

                    b.Property<int>("ModerationExperience")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Moderator");
                });

            modelBuilder.Entity("Core.Community.ThreadComment", b =>
                {
                    b.HasOne("Core.Community.Thread", null)
                        .WithMany("ThreadComments")
                        .HasForeignKey("ThreadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.News.NewsComment", b =>
                {
                    b.HasOne("Core.News.News", null)
                        .WithMany("NewsComments")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Post", b =>
                {
                    b.HasOne("Core.User.User", null)
                        .WithMany("PostHistory")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.User.User", b =>
                {
                    b.Navigation("PostHistory");
                });

            modelBuilder.Entity("Core.Community.Thread", b =>
                {
                    b.Navigation("ThreadComments");
                });

            modelBuilder.Entity("Core.News.News", b =>
                {
                    b.Navigation("NewsComments");
                });
#pragma warning restore 612, 618
        }
    }
}
