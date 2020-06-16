using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Specifications
{
    public class ProductsFilterPaginatedSpecifications : BaseSpecification<Product>
    {
        public ProductsFilterPaginatedSpecifications(int? categoryId, int? brandId, int skip, int take)
        {
            AddCriteria(x => (!categoryId.HasValue || x.CategoryId == categoryId) &&
            (!brandId.HasValue || x.BrandId == brandId));
            ApplyPaging(skip, take);
        }
    }
}
