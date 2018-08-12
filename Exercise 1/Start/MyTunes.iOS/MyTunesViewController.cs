using System.Linq;
using UIKit;

namespace MyTunes
{
	public class MyTunesViewController : UITableViewController
	{
		public override void ViewDidLayoutSubviews()
		{
			base.ViewDidLayoutSubviews();

			TableView.ContentInset = new UIEdgeInsets (20, 0, 0, 0);
		}

		public override async void ViewDidLoad()
		{
			base.ViewDidLoad();

            //TableView.Source = new ViewControllerSource<string>(TableView) {
            //	DataSource = new string[] { "One", "Two", "Three" },
            //};

            var songs = await SongLoader.Load();

            var songList = songs.ToList();

            var viewControllerSource = new ViewControllerSource<Song>(TableView);

            viewControllerSource.DataSource = songList;
            viewControllerSource.TextProc = (s) => s.Name;
            viewControllerSource.DetailTextProc = (s) => $"{s.Artist} - {s.Album}";
        }
    }
}
