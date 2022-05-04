namespace Lab4
{
    internal class File<T>
    {
        public string fileName;
        public double fileSize;
        public FileType fileType;
        public T extension;

        public File(string fileName, double fileSize, FileType fileType, T fileExtension)
        {
            this.fileName = fileName;
            this.fileSize = fileSize;
            this.fileType = fileType;
            this.extension = fileExtension;
        }

        public override string ToString()
        {
            return $"File's name: {fileName}, file's size: {fileSize}, file's type: {fileType}, file's extension: {extension}";
        }
    }
}

enum FileType
{
    images,
    audio,
    video,
    document,
    other
}