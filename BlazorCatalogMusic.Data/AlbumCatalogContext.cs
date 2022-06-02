using BlazorCatalogMusic.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCatalogMusic.Data.Context
{
    public class AlbumCatalogContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=OSKRACERPC;Initial Catalog=AlbumMusicCatalog;Integrated Security=True");
        }
    }
}
