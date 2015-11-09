using System.Data.Entity;

namespace Misdirection.Models
{
    public class MisdirectionEntities : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Artist> Artists { get; set; }

        //public DbSet<Artist> Artists { get; set; }
    }
}