using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCore
{
    public class ArtistModel
    {
        public ArtistModel()
        {
            Albums = new HashSet<AlbumModel>();

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<AlbumModel> Albums { get; set; }
    }


        public class AlbumModel
         {
             public AlbumModel()
             {
                Artists = new HashSet<ArtistModel>();
            }
            public string AlbumName { get; set; }
            public virtual ICollection<ArtistModel> Artists { get; set; }
        }


   public class ArtistAlbum
    {
        public ArtistAlbum()
        {

        }

        public virtual AlbumModel Album { get; set; }
        public virtual ArtistModel Artist {get; set;}



    }
}
