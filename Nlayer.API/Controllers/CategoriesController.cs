using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Nlayer.API.Filters;
using NLayer.Core.Services;

namespace Nlayer.API.Controllers
{
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        // api/categories/GetSingleCategoryByIdWithProducts/2
        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetSingleCategoryByIdWithProducts(int categoryId)
        {

            return CreateActionResult(await _categoryService.GetSingleCategoryByIdWithProductsAsync(categoryId));

        }

    }
}
