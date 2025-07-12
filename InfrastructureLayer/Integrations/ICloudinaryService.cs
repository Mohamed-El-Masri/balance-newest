namespace Infrastructure.Integrations
{
    public interface ICloudinaryService
    {
        string UploadImage(byte[] file, string fileName);
        bool DeleteImage(string publicId);
    }
} 