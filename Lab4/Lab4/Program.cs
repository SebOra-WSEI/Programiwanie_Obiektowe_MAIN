using System;
using System.Collections.Generic;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = new ByType();
            Console.WriteLine(x);



















            var fileTypes = new Dictionary<string, string>()
        {
            {"png",  "images"},
            {"webp",  "images"},
            {"jpg",  "images"},
            {"gif",  "images"},
            {"tiff",  "images"},

            {"ogg", "audio" },
            {"mp3", "audio" },

            {"mkv", "video"},
            {"mp4", "video"},
            {"webm", "video"},

            {"txt", "document"},
            {"doc", "document"},
            {"docx", "document"},
            {"xml", "document"},
            {"xlmx", "document"},

            {"other", "other" }
        };

            foreach (KeyValuePair<string, string> entry in fileTypes)
            {
                //Console.WriteLine($"Key: {entry.Key}, value: {entry.Value}");
            }
        }
    }
}
