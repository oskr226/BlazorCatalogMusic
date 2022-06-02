using BlazorCatalogMusic.Data.Context;
using BlazorCatalogMusic.Data.Services.IServices;
using BlazorCatalogMusic.Models;
using System;
using System.Collections.Generic;
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

        public Task DeleteAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public Task<Album> GetAlbum(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Album>> GetAlbums()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAlbum(Album album)
        {
            _albumCatalogContext.Add(album);

            return await _albumCatalogContext.SaveChangesAsync() > 0;
        }

        public Task<bool> UpdateAlbum(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
