﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonusProject.Server.Data;

#nullable disable

namespace MonusProject.Server.Migrations
{
    [DbContext(typeof(ColloquioContext))]
    [Migration("20231020140039_probablywontwork")]
    partial class probablywontwork
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CandidatoSkill", b =>
                {
                    b.Property<int>("CandidatiSkillatiCandidatoId")
                        .HasColumnType("int");

                    b.Property<int>("SkillsSkillId")
                        .HasColumnType("int");

                    b.HasKey("CandidatiSkillatiCandidatoId", "SkillsSkillId");

                    b.HasIndex("SkillsSkillId");

                    b.ToTable("CandidatoSkill");
                });

            modelBuilder.Entity("DipendenteSkill", b =>
                {
                    b.Property<int>("DipendentiSkillatiDipendenteId")
                        .HasColumnType("int");

                    b.Property<int>("SkillsSkillId")
                        .HasColumnType("int");

                    b.HasKey("DipendentiSkillatiDipendenteId", "SkillsSkillId");

                    b.HasIndex("SkillsSkillId");

                    b.ToTable("DipendenteSkill");
                });

            modelBuilder.Entity("MonusProject.Client.Shared.Models.Candidato", b =>
                {
                    b.Property<int>("CandidatoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandidatoId"));

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CandidatoId");

                    b.ToTable("Candidati");
                });

            modelBuilder.Entity("MonusProject.Client.Shared.Models.Colloquio", b =>
                {
                    b.Property<int>("ColloquioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColloquioId"));

                    b.Property<int>("CandidatoId")
                        .HasColumnType("int");

                    b.Property<int>("DipendenteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RaiseTimeUTC")
                        .HasColumnType("datetime2");

                    b.HasKey("ColloquioId");

                    b.ToTable("Colloqui");
                });

            modelBuilder.Entity("MonusProject.Client.Shared.Models.Dipendente", b =>
                {
                    b.Property<int>("DipendenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DipendenteId"));

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SedeId")
                        .HasColumnType("int");

                    b.Property<int>("SedeName")
                        .HasColumnType("int");

                    b.HasKey("DipendenteId");

                    b.HasIndex("SedeId");

                    b.ToTable("Dipendenti");
                });

            modelBuilder.Entity("MonusProject.Client.Shared.Models.Sede", b =>
                {
                    b.Property<int>("SedeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SedeId"));

                    b.Property<string>("Indirizzo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SedeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SedeId");

                    b.ToTable("Sedi");
                });

            modelBuilder.Entity("MonusProject.Client.Shared.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillId"));

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("CandidatoSkill", b =>
                {
                    b.HasOne("MonusProject.Client.Shared.Models.Candidato", null)
                        .WithMany()
                        .HasForeignKey("CandidatiSkillatiCandidatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonusProject.Client.Shared.Models.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsSkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DipendenteSkill", b =>
                {
                    b.HasOne("MonusProject.Client.Shared.Models.Dipendente", null)
                        .WithMany()
                        .HasForeignKey("DipendentiSkillatiDipendenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonusProject.Client.Shared.Models.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsSkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MonusProject.Client.Shared.Models.Dipendente", b =>
                {
                    b.HasOne("MonusProject.Client.Shared.Models.Sede", null)
                        .WithMany("Dipendents")
                        .HasForeignKey("SedeId");
                });

            modelBuilder.Entity("MonusProject.Client.Shared.Models.Sede", b =>
                {
                    b.Navigation("Dipendents");
                });
#pragma warning restore 612, 618
        }
    }
}
