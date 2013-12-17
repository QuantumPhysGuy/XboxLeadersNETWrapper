using System;
using System.IO;
using System.Net;
using System.Xml;
using System.Drawing;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace XboxLeadersNETWrapper
{
    /// <summary>
    /// Provides easy access to the XboxLeaders API.
    /// </summary>
    public static class XboxLeadersAPI
    {
        /// <summary>
        /// Downloads the profile data for a the specified gamer tag.
        /// </summary>
        /// <param name="sGamerTag">The gamer tag to download profile data for.</param>
        /// <returns>Returns a <seealso cref="XboxLeadersAPI.Profile">Profile</seealso> object.</returns>
        public static Profile DownloadProfileData(String sGamerTag)
        {
            WebClient wcDownloader = new WebClient();
            Profile pDownloadedProfile = new Profile();
            XmlDocument xProfile = new XmlDocument();
            XmlReader xReader;
            XElement xJSONRoot;
            Byte[] bJSONData;            
            
            bJSONData = System.Text.Encoding.ASCII.GetBytes(wcDownloader.DownloadString("https://www.xboxleaders.com/api/profile.json?gamertag=" + sGamerTag));

            xReader = JsonReaderWriterFactory.CreateJsonReader(bJSONData, new XmlDictionaryReaderQuotas());

            if (xReader == null)
            {
                throw new Exception("Unable to convert data.");
            }

            xJSONRoot = XElement.Load(xReader);
            
            xProfile.LoadXml(xJSONRoot.ToString());

            if (xProfile.SelectSingleNode("root/status").InnerText.ToLower() != "success")
            {
                //TODO: Catch errors in JSON feed (Problem: If JSON returns a 501 the WebClient throws an exception.)
                throw new Exception("");
            }

            pDownloadedProfile.GamerTag = xProfile.SelectSingleNode("root/data/gamertag").InnerText;
            pDownloadedProfile.Avatar = DownloadImage(xProfile.SelectSingleNode("root/data/avatar/full").InnerText);
            pDownloadedProfile.GamerScore = Int32.Parse(xProfile.SelectSingleNode("root/data/gamerscore").InnerText);
            pDownloadedProfile.Reputation = Int32.Parse(xProfile.SelectSingleNode("root/data/reputation").InnerText);
            pDownloadedProfile.Presence = xProfile.SelectSingleNode("root/data/presence").InnerText;
            pDownloadedProfile.Online = Boolean.Parse(xProfile.SelectSingleNode("root/data/online").InnerText);
            pDownloadedProfile.Motto = xProfile.SelectSingleNode("root/data/motto").InnerText;
            pDownloadedProfile.Name = xProfile.SelectSingleNode("root/data/name").InnerText;
            pDownloadedProfile.Location = xProfile.SelectSingleNode("root/data/location").InnerText;
            pDownloadedProfile.Biography = xProfile.SelectSingleNode("root/data/biography").InnerText;

            pDownloadedProfile.RecentActivity = new List<Activity>();

            foreach (XmlNode xNode in xProfile.SelectNodes("root/data/recentactivity/item"))
            {
                Activity tmpActivity = new Activity();

                tmpActivity.ID = Int32.Parse(xNode.SelectSingleNode("id").InnerText);
                tmpActivity.HID = xNode.SelectSingleNode("hid").InnerText;
                tmpActivity.IsApp = Boolean.Parse(xNode.SelectSingleNode("isapp").InnerText);
                tmpActivity.Title = xNode.SelectSingleNode("title").InnerText;
                tmpActivity.Artwork = DownloadImage(xNode.SelectSingleNode("artwork").SelectSingleNode("large").InnerText);
                tmpActivity.GamerScore = new GamerScore(Int32.Parse(xNode.SelectSingleNode("gamerscore/current").InnerText), Int32.Parse(xNode.SelectSingleNode("gamerscore/total").InnerText));
                tmpActivity.Achievements = new Achievements(Int32.Parse(xNode.SelectSingleNode("achievements/current").InnerText), Int32.Parse(xNode.SelectSingleNode("achievements/total").InnerText));
                tmpActivity.Progress = Double.Parse(xNode.SelectSingleNode("progress").InnerText);
                tmpActivity.LastPlayed = DateTimeFromEpoc(Int64.Parse(xNode.SelectSingleNode("lastplayed").InnerText));

                pDownloadedProfile.RecentActivity.Add(tmpActivity);
            }

            return pDownloadedProfile;
        }

        /// <summary>
        /// Downloads the game data for a the specified gamer tag.
        /// </summary>
        /// <param name="sGamerTag">The gamer tag to download game data for.</param>
        /// <returns>Returns a <seealso cref="XboxLeadersAPI.Games">Games</seealso> object.</returns>
        public static Games DownloadGameData(String sGamerTag)
        {
            WebClient wcDownloader = new WebClient();
            Games gDownloadedGames = new Games();
            XmlDocument xGames = new XmlDocument();
            XmlReader xReader;
            XElement xJSONRoot;
            Byte[] bJSONData;

            bJSONData = System.Text.Encoding.ASCII.GetBytes(wcDownloader.DownloadString("https://www.xboxleaders.com/api/games.json?gamertag=" + sGamerTag));

            xReader = JsonReaderWriterFactory.CreateJsonReader(bJSONData, new XmlDictionaryReaderQuotas());

            if (xReader == null)
            {
                throw new Exception("Unable to convert data.");
            }

            xJSONRoot = XElement.Load(xReader);

            xGames.LoadXml(xJSONRoot.ToString());

            if (xGames.SelectSingleNode("root/status").InnerText.ToLower() != "success")
            {
                //TODO: Catch errors in JSON feed (Problem: If JSON returns a 501 the WebClient throws an exception.)
                throw new Exception("");
            }

            gDownloadedGames.GamerTag = xGames.SelectSingleNode("root/data/gamertag").InnerText;
            gDownloadedGames.GamerScore = new GamerScore(Int32.Parse(xGames.SelectSingleNode("root/data/gamerscore/current").InnerText), Int32.Parse(xGames.SelectSingleNode("root/data/gamerscore/total").InnerText));
            gDownloadedGames.Achievements = new Achievements(Int32.Parse(xGames.SelectSingleNode("root/data/achievements/current").InnerText), Int32.Parse(xGames.SelectSingleNode("root/data/achievements/current").InnerText));
            gDownloadedGames.TotalGames = Int32.Parse(xGames.SelectSingleNode("root/data/totalgames").InnerText);
            gDownloadedGames.Progress = Int32.Parse(xGames.SelectSingleNode("root/data/progress").InnerText);

            gDownloadedGames.PlayedGames = new List<Game>();

            foreach (XmlNode xNode in xGames.SelectNodes("root/data/games/item"))
            {
                Game gGame = new Game();

                gGame.ID = Int32.Parse(xNode.SelectSingleNode("id").InnerText);
                gGame.HID = xNode.SelectSingleNode("hid").InnerText;
                gGame.IsApp = Boolean.Parse(xNode.SelectSingleNode("isapp").InnerText);
                gGame.Title = xNode.SelectSingleNode("title").InnerText;
                gGame.Artwork = DownloadImage(xNode.SelectSingleNode("artwork").SelectSingleNode("large").InnerText);
                gGame.GamerScore = new GamerScore(Int32.Parse(xNode.SelectSingleNode("gamerscore/current").InnerText), Int32.Parse(xNode.SelectSingleNode("gamerscore/total").InnerText));
                gGame.Achievements = new Achievements(Int32.Parse(xNode.SelectSingleNode("achievements/current").InnerText), Int32.Parse(xNode.SelectSingleNode("achievements/total").InnerText));
                gGame.Progress = Double.Parse(xNode.SelectSingleNode("progress").InnerText);
                gGame.LastPlayed = DateTimeFromEpoc(Int64.Parse(xNode.SelectSingleNode("lastplayed").InnerText));

                gDownloadedGames.PlayedGames.Add(gGame);
            }

            return gDownloadedGames;
        }

        /// <summary>
        /// Downloads the achievements for a the specified gamer tag.
        /// </summary>
        /// <param name="sGamerTag">The gamer tag of the player of the game.</param>
        /// <param name="iGameID">The ID of the game to download achievements for.</param>
        /// <returns>Return a <seealso cref="XboxLeadersNETWrapper.GameAchievements">GameAchievements</seealso> object.</returns>
        public static GameAchievements DownloadGameAchievements(String sGamerTag, Int32 iGameID)
        {
            //TODO: Need to start getting game achievement data
            return null;
        }

        /// <summary>
        /// Downloads an image from the specified URL.
        /// </summary>
        /// <param name="sURL">The URL to the image.</param>
        /// <returns>Returns a <seealso cref="System.Drawing.Bitmap">Bitmap</seealso> object containing the downloaded image.</returns>
        private static Bitmap DownloadImage(String sURL)
        {
            try
            {
                WebClient wcClient = new WebClient();
                Stream strImageStream;
                Bitmap bmpImage;

                strImageStream = wcClient.OpenRead(sURL);
                bmpImage = new Bitmap(strImageStream);

                strImageStream.Flush();
                strImageStream.Close();
                wcClient.Dispose();

                if (bmpImage != null)
                {
                    return bmpImage;
                }
                else
                {
                    throw new Exception("Unable to download image.");
                }
            }
            catch (Exception)
            {
                //TODO: Account for 404s
                return null;
            }
        }

        /// <summary>
        /// Converts a unix time to a <seealso cref="System.DateTime">DateTime</seealso> object.
        /// </summary>
        /// <param name="iUnixTime">The unix time to convert.</param>
        /// <returns>Returns a <seealso cref="System.DateTime">DateTime</seealso> object set to the date and time of the unix format.</returns>
        private static DateTime DateTimeFromEpoc(Int64 iUnixTime)
        {
            DateTime dtEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return dtEpoch.AddSeconds(iUnixTime);
        }
    }
}