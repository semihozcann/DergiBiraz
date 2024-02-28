using DergiBiraz.Business.Abstract;
using DergiBiraz.Entities.Concrete;
using DergiBiraz.Entities.DTOs.Articles;
using DergiBiraz.WebMVC.Helpers.Abstract;
using DergiBiraz.WebMVC.Models.Articles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DergiBiraz.WebMVC.Areas.Admins.Controllers
{
    public class ArticlesController : BaseController
    {

        private readonly IArticleService _articleService;
        private readonly IWriterService _writerService;
        private readonly ICategoryService _categoryService;
        private readonly IFileHelper _fileHelper;

        public ArticlesController(IUserAccessor userAccessor, IArticleService articleService, IWriterService writerService, ICategoryService categoryService, IFileHelper fileHelper) : base(userAccessor)
        {
            _articleService = articleService;
            _writerService = writerService;
            _categoryService = categoryService;
            _fileHelper = fileHelper;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> GetAllArticles()
        {
            var writer = await _writerService.GetAllAsync();
            var result = await _articleService.GetAllAsync();

            if (result.Success)
            {
                var articles = new ArticleListViewModel
                {
                    Articles = result.Data,
                    Message = result.Message
                };

                return View(articles);
            }
            return View();
        }

        public async Task<IActionResult> GetArticleDetail(int Id)
        {
            var writer = await _writerService.GetAllAsync();
            var result = await _articleService.GetByIdAsync(Id);

            if (result.Success)
            {
                var article = new ArticleDetailViewModel
                {
                    Article = result.Data,
                    Message = result.Message
                };

                return View(article);
            }
            return View();
        }

        public async Task<IActionResult> Add()
        {
            var model = new ArticleAddViewModel();

            var writer = await _writerService.GetAllAsync();


            List<SelectListItem> writers = (from x in writer.Data.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.FirstName + " " + x.LastName,
                                                Value = x.Id.ToString(),
                                            }).ToList();
            model.WritersForDr = writers;

            var category = await _categoryService.GetAllAsync();

            List<SelectListItem> categories = (from x in category.Data.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.Id.ToString(),
                                               }).ToList();
            model.CategoriesForDr = categories;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddViewModel articleAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var article = new ArticleAddDto
                {
                    WriterId = articleAddViewModel.WriterId,
                    CategoryId = articleAddViewModel.CategoryId,
                    Name = articleAddViewModel.Name,
                    Content = articleAddViewModel.Content
                };

                if (articleAddViewModel.ImageUrl != null)
                {
                    var fileName = articleAddViewModel.ImageUrl;
                    var imageFile = _fileHelper.UploadFile(fileName);
                    article.ImageUrl = imageFile;
                }

                

                var result = await _articleService.AddAsync(article);
                if (result.Success)
                {
                    return RedirectToAction("GetAllArticles");
                }
                return View(articleAddViewModel);
            }
            return View();
        }


        public async Task<IActionResult> Update(int Id)
        {
            var result = await _articleService.GetByIdAsync(Id);

            if (result.Success)
            {
                var article = new ArticleUpdateViewModel
                {
                    Id = result.Data.Id,
                    Name = result.Data.Name,
                    Content = result.Data.Content,
                    OldImageUrl = result.Data.ImageUrl
                };



                var writer = await _writerService.GetAllAsync();


                List<SelectListItem> writers = (from x in writer.Data.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = x.FirstName + " " + x.LastName,
                                                    Value = x.Id.ToString(),
                                                }).ToList();
                article.WritersForDr = writers;

                var category = await _categoryService.GetAllAsync();

                List<SelectListItem> categories = (from x in category.Data.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.Id.ToString(),
                                                   }).ToList();
                article.CategoriesForDr = categories;

                return View(article);
            }
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Update(ArticleUpdateViewModel articleUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                var article = new ArticleUpdateDto
                {
                    Id = articleUpdateViewModel.Id,
                    Name = articleUpdateViewModel.Name,
                    Content = articleUpdateViewModel.Content,
                    WriterId = articleUpdateViewModel.WriterId,
                    CategoryId = articleUpdateViewModel.CategoryId,
                };

                if (articleUpdateViewModel.ImageUrl != null)
                {
                    var fileName = articleUpdateViewModel.ImageUrl;
                    var imageFile = _fileHelper.UploadFile(fileName);
                    article.ImageUrl = imageFile;
                }

                var result = await _articleService.UpdateAsync(article);
                if (result.Success)
                {
                    return RedirectToAction("GetArticleDetail", "Articles", new { id = article.Id, Area = "Admins" });
                }
                return View(article);
            }
            return View();
        }


        public async Task<IActionResult> Delete(int id)
        {
            var result = await _articleService.DeleteAsync(id);
            if (result.Success)
            {
                return RedirectToAction("GetAllArticles");
            }
            return View();
        }

    }

}
