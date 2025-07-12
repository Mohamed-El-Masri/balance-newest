namespace Infrastructure.Integrations
{
    public class CloudinaryService : ICloudinaryService
    {
        public CloudinaryService(/* inject config here */) { }
        public string UploadImage(byte[] file, string fileName) => ""; // implement
        public bool DeleteImage(string publicId) => true; // implement
    }
} 