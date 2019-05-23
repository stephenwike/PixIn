using System;
using System.Collections.Generic;
using System.IO;

namespace PixIn
{
    public static class Utilities
    {
        public static List<FileInfo> FileSearch(string sDir)
        {
            List<FileInfo> fInfo = new List<FileInfo>();
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    fInfo.Add(new FileInfo(f));
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    FileSearch(d);
                }
                return fInfo;
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
                return fInfo;
            }
        }

        public static byte[] ConvertFileToBytes(Stream input)
        {
            byte[] buffer = new byte[64 * 2048];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }
}
