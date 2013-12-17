using System;
using System.Drawing;
using System.Collections.Generic;

namespace XboxLeadersNETWrapper
{
    /// <summary>
    /// Represents a gamers profile.
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Gets or sets the gamer tag.
        /// </summary>
        public String GamerTag { get; set; }

        /// <summary>
        /// Gets or sets the gamer's avatar.
        /// </summary>
        public Bitmap Avatar { get; set; }

        /// <summary>
        /// Gets or sets the gamer score.
        /// </summary>
        public Int32 GamerScore { get; set; }

        /// <summary>
        /// Gets or sets the gamer's reputation.
        /// </summary>
        public Int32 Reputation { get; set; }

        /// <summary>
        /// Gets or sets the gamer's presence.
        /// </summary>
        public String Presence { get; set; }

        /// <summary>
        /// Gets or sets the gamer's online status.
        /// </summary>
        public Boolean Online { get; set; }

        /// <summary>
        /// Gets or sets the gamer's motto.
        /// </summary>
        public String Motto { get; set; }

        /// <summary>
        /// Gets or sets the gamer's name.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Gets or sets the gamer's location.
        /// </summary>
        public String Location { get; set; }

        /// <summary>
        /// Gets or sets the gamer's biography.
        /// </summary>
        public String Biography { get; set; }

        /// <summary>
        /// Gets or sets the gamer's recent activity.
        /// </summary>
        public List<Activity> RecentActivity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.Profile">Profile</seealso> class.
        /// </summary>
        public Profile()
        {

        }
    }
}