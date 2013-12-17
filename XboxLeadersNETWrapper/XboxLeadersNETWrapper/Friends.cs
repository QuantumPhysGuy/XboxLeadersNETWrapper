using System;
using System.Drawing;
using System.Collections.Generic;

namespace XboxLeadersNETWrapper
{
    /// <summary>
    /// Represents the friend data for a gamer.
    /// </summary>
    public class Friends
    {
        /// <summary>
        /// Gets or sets the total number of friends.
        /// </summary>
        public Int32 Total { get; set; }

        /// <summary>
        /// Gets or sets the total number of online friends.
        /// </summary>
        public Int32 Online { get; set; }

        /// <summary>
        /// Gets or sets the total number of offline friends.
        /// </summary>
        public Int32 Offline { get; set; }

        /// <summary>
        /// Gets or sets the a list of friends.
        /// </summary>
        public List<Friend> GamerFriends { get; set; }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.Friends">Friends</seealso> class.
        /// </summary>
        public Friends()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.Friends">Friends</seealso> class.
        /// </summary>
        /// <param name="Total">Total number of friends.</param>
        /// <param name="Online">Total number of online friends.</param>
        /// <param name="Offline">Total number of offline friends.</param>
        /// <param name="Friends">List of friends.</param>
        public Friends(Int32 Total, Int32 Online, Int32 Offline, List<Friend> Friends)
        {
            this.Total = Total;
            this.Online = Online;
            this.Offline = Offline;
            this.GamerFriends = Friends;
        }
    }
}
