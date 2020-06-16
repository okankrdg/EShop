using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Specifications
{
    public class ProductsFilterSpecifications:BaseSpecification<Product>
    {
        public ProductsFilterSpecifications(int? categoryId, int? brandId)
        {
            AddCriteria(x => (!categoryId.HasValue || x.CategoryId == categoryId) &&
            (!brandId.HasValue || x.BrandId == brandId));
        }
    }
}
