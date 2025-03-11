﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VoLong_API.Context;

#nullable disable

namespace VoLong_API.Migrations
{
    [DbContext(typeof(LopHocContext))]
    partial class LopHocContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VoLong_API.Entities.Lop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("TruongHocId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TruongHocId");

                    b.ToTable("LopMua", (string)null);
                });

            modelBuilder.Entity("VoLong_API.Entities.SinhVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LopId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LopId");

                    b.ToTable("SinhVienTruongMua", (string)null);
                });

            modelBuilder.Entity("VoLong_API.Entities.SinhVienSubject", b =>
                {
                    b.Property<int>("SinhVienId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<double>("FifteenMinutesPoint")
                        .HasColumnType("float");

                    b.Property<double>("OralTestScores")
                        .HasColumnType("float");

                    b.Property<double>("ScoreOnePeriod")
                        .HasColumnType("float");

                    b.Property<double>("SemesterExamScore")
                        .HasColumnType("float");

                    b.HasKey("SinhVienId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("SinhVienSubject", (string)null);
                });

            modelBuilder.Entity("VoLong_API.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subject", (string)null);
                });

            modelBuilder.Entity("VoLong_API.Entities.TruongHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Establish")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hotline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TruongMua", (string)null);
                });

            modelBuilder.Entity("VoLong_API.Entities.Lop", b =>
                {
                    b.HasOne("VoLong_API.Entities.TruongHoc", "truongHocs")
                        .WithMany("Lops")
                        .HasForeignKey("TruongHocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("truongHocs");
                });

            modelBuilder.Entity("VoLong_API.Entities.SinhVien", b =>
                {
                    b.HasOne("VoLong_API.Entities.Lop", "LopHoc")
                        .WithMany("sinhViens")
                        .HasForeignKey("LopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LopHoc");
                });

            modelBuilder.Entity("VoLong_API.Entities.SinhVienSubject", b =>
                {
                    b.HasOne("VoLong_API.Entities.SinhVien", "SinhVien")
                        .WithMany("SinhVienSubjects")
                        .HasForeignKey("SinhVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VoLong_API.Entities.Subject", "Subject")
                        .WithMany("SinhVienSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SinhVien");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("VoLong_API.Entities.Lop", b =>
                {
                    b.Navigation("sinhViens");
                });

            modelBuilder.Entity("VoLong_API.Entities.SinhVien", b =>
                {
                    b.Navigation("SinhVienSubjects");
                });

            modelBuilder.Entity("VoLong_API.Entities.Subject", b =>
                {
                    b.Navigation("SinhVienSubjects");
                });

            modelBuilder.Entity("VoLong_API.Entities.TruongHoc", b =>
                {
                    b.Navigation("Lops");
                });
#pragma warning restore 612, 618
        }
    }
}
