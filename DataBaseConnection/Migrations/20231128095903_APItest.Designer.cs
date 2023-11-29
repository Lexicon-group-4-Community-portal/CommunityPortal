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
    [Migration("20231128095903_APItest")]
    partial class APItest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.CommunityClasses.BlogComment", b =>
                {
                    b.Property<int>("BlogCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BlogPostId")
                        .HasColumnType("int");

                    b.HasKey("BlogCommentId");

                    b.HasIndex("BlogPostId");

                    b.ToTable("BlogComments");
                });

            modelBuilder.Entity("Core.NewsClasses.Event", b =>
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

            modelBuilder.Entity("Core.NewsClasses.NewsComment", b =>
                {
                    b.Property<int>("NewsCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("NewsPostId")
                        .HasColumnType("int");

                    b.HasKey("NewsCommentId");

                    b.HasIndex("NewsPostId");

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

            modelBuilder.Entity("Core.UserClasses.User", b =>
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

            modelBuilder.Entity("Core.CommunityClasses.Blog", b =>
                {
                    b.HasBaseType("Core.Post");

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int")
                        .HasColumnName("Blog_Category");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Blog_Title");

                    b.HasDiscriminator().HasValue("Blog");
                });

            modelBuilder.Entity("Core.NewsClasses.News", b =>
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

            modelBuilder.Entity("Core.UserClasses.Admin", b =>
                {
                    b.HasBaseType("Core.UserClasses.User");

                    b.Property<int>("AdminPrivilegeLevel")
                        .HasColumnType("int");

                    b.Property<string>("AdminTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("Core.UserClasses.Guest", b =>
                {
                    b.HasBaseType("Core.UserClasses.User");

                    b.Property<int>("UserExperience")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Guest");
                });

            modelBuilder.Entity("Core.UserClasses.Moderator", b =>
                {
                    b.HasBaseType("Core.UserClasses.User");

                    b.Property<int>("ModerationExperience")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Moderator");
                });

            modelBuilder.Entity("Core.CommunityClasses.BlogComment", b =>
                {
                    b.HasOne("Core.CommunityClasses.Blog", "Blog")
                        .WithMany("BlogComments")
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("Core.NewsClasses.NewsComment", b =>
                {
                    b.HasOne("Core.NewsClasses.News", "News")
                        .WithMany("NewsComments")
                        .HasForeignKey("NewsPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("News");
                });

            modelBuilder.Entity("Core.Post", b =>
                {
                    b.HasOne("Core.UserClasses.User", "User")
                        .WithMany("PostHistory")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.UserClasses.User", b =>
                {
                    b.Navigation("PostHistory");
                });

            modelBuilder.Entity("Core.CommunityClasses.Blog", b =>
                {
                    b.Navigation("BlogComments");
                });

            modelBuilder.Entity("Core.NewsClasses.News", b =>
                {
                    b.Navigation("NewsComments");
                });
#pragma warning restore 612, 618
        }
    }
}