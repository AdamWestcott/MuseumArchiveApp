﻿// <auto-generated />
using System;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230514220927_CreationOfProvenanceRecordsTable")]
    partial class CreationOfProvenanceRecordsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("DataAccess.Data.ArchivalItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ArchivalItemCreationDate")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("ArchivalItemImage")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("ArchivalItemLongDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ArchivalItemName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ArchivalItemReference")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ArchivalItemShortDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ArchivalItems");
                });

            modelBuilder.Entity("DataAccess.Data.KeywordTag", b =>
                {
                    b.Property<string>("keywordTagID")
                        .HasColumnType("TEXT");

                    b.Property<string>("keywordTagName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("keywordTagID");

                    b.ToTable("KeywordTags");
                });

            modelBuilder.Entity("DataAccess.Data.KeywordTagGroup", b =>
                {
                    b.Property<string>("keywordTagGroupID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArchivalItemID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("keywordTagID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("keywordTagName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("keywordTagGroupID");

                    b.ToTable("KeywordTagGroups");
                });

            modelBuilder.Entity("DataAccess.Data.ProvenanceRecord", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ProvenanceDateOfPurchase")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvenanceDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvenanceLocationOfPurchase")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvenanceName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvenanceNotes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProvenanceNumberOfPriorOwners")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("ProvenanceRecordImage")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("ProvidenceID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("PurchaseValue")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("ProvenanceRecords");
                });

            modelBuilder.Entity("DataAccess.Data.Providences", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArchivalItemID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ProvidenceDateOfPurchase")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("ProvidenceImage")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("ProvidenceName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("PurchaseValue")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Providences");
                });
#pragma warning restore 612, 618
        }
    }
}
