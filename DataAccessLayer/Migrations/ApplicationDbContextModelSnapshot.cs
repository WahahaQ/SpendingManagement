﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccessLayer.Migrations
{
	[DbContext(typeof(ApplicationDbContext))]
	partial class ApplicationDbContextModelSnapshot : ModelSnapshot
	{
		protected override void BuildModel(ModelBuilder modelBuilder)
		{
#pragma warning disable 612, 618
			modelBuilder
				.HasAnnotation("ProductVersion", "3.0.0")
				.HasAnnotation("Relational:MaxIdentifierLength", 128)
				.HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

			modelBuilder.Entity("DataAccessLayer.Entities.Category", b =>
				{
					b.Property<int>("Id")
						.ValueGeneratedOnAdd()
						.HasColumnType("int")
						.HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

					b.Property<string>("Name")
						.IsRequired()
						.HasColumnType("nvarchar(24)")
						.HasMaxLength(24);

					b.HasKey("Id");

					b.ToTable("Categories");
				});

			modelBuilder.Entity("DataAccessLayer.Entities.Spending", b =>
				{
					b.Property<int>("Id")
						.ValueGeneratedOnAdd()
						.HasColumnType("int")
						.HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

					b.Property<int>("CategoryId")
						.HasColumnType("int");

					b.Property<DateTime>("CreationTime")
						.HasColumnType("datetime2");

					b.Property<string>("Description")
						.IsRequired()
						.HasColumnType("nvarchar(256)")
						.HasMaxLength(256);

					b.Property<string>("Name")
						.IsRequired()
						.HasColumnType("nvarchar(24)")
						.HasMaxLength(24);

					b.Property<int?>("UserId")
						.HasColumnType("int");

					b.HasKey("Id");

					b.HasIndex("CategoryId");

					b.HasIndex("UserId");

					b.ToTable("Spendings");
				});

			modelBuilder.Entity("DataAccessLayer.Entities.Tag", b =>
				{
					b.Property<int>("Id")
						.ValueGeneratedOnAdd()
						.HasColumnType("int")
						.HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

					b.Property<string>("Name")
						.IsRequired()
						.HasColumnType("nvarchar(24)")
						.HasMaxLength(24);

					b.Property<int?>("SpendingId")
						.HasColumnType("int");

					b.HasKey("Id");

					b.HasIndex("SpendingId");

					b.ToTable("Tags");
				});

			modelBuilder.Entity("DataAccessLayer.Entities.User", b =>
				{
					b.Property<int>("Id")
						.ValueGeneratedOnAdd()
						.HasColumnType("int")
						.HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

					b.Property<string>("Email")
						.IsRequired()
						.HasColumnType("nvarchar(64)")
						.HasMaxLength(64);

					b.Property<string>("Sha256Password")
						.IsRequired()
						.HasColumnType("nvarchar(256)")
						.HasMaxLength(256);

					b.HasKey("Id");

					b.ToTable("Users");
				});

			modelBuilder.Entity("DataAccessLayer.Entities.Spending", b =>
				{
					b.HasOne("DataAccessLayer.Entities.Category", "Category")
						.WithMany()
						.HasForeignKey("CategoryId")
						.OnDelete(DeleteBehavior.Cascade)
						.IsRequired();

					b.HasOne("DataAccessLayer.Entities.User", null)
						.WithMany("Spendings")
						.HasForeignKey("UserId");
				});

			modelBuilder.Entity("DataAccessLayer.Entities.Tag", b =>
				{
					b.HasOne("DataAccessLayer.Entities.Spending", null)
						.WithMany("Tags")
						.HasForeignKey("SpendingId");
				});
#pragma warning restore 612, 618
		}
	}
}
