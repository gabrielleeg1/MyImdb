﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MyImdb.Entities;

#nullable disable

namespace MyImdb.Migrations {
	[DbContext(typeof(AppDbContext))]
	partial class AppDbContextModelSnapshot : ModelSnapshot {
		protected override void BuildModel(ModelBuilder modelBuilder) {
#pragma warning disable 612, 618
			modelBuilder
				.HasAnnotation("ProductVersion", "6.0.6")
				.HasAnnotation("Relational:MaxIdentifierLength", 128);

			SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

			modelBuilder.Entity("MyImdb.Entities.Movie", b => {
				b.Property<Guid>("Id")
					.ValueGeneratedOnAdd()
					.HasColumnType("uniqueidentifier");

				b.Property<int>("Rank")
					.HasColumnType("int");

				b.Property<string>("StoryLine")
					.IsRequired()
					.HasMaxLength(200)
					.HasColumnType("nvarchar(200)");

				b.Property<string>("Title")
					.IsRequired()
					.HasMaxLength(100)
					.HasColumnType("nvarchar(100)");

				b.HasKey("Id");

				b.ToTable("Movies");
			});
#pragma warning restore 612, 618
		}
	}
}