namespace vkpars.Data
{
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

    public class CropPhoto
    {
        public Photo photo { get; set; }
        public Crop crop { get; set; }
        public Rect rect { get; set; }
    }

    public class Rect
    {
        public float x { get; set; }
        public float y { get; set; }
        public float x2 { get; set; }
        public float y2 { get; set; }
    }
    public class Crop
    {
        public float x { get; set; }
        public float y { get; set; }
        public float x2 { get; set; }
        public float y2 { get; set; }
    }
    public class Size
    {
        public int height { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public int width { get; set; }
    }
}