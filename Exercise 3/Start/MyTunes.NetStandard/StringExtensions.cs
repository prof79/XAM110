using System;
using System.Net.Http;

namespace MyTunes
{
    public static class StringExtensions
    {
        public static string RuinSongName(this string name)
            => name.Replace("Crocodile", "Alligator");

        public static HttpClient HttpClient;
    }
}
