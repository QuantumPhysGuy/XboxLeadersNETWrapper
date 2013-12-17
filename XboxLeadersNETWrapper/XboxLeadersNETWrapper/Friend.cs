using System;
using System.Drawing;

namespace XboxLeadersNETWrapper
{
    /// <summary>
    /// Represents a friend.
    /// </summary>
    public class Friend
    {
        /// <summary>
        /// Gets or sets the gamer tag.
        /// </summary>
        public String GamerTag { get; set; }

        /// <summary>
        /// Gets or sets the gamer's picture.
        /// </summary>
        public Bitmap GamerPic { get; set; }

        /// <summary>
        /// Gets or sets the gamer's gamer score.
        /// </summary>
        public Int32 GamerScore { get; set; }

        /// <summary>
        /// Gets or sets the gamer's online status.
        /// </summary>
        public Boolean Online { get; set; }

        /// <summary>
        /// Gets or sets the gamer's status.
        /// </summary>
        public String Status { get; set; }

        /// <summary>
        /// Gets or sets when the gamer was last seen online.
        /// </summary>
        public DateTime LastSeen { get; set; }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.Friend">Friend</seealso> class.
        /// </summary>
        public Friend()
        {

        }
    }
}
