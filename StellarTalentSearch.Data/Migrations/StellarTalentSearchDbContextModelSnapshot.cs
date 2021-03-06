// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StellarTalentSearch.Data;

namespace StellarTalentSearch.Data.Migrations
{
    [DbContext(typeof(StellarTalentSearchDbContext))]
    partial class StellarTalentSearchDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StellarTalentSearch.Domain.DescriptionItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("JobDescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("JobDescriptionId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("JobDescriptionId2")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("JobDescriptionId3")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobDescriptionId");

                    b.HasIndex("JobDescriptionId1");

                    b.HasIndex("JobDescriptionId2");

                    b.HasIndex("JobDescriptionId3");

                    b.ToTable("DescriptionItems");
                });

            modelBuilder.Entity("StellarTalentSearch.Domain.JobDescription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobDescriptions");
                });

            modelBuilder.Entity("StellarTalentSearch.Domain.JobVacancy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PositionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("JobVacancies");
                });

            modelBuilder.Entity("StellarTalentSearch.Domain.Position", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobDescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobDescriptionId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("StellarTalentSearch.Domain.DescriptionItem", b =>
                {
                    b.HasOne("StellarTalentSearch.Domain.JobDescription", null)
                        .WithMany("Attributes")
                        .HasForeignKey("JobDescriptionId");

                    b.HasOne("StellarTalentSearch.Domain.JobDescription", null)
                        .WithMany("Capabilities")
                        .HasForeignKey("JobDescriptionId1");

                    b.HasOne("StellarTalentSearch.Domain.JobDescription", null)
                        .WithMany("Requirements")
                        .HasForeignKey("JobDescriptionId2");

                    b.HasOne("StellarTalentSearch.Domain.JobDescription", null)
                        .WithMany("Responsibilities")
                        .HasForeignKey("JobDescriptionId3");
                });

            modelBuilder.Entity("StellarTalentSearch.Domain.JobVacancy", b =>
                {
                    b.HasOne("StellarTalentSearch.Domain.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");
                });

            modelBuilder.Entity("StellarTalentSearch.Domain.Position", b =>
                {
                    b.HasOne("StellarTalentSearch.Domain.JobDescription", "JobDescription")
                        .WithMany()
                        .HasForeignKey("JobDescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobDescription");
                });

            modelBuilder.Entity("StellarTalentSearch.Domain.JobDescription", b =>
                {
                    b.Navigation("Attributes");

                    b.Navigation("Capabilities");

                    b.Navigation("Requirements");

                    b.Navigation("Responsibilities");
                });
#pragma warning restore 612, 618
        }
    }
}
