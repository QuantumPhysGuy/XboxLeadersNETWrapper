using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XboxLeadersNETWrapper
{
    /// <summary>
    /// Represents a GamerScore.
    /// </summary>
    public class GamerScore
    {
        /// <summary>
        /// Gets or sets the current GamerScore.
        /// </summary>
        public Int32 Current { get; set; }

        /// <summary>
        /// Gets or sets the total possible GamerScore.
        /// </summary>
        public Int32 Total { get; set; }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.GamerScore">GamerScore</seealso> class.
        /// </summary>
        public GamerScore()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.GamerScore">GamerScore</seealso> class.
        /// </summary>
        /// <param name="Current">Current GamerScore.</param>
        /// <param name="Total">Total possible GamerScore.</param>
        public GamerScore(Int32 Current, Int32 Total)
        {
            this.Current = Current;
            this.Total = Total;
        }
    }
}
