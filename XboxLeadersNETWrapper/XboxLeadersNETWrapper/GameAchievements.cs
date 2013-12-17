using System;
using System.Collections.Generic;

namespace XboxLeadersNETWrapper
{
    /// <summary>
    /// Represents the gamer's achievements.
    /// </summary>
    public class GameAchievements
    {
        /// <summary>
        /// Gets or sets the gamertag.
        /// </summary>
        public String GamerTag { get; set; }

        /// <summary>
        /// Gets or sets game's name.
        /// </summary>
        public String GameName { get; set; }

        /// <summary>
        /// Gets or sets the game's ID.
        /// </summary>
        public Int32 ID { get; set; }

        /// <summary>
        /// Gets or sets the gamer's HID.
        /// </summary>
        public String HID { get; set; }

        /// <summary>
        /// Gets or sets the gamer score.
        /// </summary>
        public GamerScore GamerScore { get; set; }

        /// <summary>
        /// Gets or sets the achievements.
        /// </summary>
        public Achievements Achievements { get; set; }

        /// <summary>
        /// Gets or sets a list of a achievements for the game.
        /// </summary>
        public List<Achievement> AchievementList { get; set; }

        /// <summary>
        /// Gets or sets the progress of the game.
        /// </summary>
        public Double Progress { get; set; }

        /// <summary>
        /// Gets or sets the when the game was last played.
        /// </summary>
        public DateTime LastPlayed { get; set; }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.GameAchievements">GameAchievements</seealso> class.
        /// </summary>
        public GameAchievements()
        {

        }
    }
}
