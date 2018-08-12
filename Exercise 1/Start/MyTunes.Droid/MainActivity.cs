using System.Linq;
using Android.App;
using Android.OS;

namespace MyTunes
{
	[Activity(Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : ListActivity
	{
		protected override async void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

            //ListAdapter = new ListAdapter<string>() {
            //	DataSource = new[] { "One", "Two", "Three" }
            //};

            var songs = await SongLoader.Load();

            var songList = songs.ToList();

            var songListAdapter = new ListAdapter<Song>()
            {
                DataSource = songList,
                TextProc = (s) => s.Name,
                DetailTextProc = (s) => $"{s.Artist} - {s.Album}",
            };

            ListAdapter = songListAdapter;
        }
	}
}
