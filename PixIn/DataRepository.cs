using System;
using Microsoft.Extensions.Configuration;

namespace PixIn
{
    internal class DataRepository
    {
        public static PixInConfig Config { get; internal set; }

        internal static void ValidateAndReadConfig(IConfigurationRoot config)
        {
            string rootDir = config["RootDirectory"];
            string rootDirValid = !string.IsNullOrEmpty(rootDir) ? rootDir : @"Examples";

            Config = new PixInConfig()
            {
                RootDirectory = rootDirValid
            };
        }
    }
}