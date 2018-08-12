using System;

namespace MyTunes.NetStandard
{
    public static class SongNameExtensions
    {
        public static string RuinSongName(this string songName)
        {
            return songName.Replace("Crocodile", "Alligator");
        }
    }
}
