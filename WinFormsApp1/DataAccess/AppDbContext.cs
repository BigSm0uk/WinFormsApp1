using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;

namespace WinFormsApp1.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Mesures> Mesures { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 

            optionsBuilder.UseSqlite("Data Source=Mesures.db"); 

        }

        public void InitDb()
        {

            var mesures = new List<Mesures>
        {
            new Mesures { Id = Guid.NewGuid(), Field = 1, Name = "Measure 1", Description = "Description 1", State = "State 1" },
            new Mesures { Id = Guid.NewGuid(), Field = 2, Name = "Measure 2", Description = "Description 2", State = "State 2" },
            new Mesures { Id = Guid.NewGuid(), Field = 3, Name = "Measure 3", Description = "Description 3", State = "State 3" },
            new Mesures { Id = Guid.NewGuid(), Field = 4, Name = "Measure 4", Description = "Description 4", State = "State 4" },
            new Mesures { Id = Guid.NewGuid(), Field = 5, Name = "Measure 5", Description = "Description 5", State = "State 5" },
            new Mesures { Id = Guid.NewGuid(), Field = 6, Name = "Measure 6", Description = "Description 6", State = "State 6" },
            new Mesures { Id = Guid.NewGuid(), Field = 7, Name = "Measure 7", Description = "Description 7", State = "State 7" },
            new Mesures { Id = Guid.NewGuid(), Field = 8, Name = "Measure 8", Description = "Description 8", State = "State 8" },
            new Mesures { Id = Guid.NewGuid(), Field = 9, Name = "Measure 9", Description = "Description 9", State = "State 9" },
            new Mesures { Id = Guid.NewGuid(), Field = 10, Name = "Measure 10", Description = "Description 10", State = "State 10" }
        };

            EnsureCreated();
            Mesures.AddRange(mesures);
            SaveChanges();
        }

        public void EnsureCreated()
        {
            DeleteDatabase();
            Database.EnsureCreated();
        }

        public void DeleteDatabase()
        {
            Database.EnsureDeleted();
        }
    }
}
