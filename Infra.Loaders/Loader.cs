namespace Infra.Loaders
{
    public abstract class Loader
    {
        private const string AssetsPath = @"..\..\..\..\Assets";
        public abstract string DirectoryName { get; }

        public string GetFilePath(string filePath)
        {
            return Path.Combine(AssetsPath, DirectoryName, filePath);
        }
    }
}