using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizeMusic
{
    class MP3
    {
        public string path { get; set; }
        public string destination { get; set; }

        public MP3(string path, string destination)
        {
            this.path = path;
            this.destination = destination;
        }

        public void sortFile()
        {
            TagLib.File musicFile = TagLib.File.Create(this.path);

            var title = musicFile.Tag.Title;
            var artist = musicFile.Tag.FirstPerformer;
            var albumArtist = musicFile.Tag.FirstAlbumArtist;

            if (artist == null && albumArtist != null)
            {
                artist = albumArtist;
                //musicFile.Tag.Performers = musicFile.Tag.AlbumArtists;
            }
            var album = musicFile.Tag.Album;

            //musicFile.Tag.Comment = "";
            //musicFile.Tag.Lyrics = "";
            //musicFile.Save();

            string finalPath = this.destination + System.IO.Path.DirectorySeparatorChar;

            if (artist != null)
            {
                finalPath += artist + System.IO.Path.DirectorySeparatorChar;
            }
            else
            {
                finalPath += "Unknown Artist" + System.IO.Path.DirectorySeparatorChar;
            }
            
            if (album != null)
            {
                finalPath += album + System.IO.Path.DirectorySeparatorChar;
            }

            if (!System.IO.Directory.Exists(finalPath))
            {
                System.IO.Directory.CreateDirectory(finalPath);
            }

            if (title != null && !Validate.HasSpecialCharacters(ref title))
            {
                finalPath += title + ".mp3";
            }
            else
            {
                finalPath += this.path.Split(System.IO.Path.DirectorySeparatorChar).Last();
            }

            try
            {
                System.IO.File.Copy(this.path, finalPath, false);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("Exception Caught: {0}", e);
                System.Console.WriteLine(finalPath);
            }
        }
    }
}
