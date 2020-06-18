using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK.Data;

namespace VK.Repository
{
    public class RepositoryOutputVK : IRepositoryOutputVK
    {
        public RepositoryOutputVK(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region PrivateField
        private string _connectionString;

        private const string TABLE_USER = "public.vk_user";
        #endregion PrivateField

        #region PublicProperties
        #endregion PublicProperties

        #region Command
        #endregion Command

        #region PrivateMethod
        #endregion PrivateMethod

        #region PublicMethod
        #endregion PublicMethod


        public void CreateUser(EntityPerson user, string source)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                string insertApiKey = $"INSERT INTO {TABLE_USER} (" +
                    $"id, first_name, last_name, deactivated, is_closed, can_access_closed, about, activities, bdate, blacklisted, blacklisted_by_me, books," +
                    $"can_post, can_see_all_posts, can_see_audio, can_write_private_message, can_send_friend_request, city, common_count, country," +
                    $"\"domain\", followers_count, friend_status, games, has_photo, has_mobile, home_town, interests, is_favorite, is_friend," +
                    $"is_hidden_from_feed, last_seen_time, last_seen_platform, maiden_name, movies, music, nickname, online, online_app, online_mobile, quotes," +
                    $" relation, screen_name, sex, site, status, trending, tv, verified, wall_default, can_be_invited_group, skype, facebook," +
                    $"facebook_name, livejournal, twitter, instagram, mobile_phone, home_phone, occupation_type, occupation_id," +
                    $"occupation_name, political, langs, religion, religion_id, inspired_by, people_main, life_main, smoking, alcohol, \"source\", create_data" +
                    $") VALUES (" +
                    $"@id, @first_name, @last_name, @deactivated, @is_closed, @can_access_closed, @about, @activities, @bdate, @blacklisted, @blacklisted_by_me, @books," +
                    $"@can_post, @can_see_all_posts, @can_see_audio, @can_write_private_message, @can_send_friend_request, @city, @common_count, @country," +
                    $"@domain, @followers_count, @friend_status, @games, @has_photo, @has_mobile, @home_town, @interests, @is_favorite, @is_friend," +
                    $"@is_hidden_from_feed, @last_seen_time, @last_seen_platform, @maiden_name, @movies, @music, @nickname, @online, @online_app, @online_mobile, @quotes," +
                    $"@relation, @screen_name, @sex, @site, @status, @trending, @tv, @verified, @wall_default, @can_be_invited_group, @skype, @facebook," +
                    $"@facebook_name, @livejournal, @twitter, @instagram, @mobile_phone, @home_phone, @occupation_type, @occupation_id," +
                    $"@occupation_name, @political, @langs, @religion, @religion_id, @inspired_by, @people_main, @life_main, @smoking, @alcohol, @source, @create_data" +
                    $")";

                using (NpgsqlCommand cmd = new NpgsqlCommand(insertApiKey, conn))
                {
                    cmd.Parameters.AddWithValue("id", user.Id);
                    cmd.Parameters.AddWithValue("first_name", user.FirstName);
                    cmd.Parameters.AddWithValue("last_name", user.LastName);
                    cmd.Parameters.AddWithValue("deactivated", user.Deactivated);
                    cmd.Parameters.AddWithValue("is_closed", user.IsClosed);
                    cmd.Parameters.AddWithValue("can_access_closed", user.CanAccessClosed);
                    cmd.Parameters.AddWithValue("about", user.About);
                    cmd.Parameters.AddWithValue("activities", user.Activities);
                    cmd.Parameters.AddWithValue("bdate", user.Bdate);
                    cmd.Parameters.AddWithValue("blacklisted", user.Blacklisted );
                    cmd.Parameters.AddWithValue("blacklisted_by_me", user.BlacklistedByMe);
                    cmd.Parameters.AddWithValue("books", user.Books );
                    cmd.Parameters.AddWithValue("can_post", user.CanPost );
                    cmd.Parameters.AddWithValue("can_see_all_posts", user.CanSeeAllPosts );
                    cmd.Parameters.AddWithValue("can_see_audio", user.CanSeeAudio);
                    cmd.Parameters.AddWithValue("can_write_private_message", user.CanWritePrivateMessage);
                    cmd.Parameters.AddWithValue("can_send_friend_request", user.CanWritePrivateMessage);
                    cmd.Parameters.AddWithValue("city", user.City );
                    cmd.Parameters.AddWithValue("common_count", user.CommonCount);
                    cmd.Parameters.AddWithValue("country", user.Country);
                    cmd.Parameters.AddWithValue("domain", user.Domain);
                    cmd.Parameters.AddWithValue("followers_count", user.FollowersCount );
                    cmd.Parameters.AddWithValue("friend_status", user.FriendStatus);
                    cmd.Parameters.AddWithValue("games", user.Games);
                    cmd.Parameters.AddWithValue("has_photo", user.HasPhoto);
                    cmd.Parameters.AddWithValue("has_mobile", user.HasMobile);
                    cmd.Parameters.AddWithValue("home_town", user.HomeTown);
                    cmd.Parameters.AddWithValue("interests", user.Interests);
                    cmd.Parameters.AddWithValue("is_favorite", user.IsFavorite);
                    cmd.Parameters.AddWithValue("is_friend", user.IsFriend );
                    cmd.Parameters.AddWithValue("is_hidden_from_feed", user.IsHiddenFromFeed );
                    cmd.Parameters.AddWithValue("last_seen_time", user.LastSeen?.Time);
                    cmd.Parameters.AddWithValue("last_seen_platform", user.LastSeen?.Platform);
                    cmd.Parameters.AddWithValue("maiden_name", user.MaidenName );
                    cmd.Parameters.AddWithValue("movies", user.Movies );
                    cmd.Parameters.AddWithValue("music", user.Music);
                    cmd.Parameters.AddWithValue("nickname", user.Nickname );
                    cmd.Parameters.AddWithValue("online", user.Online );
                    cmd.Parameters.AddWithValue("online_app", user.OnlineApp);
                    cmd.Parameters.AddWithValue("online_mobile", user.OnlineMobile );
                    cmd.Parameters.AddWithValue("quotes", user.Quotes);
                    cmd.Parameters.AddWithValue("relation", user.Relation);
                    cmd.Parameters.AddWithValue("screen_name", user.ScreenName);
                    cmd.Parameters.AddWithValue("sex", user.Sex);
                    cmd.Parameters.AddWithValue("site", user.Site);
                    cmd.Parameters.AddWithValue("status", user.Status);
                    cmd.Parameters.AddWithValue("trending", user.Trending);
                    cmd.Parameters.AddWithValue("tv", user.Tv);
                    cmd.Parameters.AddWithValue("verified", user.Verified);
                    cmd.Parameters.AddWithValue("wall_default", user.WallDefault);
                    cmd.Parameters.AddWithValue("can_be_invited_group", user.CanBeInvitedGroup );
                    cmd.Parameters.AddWithValue("skype", user.Skype);
                    cmd.Parameters.AddWithValue("facebook", user.Facebook);
                    cmd.Parameters.AddWithValue("facebook_name", user.FacebookName);
                    cmd.Parameters.AddWithValue("livejournal", user.Livejournal);
                    cmd.Parameters.AddWithValue("twitter", user.Twitter);
                    cmd.Parameters.AddWithValue("instagram", user.Instagram );
                    cmd.Parameters.AddWithValue("mobile_phone", user.MobilePhone);
                    cmd.Parameters.AddWithValue("home_phone", user.HomePhone);
                    cmd.Parameters.AddWithValue("occupation_type", user.Occupation?.Type);
                    cmd.Parameters.AddWithValue("occupation_id", user.Occupation?.Id);
                    cmd.Parameters.AddWithValue("occupation_name", user.Occupation?.Name);
                    cmd.Parameters.AddWithValue("political", user.Personal?.Political);
                    cmd.Parameters.AddWithValue("langs", user.Personal?.Langs);
                    cmd.Parameters.AddWithValue("religion", user.Personal?.Religion);
                    cmd.Parameters.AddWithValue("religion_id", user.Personal?.ReligionId);
                    cmd.Parameters.AddWithValue("inspired_by", user.Personal?.InspiredBy);
                    cmd.Parameters.AddWithValue("people_main", user.Personal?.PeopleMain);
                    cmd.Parameters.AddWithValue("life_main", user.Personal?.LifeMain);
                    cmd.Parameters.AddWithValue("smoking", user.Personal?.Smoking);
                    cmd.Parameters.AddWithValue("alcohol", user.Personal?.Alcohol);
                    cmd.Parameters.AddWithValue("source", source);
                    cmd.Parameters.AddWithValue("source", DateTime.Now.ToShortDateString());
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}