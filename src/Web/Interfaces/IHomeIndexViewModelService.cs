using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewModels;

namespace Web.Interfaces
{
    public interface IHomeIndexViewModelService
    {
        Task<HomeIndexViewModel> GetHomeIndexViewModel();
        Task<List<SelectListItem>> GetBrands();
        Task<List<SelectListItem>> GetCategories();
    }
}
