using BlazorCatalogMusic.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCatalogMusic.Data.Services.IServices
{
    public interface IAlbumService
    {
        Task<IEnumerable<Album>> GetAlbums();
        Task<Album> GetAlbum(int id);
        Task<bool> InsertAlbum(Album album);
        Task<bool> UpdateAlbum(Album album);
        Task<bool> DeleteAlbum(Album album);
    }
}
