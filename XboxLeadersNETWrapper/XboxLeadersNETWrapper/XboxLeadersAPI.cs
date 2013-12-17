using System;
using System.IO;
using System.Net;
using System.Xml;
using System.Web;
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
        /// <returns>Returns a <seealso cref="XboxLeadersNETWrapper.Profile">Profile</seealso> object.</returns>
        /// <example>XboxLeadersNETWrapper.Profile pProfile = XboxLeadersNETWrapper.DownloadProfileData("Major Nelson");</example>
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
                tmpActivity.Title = HttpUtility.HtmlDecode(xNode.SelectSingleNode("title").InnerText);
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
        /// <returns>Returns a <seealso cref="XboxLeadersNETWrapper.Games">Games</seealso> object.</returns>
        /// <example>XboxLeadersNETWrapper.Games gGames = XboxLeadersNETWrapper.DownloadGameData("Major Nelson");</example>
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
            gDownloadedGames.Achievements = new Achievements(Int32.Parse(xGames.SelectSingleNode("root/data/achievements/current").InnerText), Int32.Parse(xGames.SelectSingleNode("root/data/achievements/total").InnerText));
            gDownloadedGames.TotalGames = Int32.Parse(xGames.SelectSingleNode("root/data/totalgames").InnerText);
            gDownloadedGames.Progress = Int32.Parse(xGames.SelectSingleNode("root/data/progress").InnerText);

            gDownloadedGames.PlayedGames = new List<Game>();

            foreach (XmlNode xNode in xGames.SelectNodes("root/data/games/item"))
            {
                Game gGame = new Game();

                gGame.ID = Int32.Parse(xNode.SelectSingleNode("id").InnerText);
                gGame.HID = xNode.SelectSingleNode("hid").InnerText;
                gGame.IsApp = Boolean.Parse(xNode.SelectSingleNode("isapp").InnerText);
                gGame.Title = HttpUtility.HtmlDecode(xNode.SelectSingleNode("title").InnerText);
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
        /// Downloads the achievements for a the specified gamer tag and game ID.
        /// </summary>
        /// <param name="sGamerTag">The gamer tag of the player of the game.</param>
        /// <param name="iGameID">The ID of the game to download achievements for.</param>
        /// <returns>Returns a <seealso cref="XboxLeadersNETWrapper.GameAchievements">GameAchievements</seealso> object.</returns>
        /// <example>XboxLeadersNETWrapper.GameAchievements gaAchievements = XboxLeadersNETWrapper.DownloadGameAchievements("Major Nelson", 1297287449);</example>
        public static GameAchievements DownloadGameAchievements(String sGamerTag, Int32 iGameID)
        {
            WebClient wcDownloader = new WebClient();
            GameAchievements gaAchievements = new GameAchievements();
            XmlDocument xGame = new XmlDocument();
            XmlReader xReader;
            XElement xJSONRoot;
            Byte[] bJSONData;

            bJSONData = System.Text.Encoding.ASCII.GetBytes(wcDownloader.DownloadString(String.Format("https://www.xboxleaders.com/api/achievements.json?gamertag={0}&gameid={1}", sGamerTag, iGameID)));

            xReader = JsonReaderWriterFactory.CreateJsonReader(bJSONData, new XmlDictionaryReaderQuotas());

            if (xReader == null)
            {
                throw new Exception("Unable to convert data.");
            }

            xJSONRoot = XElement.Load(xReader);

            xGame.LoadXml(xJSONRoot.ToString());

            if (xGame.SelectSingleNode("root/status").InnerText.ToLower() != "success")
            {
                //TODO: Catch errors in JSON feed (Problem: If JSON returns a 501 the WebClient throws an exception.)
                throw new Exception("");
            }

            gaAchievements.GamerTag = xGame.SelectSingleNode("root/data/gamertag").InnerText;
            gaAchievements.GameName = xGame.SelectSingleNode("root/data/game").InnerText;
            gaAchievements.ID = Int32.Parse(xGame.SelectSingleNode("root/data/id").InnerText);
            gaAchievements.HID = xGame.SelectSingleNode("root/data/hid").InnerText;
            gaAchievements.GamerScore = new GamerScore(Int32.Parse(xGame.SelectSingleNode("root/data/gamerscore/current").InnerText), Int32.Parse(xGame.SelectSingleNode("root/data/gamerscore/total").InnerText));
            gaAchievements.Achievements = new Achievements(Int32.Parse(xGame.SelectSingleNode("root/data/achievement/current").InnerText), Int32.Parse(xGame.SelectSingleNode("root/data/achievement/total").InnerText));
            gaAchievements.Progress = Double.Parse(xGame.SelectSingleNode("root/data/progress").InnerText);
            gaAchievements.LastPlayed = DateTimeFromEpoc(Int64.Parse(xGame.SelectSingleNode("root/data/lastplayed").InnerText));

            gaAchievements.AchievementList = new List<Achievement>();

            foreach (XmlNode xAchievement in xGame.SelectNodes("root/data/achievements/item"))
            {
                Achievement aAchievement = new Achievement();

                aAchievement.ID = Int32.Parse(xAchievement.SelectSingleNode("id").InnerText);
                aAchievement.Title = xAchievement.SelectSingleNode("title").InnerText;
                aAchievement.LockedArtwork = DownloadImage(xAchievement.SelectSingleNode("artwork/locked").InnerText);
                aAchievement.UnlockedArtwork = DownloadImage(xAchievement.SelectSingleNode("artwork/unlocked").InnerText);
                aAchievement.Description = xAchievement.SelectSingleNode("description").InnerText;
                aAchievement.GamerScore = Int32.Parse(xAchievement.SelectSingleNode("gamerscore").InnerText);
                aAchievement.Secret = Boolean.Parse(xAchievement.SelectSingleNode("secret").InnerText);
                aAchievement.Unlocked = Boolean.Parse(xAchievement.SelectSingleNode("unlocked").InnerText);

                if (aAchievement.Unlocked)
                {
                    aAchievement.UnlockedDate = DateTimeFromEpoc(Int64.Parse(xAchievement.SelectSingleNode("unlockdate").InnerText));
                    aAchievement.UnlockedOffline = Boolean.Parse(xAchievement.SelectSingleNode("unlockedoffline").InnerText);
                }
                else
                {
                    aAchievement.UnlockedOffline = false;
                }

                gaAchievements.AchievementList.Add(aAchievement);
            }

            return gaAchievements;
        }

        /// <summary>
        /// Downloads the friend list for the specified gamer tag.
        /// </summary>
        /// <param name="sGamerTag">The gamer tag to download the friends list for.</param>
        /// <returns>Returns a <seealso cref="XboxLeadersNETWrapper.Friends">Friends</seealso> object.</returns>
        /// <example>XboxLeadersNETWrapper.Friends fFriends = XboxLeadersNETWrapper.DownloadFriendList("Major Nelson");</example>
        public static Friends DownloadFriendList(String sGamerTag)
        {
            WebClient wcDownloader = new WebClient();
            XmlDocument xFriends = new XmlDocument();
            Friends fFriends = new Friends();
            XmlReader xReader;
            XElement xJSONRoot;
            Byte[] bJSONData;

            bJSONData = System.Text.Encoding.ASCII.GetBytes(wcDownloader.DownloadString("https://www.xboxleaders.com/api/friends.json?gamertag=" + sGamerTag));

            xReader = JsonReaderWriterFactory.CreateJsonReader(bJSONData, new XmlDictionaryReaderQuotas());

            if (xReader == null)
            {
                throw new Exception("Unable to convert data.");
            }

            xJSONRoot = XElement.Load(xReader);

            xFriends.LoadXml(xJSONRoot.ToString());

            if (xFriends.SelectSingleNode("root/status").InnerText.ToLower() != "success")
            {
                //TODO: Catch errors in JSON feed (Problem: If JSON returns a 501 the WebClient throws an exception.)
                throw new Exception("");
            }

            fFriends.Total = Int32.Parse(xFriends.SelectSingleNode("root/data/total").InnerText);
            fFriends.Online = Int32.Parse(xFriends.SelectSingleNode("root/data/totalonline").InnerText);
            fFriends.Offline = Int32.Parse(xFriends.SelectSingleNode("root/data/totaloffline").InnerText);

            fFriends.GamerFriends = new List<Friend>();

            foreach (XmlNode xNode in xFriends.SelectNodes("root/data/friends/item"))
            {
                Friend fFriend = new Friend();

                fFriend.GamerTag = xNode.SelectSingleNode("gamertag").InnerText;
                fFriend.GamerPic = DownloadImage(xNode.SelectSingleNode("gamerpic/large").InnerText);
                fFriend.GamerScore = Int32.Parse(xNode.SelectSingleNode("gamerscore").InnerText);
                fFriend.Online = Boolean.Parse(xNode.SelectSingleNode("online").InnerText);
                fFriend.Status = xNode.SelectSingleNode("status").InnerText;
                fFriend.LastSeen = DateTimeFromEpoc(Int64.Parse(xNode.SelectSingleNode("lastseen").InnerText));

                fFriends.GamerFriends.Add(fFriend);
            }

            return fFriends;
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
                return Properties.Resources.boxart_nodownload;
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