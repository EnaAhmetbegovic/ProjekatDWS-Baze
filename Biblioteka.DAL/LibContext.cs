using Biblioteka.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Biblioteka.DAL
{
    public class LibContext : DbContext
    {
        public LibContext() : base() { }

        public DbSet<Autor> Autori { get; set; }
        public DbSet<Knjiga> Knjige { get; set; }
        public DbSet<Izdavac> Izdavaci { get; set; }
        public DbSet<AutorKnjiga> AutKnjige { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=195.130.32.34,1032;Database=Biblioteka;User Id=sa; Password=pmf911; Integrated Security=False"
            );

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           // builder.Entity<AutorKnjiga>().HasKey(ak => new { ak.AutorId, ak.KnjigaId });
           /* builder.Entity<Autor>().HasQueryFilter(x => !x.Obrisan);
            builder.Entity<Knjiga>().HasQueryFilter(x => !x.Obrisan);
            builder.Entity<Izdavac>().HasQueryFilter(x => !x.Obrisan);*/
        }
        /* 
        public override int SaveChanges()
        {
           foreach (var entry in ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted && x.Entity is BaznaKlasa))
            {
                entry.State = EntityState.Modified;
                entry.CurrentValues["Obrisan"] = true;
            }
            return base.SaveChanges();
    }*/

    }
}
