using SalesPeople.Shared;

namespace SalesPeople.Client.Services.CategoryServices
{
    public interface ICategoryService
    {
        public List<Category> Categories { get; set; }
        Task GetCategories();
        Task<ServiceResponse<Category>> GetCategoryById(int categoryId);
    }
}
