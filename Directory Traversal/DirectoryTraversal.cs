using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Directory_Traversal
{
    class DirectoryTraversal
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string,double>> fileInfo = new Dictionary<string, Dictionary<string, double>>();
            //Chosing directory:
            DirectoryInfo directoryInfo = new DirectoryInfo("../../../");
            //Gets the files from directory:
            FileInfo[] files = directoryInfo.GetFiles();

            foreach (var file in files)
            {
                if (!fileInfo.ContainsKey(file.Extension))
                {
                    fileInfo.Add(file.Extension, new Dictionary<string, double>());
                }
                fileInfo[file.Extension].Add(file.Name, file.Length/1024.00);
            }
            //this always finds the desktop folder and creates the file we need:
           using StreamWriter writer = new StreamWriter
                ($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\DirectoryTraversal");
            foreach (var item in fileInfo.OrderByDescending(f => f.Value.Count).ThenBy(i => i.Key))
            {
                writer.WriteLine(item.Key);
                foreach (var file in item.Value.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"--{file.Key} - {file.Value:F3}kb");
                }
            }




        }
    }
}
