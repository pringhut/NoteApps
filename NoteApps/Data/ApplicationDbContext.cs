using Microsoft.EntityFrameworkCore;
using NoteApps.Models;
using System.Collections.Generic;

namespace NoteApps.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<NoteItem> NoteItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=NoteDB;Trusted_Connection=True;");
        }
    }
}
