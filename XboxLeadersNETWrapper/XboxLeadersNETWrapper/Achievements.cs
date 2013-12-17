using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XboxLeadersNETWrapper
{
    /// <summary>
    /// Represents an achievement.
    /// </summary>
    public class Achievements
    {
        /// <summary>
        /// Gets or sets the current achievements.
        /// </summary>
        public Int32 Current { get; set; }

        /// <summary>
        /// Gets or sets the total possible achievements.
        /// </summary>
        public Int32 Total { get; set; }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.Achievements">Achievements</seealso> class.
        /// </summary>
        public Achievements()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.Achievements">Achievements</seealso> class.
        /// </summary>
        /// <param name="Current">Current number of achievements.</param>
        /// <param name="Total">Total number of achievements.</param>
        public Achievements(Int32 Current, Int32 Total)
        {
            this.Current = Current;
            this.Total = Total;
        }
    }
}