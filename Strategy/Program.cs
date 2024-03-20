using Strategy;

var strategyFactory = new StorageStrategyFactory();

strategyFactory.GetStrategy(AssetStorage.AzureBlobStorage).Upload("Upload Test");
Console.WriteLine();
strategyFactory.GetStrategy(AssetStorage.AmazonS3).Download("eafawhnfkanbdkbasndhidbaskn");