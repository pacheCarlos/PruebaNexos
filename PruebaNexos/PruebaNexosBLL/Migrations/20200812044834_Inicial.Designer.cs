﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaNexosBLL.Context;

namespace PruebaNexosBLL.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20200812044834_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PruebaNexosBLL.Context.DoctorContext", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountNumber");

                    b.Property<string>("Hospital");

                    b.Property<string>("NameComplete");

                    b.Property<string>("Specialty");

                    b.HasKey("DoctorId");

                    b.ToTable("DoctorContexts");
                });

            modelBuilder.Entity("PruebaNexosBLL.Context.DoctorPatientContext", b =>
                {
                    b.Property<int>("DoctorId");

                    b.Property<int>("PatientId");

                    b.HasKey("DoctorId", "PatientId");

                    b.HasIndex("PatientId");

                    b.ToTable("DoctorPatientContexts");
                });

            modelBuilder.Entity("PruebaNexosBLL.Context.PatientContext", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameComplete");

                    b.Property<int>("Phone");

                    b.Property<int>("SocialSecurityNumber");

                    b.Property<int>("ZipCode");

                    b.HasKey("PatientId");

                    b.ToTable("PatientContexts");
                });

            modelBuilder.Entity("PruebaNexosBLL.Context.DoctorPatientContext", b =>
                {
                    b.HasOne("PruebaNexosBLL.Context.DoctorContext", "Doctor")
                        .WithMany("DoctorPatientContexts")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PruebaNexosBLL.Context.PatientContext", "Patient")
                        .WithMany("DoctorPatientContexts")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
