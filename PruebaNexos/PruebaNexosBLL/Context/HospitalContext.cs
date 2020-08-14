using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;

namespace PruebaNexosBLL.Context
{
    public class HospitalContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer(@"Server=DESKTOP-FGE587Q\SQLExpress;Database=PruebaNexosDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoctorPatientContext>()
                .HasKey(bc => new { bc.DoctorId, bc.PatientId });
            modelBuilder.Entity<DoctorPatientContext>()
                .HasOne(bc => bc.Doctor)
                .WithMany(b => b.DoctorPatientContexts)
                .HasForeignKey(bc => bc.DoctorId);
            modelBuilder.Entity<DoctorPatientContext>()
                .HasOne(bc => bc.Patient)
                .WithMany(c => c.DoctorPatientContexts)
                .HasForeignKey(bc => bc.PatientId);
        }

        public DbSet<PatientContext> PatientContexts { get; set; }
        public DbSet<DoctorContext> DoctorContexts { get; set; }
        public DbSet<DoctorPatientContext> DoctorPatientContexts { get; set; }
    }
}
