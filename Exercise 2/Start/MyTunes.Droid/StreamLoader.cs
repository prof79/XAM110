using System;
using System.IO;
using Android.Content;

namespace MyTunes
{
    public class StreamLoader
        : IStreamLoader
    {
        #region Fields

        private readonly Context _context;

        #endregion

        #region Constructors

        public StreamLoader(Context context)
            => _context = context;

        #endregion

        #region Interface IStreamLoader

        /// <inheritdoc />
        public Stream GetStreamForFileName(string fileName)
            => _context.Assets.Open(fileName);

        #endregion
    }
}
