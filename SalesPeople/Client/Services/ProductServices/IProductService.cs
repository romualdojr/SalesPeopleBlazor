using SalesPeople.Shared;

namespace SalesPeople.Client.Services.ProductServices
{
    public interface IProductService
    {
        public List<Product> Products { get; set; }
        Task GetProducts();
        Task<ServiceResponse<Product>> GetProductById(int productId);

    }
}
