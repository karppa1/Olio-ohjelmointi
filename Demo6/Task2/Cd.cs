using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Cd
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public List<Track> Tracks;

        public Cd()
        {
            Tracks = new List<Track>();
        }
        public void NewTrack(Track track)
        {
            Tracks.Add(track);
        }

        public override string ToString()
        {
            string data = " ** CD **";
            data += "\nArtist: " + Artist + "\nName: " + Name;
            data += "\n\nTracks:";

            foreach (Track track in Tracks)
            {
                if (track != null) data += "\n" + track.ToString();
            }
            return data;
        }
    }
}
