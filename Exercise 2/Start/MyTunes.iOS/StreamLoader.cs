using System;
using System.IO;

namespace MyTunes
{
    public class StreamLoader
        : IStreamLoader
    {
        #region Interface IStreamLoader

        /// <inheritdoc />
        public Stream GetStreamForFileName(string fileName)
            => File.OpenRead(fileName);

        #endregion
    }
}
