using System;
using comanda_backend.Business.Services.Abstractions.Products;
using comanda_backend.Data.Repositories.Abstractions.Products;
using comanda_backend.Data.Repositories.Products;
using comanda_backend.Domain.Models.Products;

namespace comanda_backend.Business.Services.Products
{
	public class ProductService : IProductService
	{
        #region ..:: Variables ::..

        private readonly IProductRepository _repository;

        #endregion

        #region ..:: Constructor ::..

        public ProductService()
		{
            _repository = new ProductRepository();
		}

        #endregion

        #region ..:: Methods ::..

        public async Task<IQueryable<ProductsModel>> Get()
        {
           return await _repository.Get();
        }

        public async Task<IQueryable<ProductsModel>> Get(Guid id)
        {
            return await _repository.Get(id);
        }

        public async Task Insert(ProductsModel product)
        {
            await _repository.Insert(product);
        }

        public async Task Update(ProductsModel product)
        {
            await _repository.Update(product);
        }

        public async Task Delete(Guid id)
        {
            await _repository.Delete(id);
        }

        #endregion
    }
}

