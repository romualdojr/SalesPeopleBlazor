using SalesPeople.Shared;
using System.Net.Http.Json;

namespace SalesPeople.Client.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public List<Category> Categories { get; set; } = new List<Category>();

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public async Task GetCategories()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
            if (result != null && result.Data != null)
                Categories = result.Data;
        }

        public Task<ServiceResponse<Category>> GetCategoryById(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
