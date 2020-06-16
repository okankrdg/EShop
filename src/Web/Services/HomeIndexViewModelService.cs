using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
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

        public async Task<HomeIndexViewModel> GetHomeIndexViewModel(int? brandId, int? categoryId)
        {
            var vm = new HomeIndexViewModel
            {
                Categories = await GetCategories(),
                Brands = await GetBrands(),
                Products = await _productRepository.
                    ListAllAsync(x=>
                    (!categoryId.HasValue || x.CategoryId==categoryId) && (!brandId.HasValue || x.BrandId == brandId)),
                BrandId=brandId,
                CategoryId=categoryId
            };
            return vm;
        }
    }
}
