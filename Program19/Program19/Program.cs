// static attribute 靜態屬性

using ConsoleApp1;

Console.WriteLine(Video.video_count);

Video video1 = new Video("真D舒服", "阿蔡", "教育");
Console.WriteLine(Video.video_count);

Video video2 = new Video("有那麼舒服?", "阿黑", "娛樂");

Console.WriteLine(video1.getVideoCount());
