using SalesPeople.Shared;

namespace SalesPeople.Client.Services.ProductServices
{
    public interface IProductService
    {
        event Action ProductsChanged;
        public List<Product> Products { get; set; }
        Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProductById(int productId);

    }
}
