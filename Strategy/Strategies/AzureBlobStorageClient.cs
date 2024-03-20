namespace Strategy.Strategies
{
    internal class AzureBlobStorageClient : IStorageClient
    {
        public void Download(string fileKey)
        {
            Console.WriteLine("Connect to Azure Blob Storage with ConnectionString");
            Console.WriteLine("Downloaded file with key: " + fileKey);
        }

        public void Upload(string content)
        {
            Console.WriteLine("Connect to Azure Blob Storage with ConnectionString");
            Console.WriteLine("Uploading file with content: " + content);
        }
    }
}
