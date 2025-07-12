namespace Infrastructure.Integrations
{
    public class LocalizationService : ILocalizationService
    {
        public LocalizationService(/* inject config here */) { }
        public string GetString(string key, string culture) => key; // implement
    }
} 