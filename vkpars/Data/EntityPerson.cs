using Newtonsoft.Json;
using System.Collections.Generic;

namespace vkpars.Data
{
    /// <summary>
    /// Пользователь
    /// </summary>
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

        /// <summary>
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
        public int CanWritePrivateMessage { get; set; }

        /// <summary>
        /// Информация о том, будет ли отправлено уведомление пользователю о заявке в друзья от текущего пользователя
        /// 1 —  уведомление будет отправлено; 0 —  уведомление не будет отправлено
        /// </summary>
        [JsonProperty("can_send_friend_request")]
        public int CanSendFriendRequest { get; set; }

        /// <summary>
        /// Информация о карьере пользователя
        /// </summary>
        [JsonProperty("career")]
        public List<Career> Careers { get; set; }

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

        // /// <summary>
        // /// Количество различных объектов у пользователя.
        // /// Поле возвращается только в методе users.get
        // /// при запросе информации об одном пользователе,
        // /// с передачей пользовательского access_token
        // /// </summary>
        // [JsonProperty("counters")]
        // public object Counters { get; set; }

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
        /// Количество подписчиков пользователя
        /// </summary>
        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }

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

        /// <summary>
        /// Время последнего посещения
        /// </summary>
        [JsonProperty("last_seen")]
        public LastSeen LastSeen { get; set; }

        // /// <summary>
        // /// Разделенные запятой идентификаторы списков друзей, в которых состоит пользователь.
        // /// Поле доступно только для метода friends.get.
        // /// </summary>
        // [JsonProperty("lists")]
        // public string Lists { get; set; }

        /// <summary>
        /// Девичья фамилия
        /// </summary>
        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        /// <summary>
        /// Информация о военной службе пользователя
        /// </summary>
        [JsonProperty("military")]
        public List<Military> Military { get; set; }

        /// <summary>
        /// Содержимое поля «Любимые фильмы» из профиля пользователя
        /// </summary>
        [JsonProperty("movies")]
        public string Movies { get; set; }

        /// <summary>
        /// Содержимое поля «Любимая музыка» из профиля пользователя
        /// </summary>
        [JsonProperty("music")]
        public string Music { get; set; }

        /// <summary>
        /// Никнейм (отчество) пользователя
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// Информация о текущем роде занятия пользователя
        /// </summary>
        [JsonProperty("occupation")]
        public Occupation Occupation { get; set; }

        /// <summary>
        /// Информация о том, находится ли пользователь сейчас на сайте
        /// </summary>
        [JsonProperty("online")]
        public int Online { get; set; }

        /// <summary>
        /// Если используется именно приложение, дополнительно возвращается поле содержащее его идентификатор
        /// </summary>
        [JsonProperty("online_app")]
        public int OnlineApp { get; set; }

        /// <summary>
        /// Если пользователь использует мобильное приложение либо мобильную версию 
        /// </summary>
        [JsonProperty("online_mobile")]
        public int OnlineMobile { get; set; }

        /// <summary>
        /// Информация о полях из раздела «Жизненная позиция» 
        /// </summary>
        [JsonProperty("personal")]
        public Personal Personal { get; set; }

        /// <summary>
        /// url квадратной фотографии пользователя, имеющей ширину 50 пикселей.
        /// В случае отсутствия у пользователя фотографии возвращается https://vk.com/images/camera_50.png
        /// </summary>
        [JsonProperty("photo_50")]
        public string Photo50 { get; set; }

        /// <summary>
        /// url квадратной фотографии пользователя, имеющей ширину 100 пикселей.
        /// В случае отсутствия у пользователя фотографии возвращается https://vk.com/images/camera_100.png
        /// </summary>
        [JsonProperty("photo_100")]
        public string Photo100 { get; set; }

        /// <summary>
        /// url квадратной фотографии, имеющей ширину 200 пикселей.
        /// Если у пользователя отсутствует фотография таких размеров, в ответе вернется https://vk.com/images/camera_200.png
        /// </summary>
        [JsonProperty("photo_200")]
        public string Photo200 { get; set; }

        /// <summary>
        /// url фотографии пользователя, имеющей ширину 200 пикселей.
        /// В случае отсутствия у пользователя фотографии возвращается https://vk.com/images/camera_200.png
        /// </summary>
        [JsonProperty("photo_200_orig")]
        public string Photo200_Orig { get; set; }

        /// <summary>
        /// url квадратной фотографии с максимальной шириной.
        /// Может быть возвращена фотография, имеющая ширину как 200, так и 100 пикселей.
        /// В случае отсутствия у пользователя фотографии возвращается https://vk.com/images/camera_200.png
        /// </summary>
        [JsonProperty("photo_max")]
        public string PhotoMax { get; set; }

        /// <summary>
        /// url фотографии, имеющей ширину 400 пикселей.
        /// Если у пользователя отсутствует фотография такого размера, в ответе вернется https://vk.com/images/camera_400.png
        /// </summary>
        [JsonProperty("photo_400_orig")]
        public string Photo400_Orig { get; set; }

        /// <summary>
        /// url фотографии максимального размера.
        /// Может быть возвращена фотография, имеющая ширину как 400, так и 200 пикселей.
        /// В случае отсутствия у пользователя фотографии возвращается https://vk.com/images/camera_400.png
        /// </summary>
        [JsonProperty("photo_max_orig")]
        public string PhotoMaxOrig { get; set; }

        /// <summary>
        /// Строковый идентификатор главной фотографии профиля пользователя в формате {user_id}_{photo_id},
        /// например, 6492_192164258. Обратите внимание, это поле может отсутствовать в ответе
        /// </summary>
        [JsonProperty("photo_id")]
        public string PhotoId { get; set; }

        /// <summary>
        /// Любимые цитаты
        /// </summary>
        [JsonProperty("quotes")]
        public string Quotes { get; set; }

        /// <summary>
        /// Список родственников
        /// </summary>
        [JsonProperty("relatives")]
        public List<Relative> Relatives { get; set; }

        /// <summary>
        /// Семейное положение
        /// 1 — не женат/не замужем; 2 — есть друг/есть подруга;
        /// 3 — помолвлен/помолвлена; 4 — женат/замужем;
        /// 5 — всё сложно; 6 — в активном поиске;
        /// 7 — влюблён/влюблена; 8 — в гражданском браке;
        /// 0 — не указано
        /// </summary>
        [JsonProperty("relation")]
        public int Relation { get; set; }

        /// <summary>
        /// Если в семейном положении указан другой пользователь,
        /// дополнительно возвращается объект relation_partner, содержащий id и имя этого человека
        /// </summary>
        [JsonProperty("relation_partner")]
        public RelationPartner RelationPartner { get; set; }

        /// <summary>
        /// Список школ, в которых учился пользователь
        /// </summary>
        [JsonProperty("schools")]
        public List<School> Schools { get; set; }

        /// <summary>
        /// Короткое имя страницы
        /// </summary>
        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        /// <summary>
        /// Пол
        /// 1 — женский; 2 — мужской; 0 — пол не указан
        /// </summary>
        [JsonProperty("sex")]
        public int Sex { get; set; }

        /// <summary>
        /// Адрес сайта, указанный в профиле
        /// </summary>
        [JsonProperty("site")]
        public string Site { get; set; }

        /// <summary>
        /// Статус пользователя.
        /// Возвращается строка, содержащая текст статуса, расположенного в профиле под именем.
        /// Если включена опция «Транслировать в статус играющую музыку»,
        /// возвращается дополнительное поле status_audio, содержащее информацию о композиции
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        // /// <summary>
        // /// Временная зона. Только при запросе информации о текущем пользователе
        // /// </summary>
        // [JsonProperty("timezone")]
        // public int Timezone { get; set; }

        /// <summary>
        /// Информация о том, есть ли на странице пользователя «огонёк»
        /// </summary>
        [JsonProperty("trending")]
        public int Trending { get; set; }

        /// <summary>
        /// Любимые телешоу
        /// </summary>
        [JsonProperty("tv")]
        public string Tv { get; set; }

        /// <summary>
        /// Возвращается 1, если страница пользователя верифицирована, 0 — если нет
        /// </summary>
        [JsonProperty("verified")]
        public int Verified { get; set; }

        /// <summary>
        /// Режим стены по умолчанию. Возможные значения: owner, all
        /// </summary>
        [JsonProperty("wall_default")]
        public string WallDefault { get; set; }

        /// <summary>
        /// Видимо можно ли приглашать в группы
        /// </summary>
        [JsonProperty("can_be_invited_group")]
        public bool CanBeInvitedGroup { get; set; }

        /// <summary>
        /// Список вузов, в которых учился пользователь
        /// </summary>
        [JsonProperty("universities")]
        public List<University> Universities { get; set; }

        /// <summary>
        /// Имя в Skype
        /// </summary>
        [JsonProperty("skype")]
        public string Skype { get; set; }

        /// <summary>
        /// Идентификатор Facebook
        /// </summary>
        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        /// <summary>
        /// Имя в Facebook
        /// </summary>
        [JsonProperty("facebook_name")]
        public string FacebookName { get; set; }

        /// <summary>
        /// Имя в Livejournal
        /// </summary>
        [JsonProperty("livejournal")]
        public string Livejournal { get; set; }

        /// <summary>
        /// Имя в Twitter
        /// </summary>
        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        /// <summary>
        /// Имя в Instagram
        /// </summary>
        [JsonProperty("instagram")]
        public string Instagram { get; set; }

        /// <summary>
        /// Мобильный телефон
        /// </summary>
        [JsonProperty("mobile_phone")]
        public string MobilePhone { get; set; }
      
        /// <summary>
        /// Домашний телефон
        /// </summary>
        [JsonProperty("home_phone")]
        public string HomePhone { get; set; }

        // Для старых профилей видимо так,
        // надо добавлять в коллекцию универов эти поля если они заполнены

        /// <summary>
        /// Идентификатор университета (видимо в старых профилях)
        /// </summary>
        [JsonProperty("university")]
        public int University { get; set; }

        /// <summary>
        /// Наименование университета (видимо в старых профилях)
        /// </summary>
        [JsonProperty("university_name")]
        public string UniversityName { get; set; }

        /// <summary>
        /// Идентификатор факультета (видимо в старых профилях)
        /// </summary>
        [JsonProperty("faculty")]
        public int Faculty { get; set; }

        /// <summary>
        /// Наименование факультета (видимо в старых профилях)
        /// </summary>
        [JsonProperty("faculty_name")]
        public string FacultyName { get; set; }

        /// <summary>
        /// Год окончания обучения (видимо в старых профилях)
        /// </summary>
        [JsonProperty("graduation")]
        public int Graduation { get; set; }

        /// <summary>
        /// Форма обучения (видимо в старых профилях)
        /// </summary>
        [JsonProperty("education_form")]
        public string EducationForm { get; set; }

        /// <summary>
        /// Статус(например, «Выпускник (специалист)») (видимо в старых профилях)
        /// </summary>
        [JsonProperty("education_status")]
        public string EducationStatus { get; set; }
    }
}