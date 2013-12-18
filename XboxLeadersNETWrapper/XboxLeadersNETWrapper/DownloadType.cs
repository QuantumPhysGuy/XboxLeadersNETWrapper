using System;

namespace XboxLeadersNETWrapper
{
    /// <summary>
    /// Represents a download type of search query.
    /// </summary>
    public class DownloadType
    {
        /// <summary>
        /// Gets or sets the class of the download.
        /// </summary>
        public String Class { get; set; }

        /// <summary>
        /// Gets or sets the title of the download.
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.DownloadType">DownloadType</seealso> class.
        /// </summary>
        public DownloadType()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.DownloadType">DownloadType</seealso> class.
        /// </summary>
        /// <param name="Class">The class of the download.</param>
        /// <param name="Title">The title of the download.</param>
        public DownloadType(String Class, String Title)
        {
            this.Class = Class;
            this.Title = Title;
        }
    }
}