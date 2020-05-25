﻿// <auto-generated />

using System;
using FilterLists.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Infrastructure.Migrations
{
    [DbContext(typeof(FilterListsDbContext))]
    [Migration("20181019122801_CleanupUseSignedPrimaryKeys")]
    partial class CleanupUseSignedPrimaryKeys
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FilterLists.Domain.Entities.FilterList", b =>
            {
                b.Property<short>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("SMALLINT")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<string>("ChatUrl")
                 .HasColumnType("TEXT");

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("Description")
                 .HasColumnType("TEXT");

                b.Property<string>("DescriptionSourceUrl")
                 .HasColumnType("TEXT");

                b.Property<string>("DonateUrl")
                 .HasColumnType("TEXT");

                b.Property<string>("EmailAddress")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(126)")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("ForumUrl")
                 .HasColumnType("TEXT");

                b.Property<string>("HomeUrl")
                 .HasColumnType("TEXT");

                b.Property<string>("IssuesUrl")
                 .HasColumnType("TEXT");

                b.Property<short?>("LicenseId")
                 .ValueGeneratedOnAdd()
                 .HasDefaultValue((short)5);

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<string>("Name")
                 .IsRequired()
                 .HasColumnType("VARCHAR(126)");

                b.Property<string>("PolicyUrl")
                 .HasColumnType("TEXT");

                b.Property<DateTime?>("PublishedDate")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("DATETIME")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("SubmissionUrl")
                 .HasColumnType("TEXT");

                b.Property<short?>("SyntaxId");

                b.Property<DateTime?>("UpdatedDate")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("DATETIME")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("ViewUrl")
                 .HasColumnType("TEXT");

                b.Property<string>("ViewUrlMirror1")
                 .HasColumnType("TEXT");

                b.Property<string>("ViewUrlMirror2")
                 .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("LicenseId");

                b.HasIndex("SyntaxId");

                b.ToTable("filterlists");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.Dependent", b =>
            {
                b.Property<short>("DependentFilterListId");

                b.Property<short>("DependencyFilterListId");

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.HasKey("DependentFilterListId", "DependencyFilterListId");

                b.HasIndex("DependencyFilterListId");

                b.ToTable("dependents");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.FilterListLanguage", b =>
            {
                b.Property<short>("FilterListId");

                b.Property<short>("LanguageId");

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.HasKey("FilterListId", "LanguageId");

                b.HasIndex("LanguageId");

                b.ToTable("filterlists_languages");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.FilterListMaintainer", b =>
            {
                b.Property<short>("FilterListId");

                b.Property<short>("MaintainerId");

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.HasKey("FilterListId", "MaintainerId");

                b.HasIndex("MaintainerId");

                b.ToTable("filterlists_maintainers");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.FilterListTag", b =>
            {
                b.Property<short>("FilterListId");

                b.Property<short>("TagId");

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.HasKey("FilterListId", "TagId");

                b.HasIndex("TagId");

                b.ToTable("filterlists_tags");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.Fork", b =>
            {
                b.Property<short>("ForkFilterListId");

                b.Property<short>("UpstreamFilterListId");

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.HasKey("ForkFilterListId", "UpstreamFilterListId");

                b.HasIndex("UpstreamFilterListId");

                b.ToTable("forks");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.Merge", b =>
            {
                b.Property<short>("MergeFilterListId");

                b.Property<short>("UpstreamFilterListId");

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.HasKey("MergeFilterListId", "UpstreamFilterListId");

                b.HasIndex("UpstreamFilterListId");

                b.ToTable("merges");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.SnapshotRule", b =>
            {
                b.Property<int>("SnapshotId");

                b.Property<int>("RuleId");

                b.HasKey("SnapshotId", "RuleId");

                b.HasIndex("RuleId");

                b.ToTable("snapshots_rules");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.SoftwareSyntax", b =>
            {
                b.Property<short>("SyntaxId");

                b.Property<short>("SoftwareId");

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.HasKey("SyntaxId", "SoftwareId");

                b.HasIndex("SoftwareId");

                b.ToTable("software_syntaxes");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.Language", b =>
            {
                b.Property<short>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("SMALLINT")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("Iso6391")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(2)")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("Iso6392")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(3)")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("Iso6392B")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(3)")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("Iso6392T")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(3)")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("Iso6393")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(3)")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("LocalName")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(126)")
                 .HasDefaultValueSql("NULL");

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<string>("Name")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(126)")
                 .HasDefaultValueSql("NULL");

                b.HasKey("Id");

                b.ToTable("languages");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.License", b =>
            {
                b.Property<short>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("SMALLINT")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("DescriptionUrl")
                 .HasColumnType("TEXT");

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<string>("Name")
                 .IsRequired()
                 .HasColumnType("VARCHAR(126)");

                b.Property<bool>("PermissiveAdaptation");

                b.Property<bool>("PermissiveCommercial");

                b.HasKey("Id");

                b.ToTable("licenses");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.Maintainer", b =>
            {
                b.Property<short>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("SMALLINT")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("EmailAddress")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(126)")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("HomeUrl")
                 .HasColumnType("TEXT");

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<string>("Name")
                 .IsRequired()
                 .HasColumnType("VARCHAR(126)");

                b.Property<string>("TwitterHandle")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(126)")
                 .HasDefaultValueSql("NULL");

                b.HasKey("Id");

                b.ToTable("maintainers");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.Rule", b =>
            {
                b.Property<int>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("INT")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("Raw")
                 .IsRequired()
                 .HasColumnType("LONGTEXT");

                b.HasKey("Id");

                b.ToTable("rules");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.Snapshot", b =>
            {
                b.Property<int>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("MEDIUMINT")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<short>("FilterListId");

                b.Property<short?>("HttpStatusCode")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("SMALLINT")
                 .HasDefaultValueSql("NULL");

                b.Property<byte[]>("Md5Checksum")
                 .HasColumnType("BINARY(16)");

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<bool>("WasSuccessful");

                b.Property<bool>("WasUpdated");

                b.Property<DateTime?>("WaybackTimestamp")
                 .HasColumnType("TIMESTAMP");

                b.Property<string>("WaybackUrl")
                 .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("FilterListId");

                b.ToTable("snapshots");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.Software", b =>
            {
                b.Property<short>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("SMALLINT")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("DownloadUrl")
                 .HasColumnType("TEXT");

                b.Property<string>("HomeUrl")
                 .HasColumnType("TEXT");

                b.Property<bool>("IsAbpSubscribable");

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<string>("Name")
                 .IsRequired()
                 .HasColumnType("VARCHAR(126)");

                b.HasKey("Id");

                b.ToTable("software");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.Syntax", b =>
            {
                b.Property<short>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("SMALLINT")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("DefinitionUrl")
                 .HasColumnType("TEXT");

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<string>("Name")
                 .IsRequired()
                 .HasColumnType("VARCHAR(126)");

                b.HasKey("Id");

                b.ToTable("syntaxes");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.Tag", b =>
            {
                b.Property<short>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("SMALLINT")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("Description")
                 .HasColumnType("TEXT");

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<string>("Name")
                 .IsRequired()
                 .HasColumnType("VARCHAR(126)");

                b.HasKey("Id");

                b.ToTable("tags");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.FilterList", b =>
            {
                b.HasOne("FilterLists.Domain.Entities.License", "License")
                 .WithMany("FilterLists")
                 .HasForeignKey("LicenseId");

                b.HasOne("FilterLists.Domain.Entities.Syntax", "Syntax")
                 .WithMany("FilterLists")
                 .HasForeignKey("SyntaxId");
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.Dependent", b =>
            {
                b.HasOne("FilterLists.Domain.Entities.FilterList", "DependencyFilterList")
                 .WithMany("DependencyFilterLists")
                 .HasForeignKey("DependencyFilterListId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Domain.Entities.FilterList", "DependentFilterList")
                 .WithMany("DependentFilterLists")
                 .HasForeignKey("DependentFilterListId")
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.FilterListLanguage", b =>
            {
                b.HasOne("FilterLists.Domain.Entities.FilterList", "FilterList")
                 .WithMany("FilterListLanguages")
                 .HasForeignKey("FilterListId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Domain.Entities.Language", "Language")
                 .WithMany("FilterListLanguages")
                 .HasForeignKey("LanguageId")
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.FilterListMaintainer", b =>
            {
                b.HasOne("FilterLists.Domain.Entities.FilterList", "FilterList")
                 .WithMany("FilterListMaintainers")
                 .HasForeignKey("FilterListId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Domain.Entities.Maintainer", "Maintainer")
                 .WithMany("FilterListMaintainers")
                 .HasForeignKey("MaintainerId")
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.FilterListTag", b =>
            {
                b.HasOne("FilterLists.Domain.Entities.FilterList", "FilterList")
                 .WithMany("FilterListTags")
                 .HasForeignKey("FilterListId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Domain.Entities.Tag", "Tag")
                 .WithMany("FilterListTags")
                 .HasForeignKey("TagId")
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.Fork", b =>
            {
                b.HasOne("FilterLists.Domain.Entities.FilterList", "ForkFilterList")
                 .WithMany("ForkFilterLists")
                 .HasForeignKey("ForkFilterListId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Domain.Entities.FilterList", "UpstreamFilterList")
                 .WithMany("UpstreamForkFilterLists")
                 .HasForeignKey("UpstreamFilterListId")
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.Merge", b =>
            {
                b.HasOne("FilterLists.Domain.Entities.FilterList", "MergeFilterList")
                 .WithMany("MergeFilterLists")
                 .HasForeignKey("MergeFilterListId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Domain.Entities.FilterList", "UpstreamFilterList")
                 .WithMany("UpstreamMergeFilterLists")
                 .HasForeignKey("UpstreamFilterListId")
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.SnapshotRule", b =>
            {
                b.HasOne("FilterLists.Domain.Entities.Rule", "Rule")
                 .WithMany("SnapshotRules")
                 .HasForeignKey("RuleId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Domain.Entities.Snapshot", "Snapshot")
                 .WithMany("SnapshotRules")
                 .HasForeignKey("SnapshotId")
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.SoftwareSyntax", b =>
            {
                b.HasOne("FilterLists.Domain.Entities.Software", "Software")
                 .WithMany("SoftwareSyntaxes")
                 .HasForeignKey("SoftwareId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Domain.Entities.Syntax", "Syntax")
                 .WithMany("SoftwareSyntaxes")
                 .HasForeignKey("SyntaxId")
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("FilterLists.Domain.Entities.Snapshot", b =>
            {
                b.HasOne("FilterLists.Domain.Entities.FilterList", "FilterList")
                 .WithMany("Snapshots")
                 .HasForeignKey("FilterListId")
                 .OnDelete(DeleteBehavior.Cascade);
            });
#pragma warning restore 612, 618
        }
    }
}