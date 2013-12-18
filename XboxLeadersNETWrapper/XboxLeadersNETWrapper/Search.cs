using System;
using System.Collections.Generic;

namespace XboxLeadersNETWrapper
{
    /// <summary>
    /// Represents a search query.
    /// </summary>
    public class Search
    {
        /// <summary>
        /// Gets or sets the total results of the query.
        /// </summary>
        public Int32 TotalResults { get; set; }

        /// <summary>
        /// Gets or sets the link of the result query.
        /// </summary>
        public Uri ResultsLink { get; set; }

        /// <summary>
        /// Gets or sets the results of the search query.
        /// </summary>
        public List<SearchResult> Results { get; set; }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.Search">Search</seealso> class.
        /// </summary>
        public Search()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.Search">Search</seealso> class.
        /// </summary>
        /// <param name="TotalResults">The total results of the query.</param>
        /// <param name="ResultsLink">The link of the result query.</param>
        /// <param name="Results">The results of the search query.</param>
        public Search(Int32 TotalResults, Uri ResultsLink, List<SearchResult> Results)
        {
            this.TotalResults = TotalResults;
            this.ResultsLink = ResultsLink;
            this.Results = Results;
        }
    }
}