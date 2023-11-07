using System;
using System.IO;

namespace FileDownloaderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/2014_BMW.JPG/420px-2014_BMW.JPG";
            string currentDirectory = Directory.GetCurrentDirectory();
            string localFilePath = Path.Combine(currentDirectory, "bmw.jpg");

            FileDownloader fileDownloader = new FileDownloader(imageUrl, localFilePath);
            fileDownloader.StartFileDownload();

            Console.ReadLine();
        }
    }
}