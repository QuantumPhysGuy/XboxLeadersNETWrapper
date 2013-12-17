using System;
using System.Drawing;

namespace XboxLeadersNETWrapper
{
    /// <summary>
    /// Represents a game the gamer has played.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Gets or sets the game's ID.
        /// </summary>
        public Int32 ID { get; set; }

        /// <summary>
        /// Gets or sets the game's HID.
        /// </summary>
        public String HID { get; set; }

        /// <summary>
        /// Gets or sets the game's app identifier.
        /// </summary>
        public Boolean IsApp { get; set; }

        /// <summary>
        /// Gets or sets the game's title.
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// Gets or sets the game's artwork.
        /// </summary>
        public Bitmap Artwork { get; set; }

        /// <summary>
        /// Gets or sets the gamer's gamer score for this game.
        /// </summary>
        public GamerScore GamerScore { get; set; }

        /// <summary>
        /// Gets or sets the gamer's achievements for this game.
        /// </summary>
        public Achievements Achievements { get; set; }

        /// <summary>
        /// Gets or sets the progress of this game.
        /// </summary>
        public Double Progress { get; set; }

        /// <summary>
        /// Gets or sets the last time this game was ran.
        /// </summary>
        public DateTime LastPlayed { get; set; }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="XboxLeadersNETWrapper.Game">Game</seealso> class.
        /// </summary>
        public Game()
        {

        }
    }
}
