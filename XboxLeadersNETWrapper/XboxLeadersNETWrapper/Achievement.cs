using System;
using System.Drawing;

namespace XboxLeadersNETWrapper
{
    /// <summary>
    /// Represents an achievement that has been earned by the gamer.
    /// </summary>
    public class Achievement
    {
        /// <summary>
        /// Gets or sets the achievement ID.
        /// </summary>
        public Int32 ID { get; set; }

        /// <summary>
        /// Gets or sets the achievement Title.
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// Gets or sets the achievement locked artwork.
        /// </summary>
        public Bitmap LockedArtwork { get; set; }

        /// <summary>
        /// Gets or sets the achievement unlocked artwork.
        /// </summary>
        public Bitmap UnlockedArtwork { get; set; }

        /// <summary>
        /// Gets or sets the achievement description.
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// Gets or sets the achievement gamer score.
        /// </summary>
        public Int32 GamerScore { get; set; }

        /// <summary>
        /// Gets or sets if the achievement is a secret.
        /// </summary>
        public Boolean Secret { get; set; }

        /// <summary>
        /// Gets or sets if the achievement has been unlocked.
        /// </summary>
        public Boolean Unlocked { get; set; }

        /// <summary>
        /// Gets or sets when the achievement has been unlocked.
        /// </summary>
        public DateTime UnlockedDate { get; set; }

        /// <summary>
        /// Gets or sets if the achievement was unlocked offline.
        /// </summary>
        public Boolean UnlockedOffline { get; set; }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.Achievement">Achievement</seealso> class.
        /// </summary>
        public Achievement()
        {

        }
    }
}
