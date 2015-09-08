using System;
using System.Net;
using System.Runtime.Serialization.Json;
using Codeforge.Diablo3InfoClasses;

namespace Codeforge.Diablo3Info
{
    /// <summary>
    /// Activates RequestHandler to send request and deserializes response to specified JSON object.
    /// All methods use region and locale parameters, so make sure you know hat you can use:
    /// - full list of supported regions: https://dev.battle.net/docs/read/community_apis
    /// - full list of supported locales: https://dev.battle.net/docs/read/community_apis
    /// </summary>
    public class DiabloService
    {
        /// <summary>
        /// Returns player profile information
        /// </summary>
        /// <param name="region">Player region</param>
        /// <param name="battleTag">Player's battle tag</param>
        /// <param name="locale">Language code (locale)</param>
        /// <returns>
        /// Returns profile information for the specified battle tag, or NOTFOUND
        /// </returns>
        public static ProfileInfo GetProfileInfo(RequestParameters.REGIONS region, string battleTag, string locale, string apiKeyValue)
        {
            using (HttpWebResponse response = RequestHandler.CreateProfileRequest(region, battleTag, locale, apiKeyValue))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));
                }

                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(ProfileInfo));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                ProfileInfo jsonResponse = objResponse as ProfileInfo;
                return jsonResponse;
            }
        }

        /// <summary>
        /// Returns stats for the chosen hero (hero id can be seen in Profile Information)
        /// </summary>
        /// <param name="region">Player region</param>
        /// <param name="battleTag">Player's battle tag</param>
        /// <param name="heroId">Player's hero ID (hero IDs can be fetched from profile information</param>
        /// <param name="locale">Language code (locale)</param>
        /// <returns></returns>
        public static CharacterInfo GetCharacterInfo(RequestParameters.REGIONS region, string battleTag, string heroId, string locale, string apiKeyValue)
        {
            using (HttpWebResponse response = RequestHandler.CreateCharacterRequest(region, battleTag, heroId, locale, apiKeyValue))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));
                }

                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(CharacterInfo));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                CharacterInfo jsonResponse = objResponse as CharacterInfo;
                return jsonResponse;
            }
        }

        /// <summary>
        /// Returns follower information
        /// </summary>
        /// <param name="region">Player region</param>
        /// <param name="follower">Chosen follower</param>
        /// <param name="locale">Language code (locale)</param>
        /// <returns></returns>
        public static FollowerInfo GetFollowerInfo(RequestParameters.REGIONS region, RequestParameters.FOLLOWERS follower, string locale, string apiKeyValue)
        {
            using (HttpWebResponse response = RequestHandler.CreateFollowerRequest(region, Enum.GetName(typeof(RequestParameters.FOLLOWERS), follower).ToLower(), locale, apiKeyValue))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));
                }

                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(FollowerInfo));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                FollowerInfo jsonResponse = objResponse as FollowerInfo;
                return jsonResponse;
            }
        }

        /// <summary>
        /// Returns artisan information
        /// </summary>
        /// <param name="region">Player region</param>
        /// <param name="artisan">Chosen artisan</param>
        /// <param name="locale">Language code (locale)</param>
        /// <returns></returns>
        public static ArtisanInfo GetArtisanInfo(RequestParameters.REGIONS region, RequestParameters.ARTISANS artisan, string locale, string apiKeyValue)
        {
            using (HttpWebResponse response = RequestHandler.CreateArtisanRequest(region, Enum.GetName(typeof(RequestParameters.ARTISANS), artisan).ToLower(), locale, apiKeyValue))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));
                }

                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(ArtisanInfo));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                ArtisanInfo jsonResponse = objResponse as ArtisanInfo;
                return jsonResponse;
            }
        }

        public void GetItemInfo(RequestParameters.REGIONS region, string battleTag, string itemString, string apiKeyValue)
        {

        }
    }
}
