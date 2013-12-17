using System;
using System.Collections.Generic;

namespace XboxLeadersNETWrapper
{
    /// <summary>
    /// Represents all the games the gamer has played.
    /// </summary>
    public class Games
    {
        /// <summary>
        /// Gets or sets the gamer tag.
        /// </summary>
        public String GamerTag { get; set; }

        /// <summary>
        /// Gets or sets the gamer's gamer score.
        /// </summary>
        public GamerScore GamerScore { get; set; }

        /// <summary>
        /// Gets or sets the gamer's achievements.
        /// </summary>
        public Achievements Achievements { get; set; }

        /// <summary>
        /// Gets or sets the gamer's total played games.
        /// </summary>
        public Int32 TotalGames { get; set; }

        /// <summary>
        /// Gets or sets the gamer's overall game progress.
        /// </summary>
        public Double Progress { get; set; }

        /// <summary>
        /// Gets or sets the gamer's played games.
        /// </summary>
        public List<Game> PlayedGames { get; set; }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.Games">Games</seealso> class.
        /// </summary>
        public Games()
        {

        }
    }
}