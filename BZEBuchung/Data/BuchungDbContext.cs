using Microsoft.EntityFrameworkCore;
using BZEBuchung.Model;

namespace BZEBuchung.Data
{

    public class BuchungDbContext : DbContext
    {


        public DbSet<tab_buch_log> tab_buch_log { get; set; }
        public DbSet<tab_buch_buchung> tab_buch_buchung { get; set; }
        public DbSet<view_Buchungsliste> view_Buchungsliste { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL("server=pluto.mth-it-service.com;database=bzetrainer;user=bzetrainer;password=Bze!forDb2022");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<tab_buch_log>().HasIndex(e => e.LogDate);



        }







    }







}