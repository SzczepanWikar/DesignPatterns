namespace Strategy.Strategies
{
    internal class S3Client : IStorageClient
    {
        public void Download(string fileKey)
        {
            Console.WriteLine("Connect to Amazon S3 with Access Key and Secret Key");
            Console.WriteLine("Downloaded file with key: " + fileKey);
        }

        public void Upload(string content)
        {
            Console.WriteLine("Connect to Amazon S3 with Access Key and Secret Key");
            Console.WriteLine("Uploading file with content: " + content);
        }
    }
}
