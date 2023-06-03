using System;
using comanda_backend.Data.Repositories.Abstractions.Products;
using comanda_backend.Domain.Models.Products;

namespace comanda_backend.Data.Repositories.Products
{
	public class ProductRepository : IProductRepository
	{
        public Task<IQueryable<ProductsModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<ProductsModel>> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(ProductsModel product)
        {
            throw new NotImplementedException();
        }

        public Task Update(ProductsModel product)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

