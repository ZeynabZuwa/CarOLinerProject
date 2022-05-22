namespace CarOLiner.UI.Data.Variants
{
    public class VariantDataService : IVariantDataService
    {
        private readonly HttpClient _httpClient;

        public VariantDataService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient)); ;
        }
    }
}
