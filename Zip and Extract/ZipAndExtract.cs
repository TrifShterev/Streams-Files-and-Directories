using System;
using System.IO.Compression;

namespace Zip_and_Extract
{
    class ZipAndExtract
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\Users\tshte\OneDrive\Työpöytä\Нова папка", @"C:\Users\tshte\OneDrive\Työpöytä\zipFileDemo\zipFile.zip");

            ZipFile.ExtractToDirectory
                (@"C:\Users\tshte\OneDrive\Työpöytä\zipFileDemo\zipFile.zip",
                @"C:\Users\tshte\OneDrive\Työpöytä\zipFileDemoResult");
        }
    }
}
