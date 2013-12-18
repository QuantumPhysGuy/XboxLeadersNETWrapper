using System;
using System.Drawing;

namespace XboxLeadersNETWrapper
{
    /// <summary>
    /// Represents a search result of a search query.
    /// </summary>
    public class SearchResult
    {
        /// <summary>
        /// Gets or sets the title of the result.
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// Gets or sets the parent of the result.
        /// </summary>
        public String Parent { get; set; }

        /// <summary>
        /// Gets or sets the link of the result.
        /// </summary>
        public Uri Link { get; set; }

        /// <summary>
        /// Gets or sets the image of the result.
        /// </summary>
        public Bitmap Image { get; set; }

        /// <summary>
        /// Gets or sets the download type of the result.
        /// </summary>
        public DownloadType DownloadType { get; set; }

        /// <summary>
        /// Gets or sets the price of the download of the result.
        /// </summary>
        public Prices Prices { get; set; }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.SearchResult">SearchResult</seealso> class.
        /// </summary>
        public SearchResult()
        {

        }
    }
}