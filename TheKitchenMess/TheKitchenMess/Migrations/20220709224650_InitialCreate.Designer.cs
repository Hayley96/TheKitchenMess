﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TheKitchenMess.Models;

#nullable disable

namespace TheKitchenMess.Migrations
{
    [DbContext(typeof(ModelsContext))]
    [Migration("20220709224650_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TheKitchenMess.Models.Nutrient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("NutritionId")
                        .HasColumnType("integer");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("NutritionId");

                    b.ToTable("Nutrients");
                });

            modelBuilder.Entity("TheKitchenMess.Models.Nutrition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Nutrition");
                });

            modelBuilder.Entity("TheKitchenMess.Models.Result", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("CookingMinutes")
                        .HasColumnType("integer");

                    b.Property<string>("Cuisines")
                        .HasColumnType("text");

                    b.Property<bool>("DairyFree")
                        .HasColumnType("boolean");

                    b.Property<string>("Diets")
                        .HasColumnType("text");

                    b.Property<string>("DishTypes")
                        .HasColumnType("text");

                    b.Property<bool>("GlutenFree")
                        .HasColumnType("boolean");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("ImageType")
                        .HasColumnType("text");

                    b.Property<string>("License")
                        .HasColumnType("text");

                    b.Property<bool>("LowFodmap")
                        .HasColumnType("boolean");

                    b.Property<int?>("NutritionId")
                        .HasColumnType("integer");

                    b.Property<int>("OpenLicense")
                        .HasColumnType("integer");

                    b.Property<int>("PreparationMinutes")
                        .HasColumnType("integer");

                    b.Property<int>("ReadyInMinutes")
                        .HasColumnType("integer");

                    b.Property<int>("Recipeid")
                        .HasColumnType("integer");

                    b.Property<long?>("RootId")
                        .HasColumnType("bigint");

                    b.Property<int>("Servings")
                        .HasColumnType("integer");

                    b.Property<string>("SourceName")
                        .HasColumnType("text");

                    b.Property<string>("SourceUrl")
                        .HasColumnType("text");

                    b.Property<string>("SpoonacularSourceUrl")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<bool>("Vegan")
                        .HasColumnType("boolean");

                    b.Property<bool>("Vegetarian")
                        .HasColumnType("boolean");

                    b.Property<int>("WeightWatcherSmartPoints")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("NutritionId");

                    b.HasIndex("RootId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("TheKitchenMess.Models.Root", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<int>("Offset")
                        .HasColumnType("integer");

                    b.Property<int>("TotalResults")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("RecipeRoot");
                });

            modelBuilder.Entity("TheKitchenMess.Models.Nutrient", b =>
                {
                    b.HasOne("TheKitchenMess.Models.Nutrition", null)
                        .WithMany("Nutrients")
                        .HasForeignKey("NutritionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TheKitchenMess.Models.Result", b =>
                {
                    b.HasOne("TheKitchenMess.Models.Nutrition", "Nutrition")
                        .WithMany()
                        .HasForeignKey("NutritionId");

                    b.HasOne("TheKitchenMess.Models.Root", null)
                        .WithMany("Results")
                        .HasForeignKey("RootId");

                    b.Navigation("Nutrition");
                });

            modelBuilder.Entity("TheKitchenMess.Models.Nutrition", b =>
                {
                    b.Navigation("Nutrients");
                });

            modelBuilder.Entity("TheKitchenMess.Models.Root", b =>
                {
                    b.Navigation("Results");
                });
#pragma warning restore 612, 618
        }
    }
}