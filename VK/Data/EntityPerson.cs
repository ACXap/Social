using Newtonsoft.Json;
using System;

namespace VK.Data
{
    public class EntityPerson
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        
        /// <summary>
        /// Имя
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        
        /// <summary>
        /// Фамилия
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Поле возвращается, если страница пользователя удалена 
        /// или заблокирована, содержит значение deleted или banned. 
        /// В этом случае опциональные поля не возвращаются
        /// </summary>
        [JsonProperty("deactivated")]
        public string Deactivated { get; set; }
        
        /// <summary>
        /// Скрыт ли профиль пользователя настройками приватности
        /// </summary>
        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }

        /// <summary>
        /// Может ли текущий пользователь видеть профиль при is_closed = 1 (например, он есть в друзьях)
        /// </summary>
        [JsonProperty("can_access_closed")]
        public bool CanAccessClosed { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("activities")]
        public string Activities { get; set; }

        [JsonProperty("sex")]
        public long Sex { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("bdate")]
        public string Bdate { get; set; }

        [JsonProperty("city")]
        public Place City { get; set; }

        [JsonProperty("country")]
        public Place Country { get; set; }

        [JsonProperty("photo_50")]
        public Uri Photo50 { get; set; }

        [JsonProperty("photo_100")]
        public Uri Photo100 { get; set; }

        [JsonProperty("photo_200")]
        public Uri Photo200 { get; set; }

        [JsonProperty("photo_200_orig")]
        public Uri Photo200_Orig { get; set; }

        [JsonProperty("photo_max")]
        public Uri PhotoMax { get; set; }

        [JsonProperty("photo_400_orig")]
        public Uri Photo400_Orig { get; set; }

        [JsonProperty("photo_max_orig")]
        public Uri PhotoMaxOrig { get; set; }

        [JsonProperty("photo_id")]
        public string PhotoId { get; set; }

        [JsonProperty("has_photo")]
        public long HasPhoto { get; set; }

        [JsonProperty("has_mobile")]
        public long HasMobile { get; set; }

        [JsonProperty("is_friend")]
        public long IsFriend { get; set; }

        [JsonProperty("friend_status")]
        public long FriendStatus { get; set; }

        [JsonProperty("online")]
        public long Online { get; set; }

        [JsonProperty("online_app")]
        public long OnlineApp { get; set; }

        [JsonProperty("online_mobile")]
        public long OnlineMobile { get; set; }

        [JsonProperty("can_post")]
        public long CanPost { get; set; }

        [JsonProperty("can_see_all_posts")]
        public long CanSeeAllPosts { get; set; }

        [JsonProperty("can_see_audio")]
        public long CanSeeAudio { get; set; }

        [JsonProperty("can_write_private_message")]
        public long CanWritePrivateMessage { get; set; }

        [JsonProperty("can_send_friend_request")]
        public long CanSendFriendRequest { get; set; }

        [JsonProperty("site")]
        public string Site { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        //[JsonProperty("last_seen")]
        //public LastSeen LastSeen { get; set; }

        //[JsonProperty("crop_photo")]
        //public CropPhoto CropPhoto { get; set; }

        [JsonProperty("verified")]
        public long Verified { get; set; }

        [JsonProperty("can_be_invited_group")]
        public bool CanBeInvitedGroup { get; set; }

        [JsonProperty("followers_count")]
        public long FollowersCount { get; set; }

        [JsonProperty("blacklisted")]
        public long Blacklisted { get; set; }

        [JsonProperty("blacklisted_by_me")]
        public long BlacklistedByMe { get; set; }

        [JsonProperty("is_favorite")]
        public long IsFavorite { get; set; }

        [JsonProperty("is_hidden_from_feed")]
        public long IsHiddenFromFeed { get; set; }

        [JsonProperty("common_count")]
        public long CommonCount { get; set; }

        //[JsonProperty("occupation")]
        //public Occupation Occupation { get; set; }
    }
}