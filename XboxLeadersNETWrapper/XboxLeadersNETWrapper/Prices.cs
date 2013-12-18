using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XboxLeadersNETWrapper
{
    /// <summary>
    /// Represents a price of a download of a search query.
    /// </summary>
    public class Prices
    {
        /// <summary>
        /// Gets or sets the silver download price.
        /// </summary>
        public String Silver { get; set; }

        /// <summary>
        /// Gets or sets the gold download price.
        /// </summary>
        public String Gold { get; set; }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.Prices">Prices</seealso> class.
        /// </summary>
        public Prices()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.Prices">Prices</seealso> class.
        /// </summary>
        /// <param name="Silver">The silver download price.</param>
        /// <param name="Gold">The gold download price.</param>
        public Prices(String Silver, String Gold)
        {
            this.Silver = Silver;
            this.Gold = Gold;
        }
    }
}