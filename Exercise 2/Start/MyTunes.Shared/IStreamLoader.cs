using System.IO;

namespace MyTunes
{
    public interface IStreamLoader
    {
        /// <summary>
        /// Gets the stream for a given file name.
        /// </summary>
        /// <param name="fileName">
        /// The file name and path in string form.
        /// </param>
        /// <returns>
        /// A <see cref="Stream"/> for reading from the file.
        /// </returns>
        Stream GetStreamForFileName(string fileName);
    }
}
