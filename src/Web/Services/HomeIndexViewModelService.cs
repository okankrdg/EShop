using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Specifications;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Interfaces;
using Web.ViewModels;

namespace Web.Services
{
    public class HomeIndexViewModelService : IHomeIndexViewModelService
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<Product> _productRepository;
        private readonly IAsyncRepository<Brand> _brandRepository;

        public HomeIndexViewModelService(IAsyncRepository<Category> categoryRepository, IAsyncRepository<Product> productRepository, IAsyncRepository<Brand> brandRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
            _brandRepository = brandRepository;
        }
        public async Task<List<SelectListItem>> GetBrands()
        {
            var brands = await _brandRepository.ListAllAsync();
            var items = brands.
                Select(x => new SelectListItem() 
                { Value = x.Id.ToString(), Text = x.BrandName }).OrderBy(x => x.Text).ToList();
            var allItem = new SelectListItem() { Value = null, Text = "All" };
            items.Insert(0,allItem);
            return items;
        }

        public async Task<List<SelectListItem>> GetCategories()
        {
            var categories = await _categoryRepository.ListAllAsync();
            var items = categories.
                Select(x => new SelectListItem()
                { Value = x.Id.ToString(), Text = x.CategoryName }).OrderBy(x => x.Text).ToList();
            var allItem = new SelectListItem() { Value = null, Text = "All" };
            items.Insert(0,allItem);
            return items;
        }

        public async Task<HomeIndexViewModel> GetHomeIndexViewModel(int pageIndex, int itemsPerPage,int? brandId, int? categoryId)
        {
            int totalItems = await _productRepository
                .CountAsync(new ProductsFilterSpecifications(categoryId, brandId));
            var products = await _productRepository.ListAllAsync(
                new ProductsFilterPaginatedSpecifications(categoryId, brandId, (pageIndex - 1) * itemsPerPage, itemsPerPage));

            var vm = new HomeIndexViewModel
            {
                Categories = await GetCategories(),
                Brands = await GetBrands(),
                BrandId = brandId,
                CategoryId = categoryId,
                Products = (
                    products.Select(x=> new ProductViewModel 
                    { 
                        Id=x.Id,
                        Description=x.Description,
                        PhotoPath=string.IsNullOrEmpty(x.PhotoPath) ? "no-product-image.png" : x.PhotoPath,
                        ProductName=x.ProductName,
                        UnitPrice=x.UnitPrice
                    }).ToList()
                    ),
                PaginationInfo= new PaginationInfoViewModel()
                {
                    CurrentPage = pageIndex,
                    ItemsOnPage = products.Count,
                    TotalItems = totalItems,
                    TotalPages = int.Parse(Math.Ceiling(((decimal)totalItems / itemsPerPage)).ToString())
                }

            };
            return vm;
        }
    }
}
