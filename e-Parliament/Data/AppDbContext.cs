using e_Parliament.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.DbContextApp
{
    internal class AppDbContext : DbContext
    {
        public string connectionString { get; }
        public DbSet<AccountType> account_types { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<DocumentType> document_types { get; set; }
        public DbSet<MeetingDocument> meeting_documents { get; set; }
        public DbSet<Commission> commissions { get; set; }
        public DbSet<Meeting> meetings { get; set; }
        public DbSet<CommissionMember> commission_members { get; set; }
        public DbSet<ParlamentarCommission> parliament_members { get; set; }
        public DbSet<ParlamentarGroupMembers> parlamentar_group_members { get; set; }
        public DbSet<ParliamentariansMember> parliamentarians_members { get; set; }
        public DbSet<Parliamentarian> parliamentarians { get; set; }
        public DbSet<Legislature> legislatures { get; set; }
        public DbSet<ParlamentarGroup> parlamentar_groups { get; set; }
        public DbSet<RoomType> room_types { get; set; }
        public DbSet<MeetingAtendace> meeting_attendaces { get; set; }

        public AppDbContext()
        {
            connectionString = "Host=localhost;Database=e_Parliament;Username=postgres;Password=admin";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
            //pg connection string
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AccountType>()
           .Property(e => e.typeName)
           .HasConversion<string>();

            modelBuilder.Entity<DocumentType>().Property(e => e.documentType).HasConversion<string>();

            modelBuilder.Entity<DocumentType>().HasIndex(e => e.documentType).IsUnique();
            //make the documentType unique we dont want to have the same document type more than once
            //for example we have id 1 - 100 for pdf
            //we only need one document type for each document type
            //id = 1 pdf, id = 2 word, etc


        }
    }
}
