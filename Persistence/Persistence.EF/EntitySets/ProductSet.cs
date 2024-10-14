﻿using CleanArchitecture.Application.Common.Exceptions;
using Microsoft.EntityFrameworkCore;
using CleanArchitecture.Domain.Product.Entites;
using CleanArchitecture.Persistence.EF;
using CleanArchitecture.Application.Products.IEntitySets;

namespace CleanArchitecture.Persistence.EF.EntitySets
{
    public class ProductSet : EntitySet<Product>, IProductSet
    {
        #region Constructor
        public ProductSet(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        #endregion

        #region Custom Methods
        public async Task<ProductItem> GetProductItemAsync(Guid productItemId)
        {
            //return await Context.Set<Product>()
            //                             .Include(p => p.ProductItems)
            //                             .SelectMany(p => p.ProductItems)
            //                             .FirstOrDefaultAsync(pi => pi.Id == productItemId)
            return await Context.Set<ProductItem>().AsTracking().FirstOrDefaultAsync(pi => pi.Id == productItemId)
                          ?? throw new NotFoundException("this item not found", productItemId);
        }
        #endregion
    }
}
