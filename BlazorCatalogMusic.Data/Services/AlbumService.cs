using BlazorCatalogMusic.Data.Context;
using BlazorCatalogMusic.Data.Services.IServices;
using BlazorCatalogMusic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCatalogMusic.Data.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly AlbumCatalogContext _albumCatalogContext;

        public AlbumService(AlbumCatalogContext albumCatalogContext)
        {
            _albumCatalogContext = albumCatalogContext;
        }

        public async Task<bool> DeleteAlbum(Album album)
        {
            _albumCatalogContext.Songs.RemoveRange(album.Songs);
            _albumCatalogContext.Albums.Remove(album);            

            return await _albumCatalogContext.SaveChangesAsync() > 0;
        }

        public async Task<Album> GetAlbum(int id)
        {
            var album = await _albumCatalogContext.Albums.Where(x => x.Id == id).Include(x => x.Songs).FirstOrDefaultAsync();

            return album;
        }

        public async Task<IEnumerable<Album>> GetAlbums()
        {
            return await _albumCatalogContext.Albums.ToListAsync();
        }

        public async Task<bool> InsertAlbum(Album album)
        {
            _albumCatalogContext.Add(album);

            return await _albumCatalogContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAlbum(Album album)
        {
            _albumCatalogContext.Update(album);

            return await _albumCatalogContext.SaveChangesAsync() > 0;
        }
    }
}
