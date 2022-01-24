﻿// <auto-generated />
using System;
using BeluqaTahir.Domain.Model.DataContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeluqaTahir.Domain.Migrations
{
    [DbContext(typeof(BeluqaTahirDbContext))]
    [Migration("20220121163903_Initcik21")]
    partial class Initcik21
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Accountdetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linkedin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twwiter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreateByUserId");

                    b.HasIndex("DeleteByUserId");

                    b.ToTable("accountdetails");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.AuditLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Controller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsHttps")
                        .HasColumnType("bit");

                    b.Property<string>("Method")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pati")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QueryString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ResponseTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreateByUserId");

                    b.HasIndex("DeleteByUserId");

                    b.ToTable("auditLogs");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePati")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShopDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreateByUserId");

                    b.HasIndex("DeleteByUserId");

                    b.ToTable("blogPosts");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.BlogPostComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogPostId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BlogPostId");

                    b.HasIndex("CreateByUserId");

                    b.HasIndex("DeleteByUserId");

                    b.HasIndex("ParentId");

                    b.ToTable("BlogPostComments");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AnswerByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AnswerdData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreateByUserId");

                    b.HasIndex("DeleteByUserId");

                    b.ToTable("contacts");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.HappyClients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePati")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreateByUserId");

                    b.HasIndex("DeleteByUserId");

                    b.ToTable("happyClients");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", "Membership");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "Membership");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<bool>("Activates")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", "Membership");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "Membership");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", "Membership");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", "Membership");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", "Membership");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePati")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypesId")
                        .HasColumnType("int");

                    b.Property<string>("ShopDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreateByUserId");

                    b.HasIndex("DeleteByUserId");

                    b.HasIndex("ProductTypesId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.ProductTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreateByUserId");

                    b.HasIndex("DeleteByUserId");

                    b.ToTable("productTypes");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Subscrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("EmailConfirmedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreateByUserId");

                    b.HasIndex("DeleteByUserId");

                    b.ToTable("subscrices");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Accountdetails", b =>
                {
                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "CreateByUser")
                        .WithMany()
                        .HasForeignKey("CreateByUserId");

                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "DeleteByUser")
                        .WithMany()
                        .HasForeignKey("DeleteByUserId");

                    b.Navigation("CreateByUser");

                    b.Navigation("DeleteByUser");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.AuditLog", b =>
                {
                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "CreateByUser")
                        .WithMany()
                        .HasForeignKey("CreateByUserId");

                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "DeleteByUser")
                        .WithMany()
                        .HasForeignKey("DeleteByUserId");

                    b.Navigation("CreateByUser");

                    b.Navigation("DeleteByUser");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.BlogPost", b =>
                {
                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "CreateByUser")
                        .WithMany()
                        .HasForeignKey("CreateByUserId");

                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "DeleteByUser")
                        .WithMany()
                        .HasForeignKey("DeleteByUserId");

                    b.Navigation("CreateByUser");

                    b.Navigation("DeleteByUser");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.BlogPostComment", b =>
                {
                    b.HasOne("BeluqaTahir.Domain.Model.Entity.BlogPost", "BlogPost")
                        .WithMany("Comments")
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "CreateByUser")
                        .WithMany()
                        .HasForeignKey("CreateByUserId");

                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "DeleteByUser")
                        .WithMany()
                        .HasForeignKey("DeleteByUserId");

                    b.HasOne("BeluqaTahir.Domain.Model.Entity.BlogPostComment", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.Navigation("BlogPost");

                    b.Navigation("CreateByUser");

                    b.Navigation("DeleteByUser");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Contact", b =>
                {
                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "CreateByUser")
                        .WithMany()
                        .HasForeignKey("CreateByUserId");

                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "DeleteByUser")
                        .WithMany()
                        .HasForeignKey("DeleteByUserId");

                    b.Navigation("CreateByUser");

                    b.Navigation("DeleteByUser");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.HappyClients", b =>
                {
                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "CreateByUser")
                        .WithMany()
                        .HasForeignKey("CreateByUserId");

                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "DeleteByUser")
                        .WithMany()
                        .HasForeignKey("DeleteByUserId");

                    b.Navigation("CreateByUser");

                    b.Navigation("DeleteByUser");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaRoleClaim", b =>
                {
                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUserClaim", b =>
                {
                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUserLogin", b =>
                {
                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUserRole", b =>
                {
                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUserToken", b =>
                {
                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Product", b =>
                {
                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "CreateByUser")
                        .WithMany()
                        .HasForeignKey("CreateByUserId");

                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "DeleteByUser")
                        .WithMany()
                        .HasForeignKey("DeleteByUserId");

                    b.HasOne("BeluqaTahir.Domain.Model.Entity.ProductTypes", "ProductTypes")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreateByUser");

                    b.Navigation("DeleteByUser");

                    b.Navigation("ProductTypes");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.ProductTypes", b =>
                {
                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "CreateByUser")
                        .WithMany()
                        .HasForeignKey("CreateByUserId");

                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "DeleteByUser")
                        .WithMany()
                        .HasForeignKey("DeleteByUserId");

                    b.Navigation("CreateByUser");

                    b.Navigation("DeleteByUser");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.Subscrice", b =>
                {
                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "CreateByUser")
                        .WithMany()
                        .HasForeignKey("CreateByUserId");

                    b.HasOne("BeluqaTahir.Domain.Model.Entity.Membership.BeluqaUser", "DeleteByUser")
                        .WithMany()
                        .HasForeignKey("DeleteByUserId");

                    b.Navigation("CreateByUser");

                    b.Navigation("DeleteByUser");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.BlogPost", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.BlogPostComment", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("BeluqaTahir.Domain.Model.Entity.ProductTypes", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}