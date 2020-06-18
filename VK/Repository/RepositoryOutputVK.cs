using Npgsql;
using System;
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
        private const string TABLE_PHOTO = "public.vk_user_photo";
        private const string TABLE_CAREER = "public.vk_career";
        private const string TABLE_MILITARY = "public.vk_military";
        private const string TABLE_RELATION_PARTNER = "public.vk_relation_partner";
        private const string TABLE_RELATION = "public.vk_relatives";
        private const string TABLE_SCHOOL = "public.vk_school";
        private const string TABLE_UNIVERSITY = "public.vk_university";

        #endregion PrivateField

        #region PublicProperties
        #endregion PublicProperties

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
                    cmd.Parameters.Add(new NpgsqlParameter<int>("id", user.Id));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("first_name", user.FirstName));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("last_name", user.LastName));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("deactivated", user.Deactivated));
                    cmd.Parameters.Add(new NpgsqlParameter<bool>("is_closed", user.IsClosed));
                    cmd.Parameters.Add(new NpgsqlParameter<bool>("can_access_closed", user.CanAccessClosed));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("about", user.About));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("activities", user.Activities));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("bdate", user.Bdate));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("blacklisted", user.Blacklisted));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("blacklisted_by_me", user.BlacklistedByMe));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("books", user.Books));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("can_post", user.CanPost));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("can_see_all_posts", user.CanSeeAllPosts));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("can_see_audio", user.CanSeeAudio));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("can_write_private_message", user.CanWritePrivateMessage));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("can_send_friend_request", user.CanWritePrivateMessage));
                    cmd.Parameters.Add(new NpgsqlParameter() { Value = (object)user.City?.Id ?? DBNull.Value, ParameterName = "city" });
                    cmd.Parameters.Add(new NpgsqlParameter<int>("common_count", user.CommonCount));
                    cmd.Parameters.Add(new NpgsqlParameter() { Value = (object)user.Country?.Id ?? DBNull.Value, ParameterName = "country" });
                    cmd.Parameters.Add(new NpgsqlParameter<string>("domain", user.Domain));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("followers_count", user.FollowersCount));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("friend_status", user.FriendStatus));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("games", user.Games));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("has_photo", user.HasPhoto));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("has_mobile", user.HasMobile));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("home_town", user.HomeTown));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("interests", user.Interests));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("is_favorite", user.IsFavorite));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("is_friend", user.IsFriend));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("is_hidden_from_feed", user.IsHiddenFromFeed));
                    cmd.Parameters.Add(new NpgsqlParameter() { Value = (object)user.LastSeen?.Time ?? DBNull.Value, ParameterName = "last_seen_time" });
                    cmd.Parameters.Add(new NpgsqlParameter() { Value = (object)user.LastSeen?.Platform ?? DBNull.Value, ParameterName = "last_seen_platform" });
                    cmd.Parameters.Add(new NpgsqlParameter<string>("maiden_name", user.MaidenName));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("movies", user.Movies));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("music", user.Music));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("nickname", user.Nickname));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("online", user.Online));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("online_app", user.OnlineApp));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("online_mobile", user.OnlineMobile));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("quotes", user.Quotes));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("relation", user.Relation));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("screen_name", user.ScreenName));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("sex", user.Sex));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("site", user.Site));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("status", user.Status));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("trending", user.Trending));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("tv", user.Tv));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("verified", user.Verified));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("wall_default", user.WallDefault));
                    cmd.Parameters.Add(new NpgsqlParameter<bool>("can_be_invited_group", user.CanBeInvitedGroup));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("skype", user.Skype));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("facebook", user.Facebook));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("facebook_name", user.FacebookName));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("livejournal", user.Livejournal));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("twitter", user.Twitter));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("instagram", user.Instagram));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("mobile_phone", user.MobilePhone));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("home_phone", user.HomePhone));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("occupation_type", user.Occupation?.Type));
                    cmd.Parameters.Add(new NpgsqlParameter() { Value = (object)user.Occupation?.Id ?? DBNull.Value, ParameterName = "occupation_id" });
                    cmd.Parameters.Add(new NpgsqlParameter<string>("occupation_name", user.Occupation?.Name));
                    cmd.Parameters.Add(new NpgsqlParameter() { Value = (object)user.Personal?.Political ?? DBNull.Value, ParameterName = "political" });
                    cmd.Parameters.Add(new NpgsqlParameter<string>("langs", user.Personal?.LangToString()));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("religion", user.Personal?.Religion));
                    cmd.Parameters.Add(new NpgsqlParameter() { Value = (object)user.Personal?.ReligionId ?? DBNull.Value, ParameterName = "religion_id" });
                    cmd.Parameters.Add(new NpgsqlParameter<string>("inspired_by", user.Personal?.InspiredBy));
                    cmd.Parameters.Add(new NpgsqlParameter() { Value = (object)user.Personal?.PeopleMain ?? DBNull.Value, ParameterName = "people_main" });
                    cmd.Parameters.Add(new NpgsqlParameter() { Value = (object)user.Personal?.LifeMain ?? DBNull.Value, ParameterName = "life_main" });
                    cmd.Parameters.Add(new NpgsqlParameter() { Value = (object)user.Personal?.Smoking ?? DBNull.Value, ParameterName = "smoking" });
                    cmd.Parameters.Add(new NpgsqlParameter() { Value = (object)user.Personal?.Alcohol ?? DBNull.Value, ParameterName = "alcohol" });
                    cmd.Parameters.Add(new NpgsqlParameter<string>("source", source));
                    cmd.Parameters.Add(new NpgsqlParameter("create_data", DateTime.Now));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CreatePhote(EntityPerson user)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                string insertApiKey = $"INSERT INTO {TABLE_PHOTO} (" +
                    $"id_user, photo_50, photo_100, photo_200, photo_200_orig, photo_max, photo_400_orig, photo_max_orig, photo_id)" +
                    $"VALUES(@id_user, @photo_50, @photo_100, @photo_200, @photo_200_orig, @photo_max, @photo_400_orig, @photo_max_orig, @photo_id)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(insertApiKey, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter<int>("id_user", user.Id));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("photo_50", user.Photo50));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("photo_100", user.Photo100));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("photo_200", user.Photo200));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("photo_200_orig", user.Photo200_Orig));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("photo_max", user.PhotoMax));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("photo_400_orig", user.Photo400_Orig));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("photo_max_orig", user.PhotoMaxOrig));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("photo_id", user.PhotoId));

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CreateCareer(EntityPerson user)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();

                string insertApiKey = $"INSERT INTO {TABLE_CAREER} (" +
                    $"id_user, company, group_id, country_id, city_id, city_name, \"position\", \"from\", \"until\")" +
                    $"VALUES(@id_user, @company, @group_id, @country_id, @city_id, @city_name, @position, @from, @until)";

                foreach (var item in user.Careers)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(insertApiKey, conn))
                    {
                        cmd.Parameters.Add(new NpgsqlParameter<int>("id_user", user.Id));
                        cmd.Parameters.Add(new NpgsqlParameter<string>("company", item.Company));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("group_id", item.GroupId));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("country_id", item.CountryId));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("city_id", item.CityId));
                        cmd.Parameters.Add(new NpgsqlParameter<string>("city_name", item.CityName));
                        cmd.Parameters.Add(new NpgsqlParameter<string>("position", item.Position));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("from", item.From));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("until", item.Until));

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void CreateMilitary(EntityPerson user)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();

                string insertApiKey = $"INSERT INTO {TABLE_MILITARY} (" +
                    $"id_user, unit, unit_id, country_id, \"from\", \"until\")" +
                    $"VALUES(@id_user, @unit, @unit_id, @country_id, @from, @until)";

                foreach (var item in user.Military)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(insertApiKey, conn))
                    {
                        cmd.Parameters.Add(new NpgsqlParameter<int>("id_user", user.Id));
                        cmd.Parameters.Add(new NpgsqlParameter<string>("unit", item.Unit));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("unit_id", item.UnitId));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("country_id", item.CountryId));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("from", item.From));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("until", item.Until));

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void CreateRelationPartner(EntityPerson user)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();

                string insertApiKey = $"INSERT INTO {TABLE_RELATION_PARTNER} (" +
                    $"id_user, id_relation_partner, first_name, last_name)" +
                    $"VALUES(@id_user, @id_relation_partner, @first_name, @last_name)";

                var item = user.RelationPartner;

                using (NpgsqlCommand cmd = new NpgsqlCommand(insertApiKey, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter<int>("id_user", user.Id));
                    cmd.Parameters.Add(new NpgsqlParameter<int>("id_relation_partner", item.Id));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("first_name", item.FirstName));
                    cmd.Parameters.Add(new NpgsqlParameter<string>("last_name", item.LastName));

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CreateRelation(EntityPerson user)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();

                string insertApiKey = $"INSERT INTO {TABLE_RELATION} (" +
                    $"id_user, id_relative, \"name\", \"type\")" +
                    $"VALUES(@id_user, @id_relative, @name, @type)";

                foreach (var item in user.Relatives)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(insertApiKey, conn))
                    {
                        cmd.Parameters.Add(new NpgsqlParameter<int>("id_user", user.Id));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("id_relative", item.Id));
                        cmd.Parameters.Add(new NpgsqlParameter<string>("name", item.Name));
                        cmd.Parameters.Add(new NpgsqlParameter<string>("type", item.Type));

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void CreateSchool(EntityPerson user)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();

                string insertApiKey = $"INSERT INTO {TABLE_SCHOOL} (" +
                    $"id_user, id_school, country, city, \"name\", year_from, year_to, year_graduated, \"class\", speciality, \"type\", type_str)" +
                    $"VALUES(@id_user, @id_school, @country, @city, @name, @year_from, @year_to, @year_graduated, @class, @speciality, @type, @type_str)";

                foreach (var item in user.Schools)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(insertApiKey, conn))
                    {
                        cmd.Parameters.Add(new NpgsqlParameter<int>("id_user", user.Id));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("id_school", item.Id));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("country", item.Country));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("city", item.City));
                        cmd.Parameters.Add(new NpgsqlParameter<string>("name", item.Name));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("year_from", item.YearFrom));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("year_to", item.YearTo));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("year_graduated", item.YearGraduated));
                        cmd.Parameters.Add(new NpgsqlParameter<string>("class", item.ClassLatter));
                        cmd.Parameters.Add(new NpgsqlParameter<string>("speciality", item.Speciality));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("type", item.Type));
                        cmd.Parameters.Add(new NpgsqlParameter<string>("type_str", item.TypeStr));

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void CreateUniversity(EntityPerson user)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();

                string insertApiKey = $"INSERT INTO {TABLE_UNIVERSITY} (" +
                    $"id_user, id_university, country, city, \"name\", faculty, faculty_name, chair, chair_name, graduation, education_form, education_status)" +
                    $"VALUES(@id_user, @id_university, @country, @city, @name, @faculty, @faculty_name, @chair, @chair_name, @graduation, @education_form, @education_status)";

                foreach (var item in user.Universities)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(insertApiKey, conn))
                    {
                        cmd.Parameters.Add(new NpgsqlParameter<int>("id_user", user.Id));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("id_university", item.Id));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("country", item.Country));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("city", item.City));
                        cmd.Parameters.Add(new NpgsqlParameter<string>("name", item.Name));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("faculty", item.Faculty));
                        cmd.Parameters.Add(new NpgsqlParameter<string>("faculty_name", item.FacultyName));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("chair", item.Chair));
                        cmd.Parameters.Add(new NpgsqlParameter<string>("chair_name", item.ChairName));
                        cmd.Parameters.Add(new NpgsqlParameter<int>("graduation", item.Graduation));
                        cmd.Parameters.Add(new NpgsqlParameter<string>("education_form", item.EducationForm));
                        cmd.Parameters.Add(new NpgsqlParameter<string>("education_status", item.EducationStatus));

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}