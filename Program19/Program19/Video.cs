namespace ConsoleApp1
{
    class Video
    {
        public string title;
        public string author;
        public string type;
        public static int video_count = 0;


        public Video(string title, string author, string type)
        {
            this.title = title;
            this.author = author;
            this.type = type;
            video_count++;
        }

        public int getVideoCount()
        {
            return video_count;
        }
    }
}