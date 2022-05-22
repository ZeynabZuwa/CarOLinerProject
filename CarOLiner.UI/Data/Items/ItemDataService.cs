namespace CarOLiner.UI.Data.Items
{
    public class ItemDataService : IItemDataService
    {
        private readonly HttpClient _httpClient;

        public ItemDataService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient)); ;
        }
    }
}
