using Strategy.Strategies;

namespace Strategy
{
    internal class StorageStrategyFactory
    {
        private S3Client _s3Client { get; } = new S3Client();
        private AzureBlobStorageClient _azureBlob { get; } = new AzureBlobStorageClient();
        private FTPClient _ftpClient { get; } = new FTPClient();

        public IStorageClient GetStrategy(AssetStorage assetStorage)
        {
            switch(assetStorage)
            {
                case AssetStorage.AmazonS3:
                    return _s3Client;
                case AssetStorage.AzureBlobStorage: 
                    return _azureBlob;
                case AssetStorage.FTP: 
                    return _ftpClient;
                default: 
                    throw new NotImplementedException();
            }
        }
    }
}
