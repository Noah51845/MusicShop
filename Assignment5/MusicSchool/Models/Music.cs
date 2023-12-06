using System.ComponentModel.DataAnnotations;
namespace MusicSchool.Models
{
    public class Music
    {
        public required int MusicId { get; set; }
        public string SongTitle { get; set; }
        public string Genre { get; set; }
        public string Perfomer { get; set; }


    }
}
