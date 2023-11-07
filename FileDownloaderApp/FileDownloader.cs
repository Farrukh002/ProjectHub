using System;
using System.ComponentModel;
using System.IO;
using System.Net;

namespace FileDownloaderApp
{
    public class FileDownloader
    {
        private readonly string localFilePath;
        private readonly string webUrlFile;

        public FileDownloader(string webUrlFile, string localFilePath)
        {
            this.webUrlFile = webUrlFile;
            this.localFilePath = localFilePath;
        }

        public void StartFileDownload()
        {
            using (WebClient webClient = new WebClient())
            {
                if (File.Exists(localFilePath))
                {
                    File.Delete(localFilePath);
                }

                webClient.DownloadProgressChanged += DownloadProgressChanged;
                webClient.DownloadFileCompleted += DownloadFileCompleted;

                webClient.DownloadFileAsync(new Uri(webUrlFile), localFilePath);
            }
        }

        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine("Downloaded {0} of {1} bytes. {2} % complete...",
                e.BytesReceived, e.TotalBytesToReceive, e.ProgressPercentage);
        }

        private void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Download completed!");
        }
    }
}