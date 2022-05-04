using System.Collections.Generic;

namespace Lab4
{
    internal class Video
    {
        public List<File<VideoExtension>> videoList;

        public Video()
        {
            videoList = new List<File<VideoExtension>>()
            {
            new File<VideoExtension>("file1", 9.0, FileType.video, VideoExtension.mkv),
            new File<VideoExtension>("file1", 0.1, FileType.video, VideoExtension.mkv),
            new File<VideoExtension>("file1", 2.2, FileType.video, VideoExtension.mkv),
            new File<VideoExtension>("file1", 3.3, FileType.video, VideoExtension.mp4),
            new File<VideoExtension>("file1", 4.4, FileType.video, VideoExtension.mp4),
            new File<VideoExtension>("file1", 1.2, FileType.video, VideoExtension.mp4),
            new File<VideoExtension>("file1", 3.4, FileType.video, VideoExtension.mp4),
            new File<VideoExtension>("file1", 5.6, FileType.video, VideoExtension.webm),
            new File<VideoExtension>("file1", 9.0, FileType.video, VideoExtension.webm),
            };
        }
    }
}
 enum VideoExtension
{
    mkv,
    mp4,
    webm
}