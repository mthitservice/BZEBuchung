using Microsoft.EntityFrameworkCore;
using BZEBuchung.Model;

namespace BZEBuchung.Data
{

    public class BuchungDbContext : DbContext
    {

        public DbSet<view_Buchungsliste> view_Buchungsliste { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL("server=pluto.mth-it-service.com;database=bzetrainer;user=bzetrainer;password=Bze!forDb2022");

        }





    }







}