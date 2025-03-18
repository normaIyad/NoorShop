using Microsoft.EntityFrameworkCore;
using NoorShop.API.Models;

namespace NoorShop.API.Database
{
    public class applecationDatabase : DbContext
    {
        public applecationDatabase(DbContextOptions<applecationDatabase> options)
       : base(options)
        {
        }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=.;Database=Tshop10 ;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        //}
        public DbSet<Catigory> catigories { get; set; }
    }
}
