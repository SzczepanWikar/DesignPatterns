namespace Strategy.Strategies
{
    internal class FTPClient : IStorageClient
    {
        public void Download(string fileKey)
        {
            Console.WriteLine("Connect to Azure Blob Storage with Login and Password");
            Console.WriteLine("Downloaded file with key: " + fileKey);
        }

        public void Upload(string content)
        {
            Console.WriteLine("Connect to Azure Blob Storage with Login and Password");
            Console.WriteLine("Uploading file with content: " + content);
        }
    }
}
