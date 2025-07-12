namespace Infrastructure.Integrations
{
    public interface ILocalizationService
    {
        string GetString(string key, string culture);
    }
} 