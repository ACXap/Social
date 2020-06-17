using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK.Data
{

    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string deactivated { get; set; }
        public int sex { get; set; }
        public int has_photo { get; set; }
        public string photo_50 { get; set; }
        public string photo_100 { get; set; }
        public string photo_200_orig { get; set; }
        public string photo_200 { get; set; }
        public string photo_400_orig { get; set; }
        public string photo_max { get; set; }
        public string photo_max_orig { get; set; }
        public int online { get; set; }
        public string domain { get; set; }
        public int can_post { get; set; }
        public int can_write_private_message { get; set; }
        public int is_favorite { get; set; }
        public int friend_status { get; set; }
        public bool is_closed { get; set; }
        public bool can_access_closed { get; set; }
        public string nickname { get; set; }
        public string maiden_name { get; set; }
        public string screen_name { get; set; }
        public string bdate { get; set; }
        public City city { get; set; }
        public Country country { get; set; }
        public int has_mobile { get; set; }
        public int is_friend { get; set; }
        public int can_see_all_posts { get; set; }
        public int can_see_audio { get; set; }
        public int can_send_friend_request { get; set; }
        public string site { get; set; }
        public string status { get; set; }
        public Last_Seen last_seen { get; set; }
        public int verified { get; set; }
        public bool can_be_invited_group { get; set; }
        public int followers_count { get; set; }
        public int blacklisted { get; set; }
        public int blacklisted_by_me { get; set; }
        public int is_hidden_from_feed { get; set; }
        public int common_count { get; set; }
        public string photo_id { get; set; }
        public Crop_Photo crop_photo { get; set; }
        public Occupation occupation { get; set; }
        public string mobile_phone { get; set; }
        public string home_phone { get; set; }
        public Career[] career { get; set; }
        public int university { get; set; }
        public string university_name { get; set; }
        public int faculty { get; set; }
        public string faculty_name { get; set; }
        public int graduation { get; set; }
        public string home_town { get; set; }
        public int relation { get; set; }
        public RelationPartner relation_partner { get; set; }
        public Personal personal { get; set; }
        public string interests { get; set; }
        public string music { get; set; }
        public string activities { get; set; }
        public string movies { get; set; }
        public string tv { get; set; }
        public string books { get; set; }
        public string games { get; set; }
        public University[] universities { get; set; }
        public School[] schools { get; set; }
        public string about { get; set; }
        public Relative[] relatives { get; set; }
        public string quotes { get; set; }
        public string twitter { get; set; }
        public string instagram { get; set; }
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool is_closed { get; set; }
        public bool can_access_closed { get; set; }
        public int sex { get; set; }
        public string nickname { get; set; }
        public string maiden_name { get; set; }
        public string domain { get; set; }
        public string screen_name { get; set; }
        public string bdate { get; set; }
        public string photo_50 { get; set; }
        public string education_form { get; set; }
        public string education_status { get; set; }
        public string skype { get; set; }
        public string facebook { get; set; }
        public string facebook_name { get; set; }
        public string livejournal { get; set; }
        public int online_app { get; set; }
        public int online_mobile { get; set; }
        public City city { get; set; }
        public Country country { get; set; }
    }

    public class City
    {
        public int id { get; set; }
        public string title { get; set; }
    }

    public class Country
    {
        public int id { get; set; }
        public string title { get; set; }
    }

    public class Last_Seen
    {
        public int time { get; set; }
        public int platform { get; set; }
    }

    public class Crop_Photo
    {
        public Photo photo { get; set; }
        public Crop crop { get; set; }
        public Rect rect { get; set; }
    }

    public class Photo
    {
        public int album_id { get; set; }
        public int date { get; set; }
        public int id { get; set; }
        public int owner_id { get; set; }
        public bool has_tags { get; set; }
        public int post_id { get; set; }
        public Size[] sizes { get; set; }
        public string text { get; set; }
        public float lat { get; set; }
        public float _long { get; set; }
    }

    public class Size
    {
        public int height { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public int width { get; set; }
    }

    public class Crop
    {
        public float x { get; set; }
        public float y { get; set; }
        public float x2 { get; set; }
        public float y2 { get; set; }
    }

    public class Rect
    {
        public float x { get; set; }
        public float y { get; set; }
        public float x2 { get; set; }
        public float y2 { get; set; }
    }

    public class Occupation
    {
        public string type { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }
}