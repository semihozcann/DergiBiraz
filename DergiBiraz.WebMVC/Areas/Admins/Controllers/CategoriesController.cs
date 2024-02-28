using DergiBiraz.Business.Abstract;
using DergiBiraz.Entities.DTOs.Categories;
using DergiBiraz.WebMVC.Helpers.Abstract;
using DergiBiraz.WebMVC.Models.Categories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DergiBiraz.WebMVC.Areas.Admins.Controllers
{
    public class CategoriesController : BaseController
    {

        private readonly ICategoryService _categoryService;


        public CategoriesController(IUserAccessor userAccessor, ICategoryService categoryService) : base(userAccessor)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var result = await _categoryService.GetAllAsync();

            if (result.Success)
            {
                var categories = new CategoryListViewModel
                {
                    Categories = result.Data,
                    Message = result.Message
                };
                return View(categories);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryListViewModel categoryListViewModel)
        {
            if (ModelState.IsValid)
            {
                var category = new CategoryAddDto
                {
                    Name = categoryListViewModel.Name
                };

                var result = await _categoryService.AddAsync(category);

                if (result.Success)
                {
                    return RedirectToAction("GetAllCategories");
                }
                return View();
            }
            return View();

        }

        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _categoryService.DeleteAsync(Id);
            if (result.Success)
            {
                return RedirectToAction("GetAllCategories");
            }
            return View();
        }


        public async Task<IActionResult> Update(int Id)
        {
            var result = await _categoryService.GetByIdAsync(Id);

            if (result.Success)
            {
                var category = new CategoryListViewModel
                {
                    Name = result.Data.Name
                };

                return View(category);
            }
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Update(CategoryListViewModel categoryListViewModel)
        {

            if (ModelState.IsValid)
            {
                var category = new CategoryUpdateDto 
                { 
                    Id = categoryListViewModel.Id,
                    Name = categoryListViewModel.Name 
                };

                var result = await _categoryService.UpdateAsync(category);

                if (result.Success)
                {
                    return RedirectToAction("GetAllCategories");
                }
                return View();
            }
            return View();
        }


    }
}
