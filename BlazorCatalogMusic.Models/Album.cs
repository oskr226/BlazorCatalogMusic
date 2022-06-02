using System;
using System.Collections.Generic;

namespace BlazorCatalogMusic.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public byte[] CoverImage { get; set; }
        public string Author { get; set; }
        public List<Song> Songs { get; set; }
    }
}
