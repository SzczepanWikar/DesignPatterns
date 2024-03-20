namespace Strategy
{
    internal interface IStorageClient
    {
        public void Upload(string content);
        public void Download(string fileKey);
    }
}
