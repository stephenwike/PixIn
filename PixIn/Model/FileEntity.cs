using System;

namespace PixIn
{
    [Serializable]
    public class FileEntity
    {
        public string FileName { get; internal set; }
        public byte[] FileData { get; internal set; }
    }
}