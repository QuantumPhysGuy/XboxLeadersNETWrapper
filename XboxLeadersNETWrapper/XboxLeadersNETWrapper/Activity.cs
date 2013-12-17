using System;
using System.Drawing;

namespace XboxLeadersNETWrapper
{
    /// <summary>
    /// Represents an activity the gamer has performed.
    /// </summary>
    public class Activity
    {
        /// <summary>
        /// Gets or sets the activity's ID.
        /// </summary>
        public Int32 ID { get; set; }

        /// <summary>
        /// Gets or sets the activity's HID.
        /// </summary>
        public String HID { get; set; }

        /// <summary>
        /// Gets or sets the activity's app identifier.
        /// </summary>
        public Boolean IsApp { get; set; }

        /// <summary>
        /// Gets or sets the activity's title.
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// Gets or sets the activity's artwork.
        /// </summary>
        public Bitmap Artwork { get; set; }

        /// <summary>
        /// Gets or sets the gamer's gamer score for this activity.
        /// </summary>
        public GamerScore GamerScore { get; set; }

        /// <summary>
        /// Gets or sets the gamer's achievements for this activity.
        /// </summary>
        public Achievements Achievements { get; set; }

        /// <summary>
        /// Gets or sets the progress of this activity.
        /// </summary>
        public Double Progress { get; set; }

        /// <summary>
        /// Gets or sets the last time this activity was ran.
        /// </summary>
        public DateTime LastPlayed { get; set; }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.Activity">Activity</seealso> class.
        /// </summary>
        public Activity()
        {

        }
    }
}
