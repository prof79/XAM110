using System;
using System.IO;
using Windows.ApplicationModel;

namespace MyTunes
{
    public class StreamLoader
        : IStreamLoader
    {
        #region Interface IStreamLoader

        /// <inheritdoc />
        public Stream GetStreamForFileName(string fileName)
        {
            var location = Package.Current.InstalledLocation;

            var fileResult =
                location
                    .GetFileAsync(fileName)
                    .AsTask()
                    .Result;

            return
                fileResult
                    .OpenStreamForReadAsync()
                    .Result;
        }

        #endregion
    }
}
