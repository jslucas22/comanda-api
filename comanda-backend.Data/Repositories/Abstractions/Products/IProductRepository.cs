using System;
using comanda_backend.Domain.Models.Products;

namespace comanda_backend.Data.Repositories.Abstractions.Products
{
	public interface IProductRepository
	{
		/// <summary>
		/// return products
		/// </summary>
		/// <returns></returns>
		Task<IQueryable<ProductsModel>> Get();
        /// <summary>
        /// return product info
        /// </summary>
        /// <returns></returns>
        Task<IQueryable<ProductsModel>> Get(Guid id);
        /// <summary>
        /// Insert products
        /// </summary>
        /// <param name="product">model content</param>
        /// <returns></returns>        
        Task Insert(ProductsModel product);
		/// <summary>
		/// Update product
		/// </summary>
		/// <param name="product">model content</param>
		/// <returns></returns>
		Task Update(ProductsModel product);
        /// <summary>
        /// Delete a product
        /// </summary>
        /// <param name="id">product id</param>
        /// <returns></returns>
        Task Delete(Guid id);
    }
}

