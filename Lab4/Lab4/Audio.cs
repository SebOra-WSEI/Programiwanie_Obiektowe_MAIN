using System.Collections.Generic;

namespace Lab4
{
    internal class Audio
    {
        public List<File<AudioExtension>> audioList;

        public Audio()
        {
            audioList = new List<File<AudioExtension>>()
            {
            new File<AudioExtension>("file1", 9.0, FileType.audio, AudioExtension.ogg),
            new File<AudioExtension>("file1", 0.1, FileType.audio, AudioExtension.ogg),
            new File<AudioExtension>("file1", 2.2, FileType.audio, AudioExtension.ogg),
            new File<AudioExtension>("file1", 3.3, FileType.audio, AudioExtension.mp3),
            new File<AudioExtension>("file1", 4.4, FileType.audio, AudioExtension.mp3),
            new File<AudioExtension>("file1", 1.2, FileType.audio, AudioExtension.mp3),
            new File<AudioExtension>("file1", 3.4, FileType.audio, AudioExtension.mp3),
            };
        }
    }
}

enum AudioExtension
{
    ogg,
    mp3
}
