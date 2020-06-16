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

        /// <summary>
        /// Содержимое поля «О себе» из профиля
        /// </summary>
        [JsonProperty("about")]
        public string About { get; set; }

        /// <summary>
        /// Содержимое поля «Деятельность» из профиля
        /// </summary>
        [JsonProperty("activities")]
        public string Activities { get; set; }

        /// <summary>
        /// Дата рождения.
        /// Возвращается в формате D.M.YYYY или D.M (если год рождения скрыт). Если дата рождения скрыта целиком, поле отсутствует в ответе
        /// </summary>
        [JsonProperty("bdate")]
        public string Bdate { get; set; }

        /// <summary>
        /// Информация о том, находится ли текущий пользователь в черном списке
        /// 1 — находится; 0 — не находится
        /// </summary>
        [JsonProperty("blacklisted")]
        public int Blacklisted { get; set; }

        /// <summary>
        /// Информация о том, находится ли пользователь в черном списке у текущего пользователя
        /// 1 — находится; 0 — не находится
        /// </summary>
        [JsonProperty("blacklisted_by_me")]
        public int BlacklistedByMe { get; set; }

        /// <summary>
        /// Содержимое поля «Любимые книги» из профиля пользователя
        /// </summary>
        [JsonProperty("books")]
        public string Books { get; set; }

        /// <summary>
        /// Информация о том, может ли текущий пользователь оставлять записи на стене
        /// 1 — может; 0 — не может
        /// </summary>
        [JsonProperty("can_post")]
        public int CanPost { get; set; }

        /// <summary>
        /// Информация о том, может ли текущий пользователь видеть чужие записи на стене
        /// 1 — может; 0 — не может
        /// </summary>
        [JsonProperty("can_see_all_posts")]
        public int CanSeeAllPosts { get; set; }

        // <summary>
        /// Информация о том, может ли текущий пользователь видеть аудиозаписи
        /// 1 — может; 0 — не может
        /// </summary>
        [JsonProperty("can_see_audio")]
        public int CanSeeAudio { get; set; }

        /// <summary>
        /// Информация о том, может ли текущий пользователь отправить личное сообщен
        /// 1 — может; 0 — не может
        /// </summary>
        [JsonProperty("can_write_private_message")]
        public long CanWritePrivateMessage { get; set; }

        /// <summary>
        /// Информация о том, будет ли отправлено уведомление пользователю о заявке в друзья от текущего пользователя
        /// 1 —  уведомление будет отправлено; 0 —  уведомление не будет отправлено
        /// </summary>
        [JsonProperty("can_send_friend_request")]
        public long CanSendFriendRequest { get; set; }

        /// <summary>
        /// Информация о карьере пользователя
        /// </summary>
        [JsonProperty("can_send_friend_request")]
        public object Career { get; set; }

        /// <summary>
        /// Информация о городе, указанном на странице пользователя в разделе «Контакты»
        /// </summary>
        [JsonProperty("city")]
        public Place City { get; set; }

        /// <summary>
        /// Количество общих друзей с текущим пользователем
        /// </summary>
        [JsonProperty("common_count")]
        public int CommonCount { get; set; }

        /// <summary>
        /// Возвращает данные об указанных в профиле сервисах пользователя,
        /// таких как: skype, facebook, twitter, livejournal, instagram.
        /// Для каждого сервиса возвращается отдельное поле с типом string,
        /// содержащее никнейм пользователя. Например, "instagram": "username".
        /// </summary>
        [JsonProperty("connections")]
        public string Connections { get; set; }

        /// <summary>
        /// Информация о телефонных номерах пользователя.
        /// Если данные указаны и не скрыты настройками приватности
        /// </summary>
        [JsonProperty("contacts")]
        public object Contacts { get; set; }

        /// <summary>
        /// Количество различных объектов у пользователя.
        /// Поле возвращается только в методе users.get
        /// при запросе информации об одном пользователе,
        /// с передачей пользовательского access_token
        /// </summary>
        [JsonProperty("counters")]
        public object Counters { get; set; }

        /// <summary>
        /// Информация о стране, указанной на странице пользователя в разделе «Контакты»
        /// </summary>
        [JsonProperty("country")]
        public Place Country { get; set; }

        ///// <summary>
        ///// Возвращает данные о точках, по которым вырезаны профильная и миниатюрная фотографии пользователя, при наличии
        ///// </summary>
        //[JsonProperty("crop_photo")]
        //public CropPhoto CropPhoto { get; set; }

        /// <summary>
        /// Короткий адрес страницы.
        /// Возвращается строка, содержащая короткий адрес страницы (например, andrew).
        /// Если он не назначен, возвращается "id"+user_id, например, id35828305
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Информация о высшем учебном заведении пользователя
        /// </summary>
        [JsonProperty("education")]
        public object Education { get; set; }

        // /// <summary>
        // /// Внешние сервисы, в которые настроен экспорт из ВК (twitter, facebook, livejournal, instagram)
        // /// </summary>
        // [JsonProperty("exports")]
        // public object Exports { get; set; }

         // /// <summary>
        // /// Имя в заданном падеже
        // /// </summary>
        //  [JsonProperty("first_name_case")]
        //  public object FirstNameCase { get; set; }

        /// <summary>
        /// Количество подписчиков пользователя
        /// </summary>
        [JsonProperty("followers_count")]
        public long FollowersCount { get; set; }

        /// <summary>
        /// Статус дружбы с пользователем. Возможные значения:
        /// 0 — не является другом,
        /// 1 — отправлена заявка/подписка пользователю,
        /// 2 — имеется входящая заявка/подписка от пользователя,
        /// 3 — является другом
        /// </summary>
        [JsonProperty("friend_status")]
        public int FriendStatus { get; set; }

        /// <summary>
        /// Содержимое поля «Любимые игры» из профиля
        /// </summary>
        [JsonProperty("games")]
        public string Games { get; set; }

        /// <summary>
        /// 1, если пользователь установил фотографию для профиля
        /// </summary>
        [JsonProperty("has_photo")]
        public int HasPhoto { get; set; }

        /// <summary>
        /// Информация о том, известен ли номер мобильного телефона пользователя.
        /// Возвращаемые значения: 1 — известен, 0 — не известен
        /// </summary>
        [JsonProperty("has_mobile")]
        public int HasMobile { get; set; }

        /// <summary>
        /// Название родного города
        /// </summary>
        [JsonProperty("home_town")]
        public string HomeTown { get; set; }

        /// <summary>
        /// Содержимое поля «Интересы» из профиля
        /// </summary>
        [JsonProperty("interests")]
        public string Interests { get; set; }

        /// <summary>
        /// Информация о том, есть ли пользователь в закладках у текущего пользователя
        /// 1 - есть; 0 - нет
        /// </summary>
        [JsonProperty("is_favorite")]
        public int IsFavorite { get; set; }

        /// <summary>
        /// Информация о том, является ли пользователь другом текущего пользователя
        /// 1 - да; 0 - нет
        /// </summary>
        [JsonProperty("is_friend")]
        public int IsFriend { get; set; }

        /// <summary>
        /// Информация о том, скрыт ли пользователь из ленты новостей текущего пользователя
        /// 1 - да; 0 - нет
        /// </summary>
        [JsonProperty("is_hidden_from_feed")]
        public int IsHiddenFromFeed { get; set; }

        // /// <summary>
        // /// Фамилия в заданном падеже
        // /// </summary>
        //  [JsonProperty("last_name_case")]
        //  public object LastNameCase { get; set; }

        /// <summary>
        /// Время последнего посещения
        /// </summary>
        [JsonProperty("last_seen")]
        public LastSeen LastSeen { get; set; }

        /// <summary>
        /// Разделенные запятой идентификаторы списков друзей, в которых состоит пользователь.
        /// Поле доступно только для метода friends.get.
        /// </summary>
        [JsonProperty("lists")]
        public string Lists { get; set; }

        [JsonProperty("sex")]
        public long Sex { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }



        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

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

        [JsonProperty("online")]
        public long Online { get; set; }

        [JsonProperty("online_app")]
        public long OnlineApp { get; set; }

        [JsonProperty("online_mobile")]
        public long OnlineMobile { get; set; }

        [JsonProperty("site")]
        public string Site { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }



        [JsonProperty("verified")]
        public long Verified { get; set; }

        [JsonProperty("can_be_invited_group")]
        public bool CanBeInvitedGroup { get; set; }

        //[JsonProperty("occupation")]
        //public Occupation Occupation { get; set; }
    }
}