using DergiBiraz.Business.Abstract;
using DergiBiraz.WebMVC.Helpers.Abstract;
using DergiBiraz.WebMVC.Models.Articles;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace DergiBiraz.WebMVC.Controllers
{
    public class ArticlesController : BaseController
    {
        private readonly IArticleService _articleService;
        private readonly IWriterService _writerService;
        private readonly IArticleCommentService _articleCommentService;
        private readonly ICategoryService _categoryService;

        public ArticlesController(IUserAccessor userAccessor, IArticleService articleService, IWriterService writerService, IArticleCommentService articleCommentService, ICategoryService categoryService) : base(userAccessor)
        {
            _articleService = articleService;
            _writerService = writerService;
            _articleCommentService = articleCommentService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> GetAllArticleByCategoryId(ArticleListViewModel articleListViewModel)
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



                int pageSize = 4;
                var totalRecords = articles.Articles.Count;
                var totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                int currentPage = articleListViewModel.Page;
                if (currentPage < 1)
                {
                    currentPage = 1;
                }
                else if (currentPage > totalPages)
                {
                    currentPage = totalPages;
                }

                // İlgili sayfadaki verileri alın
                var dataForPage = articles.Articles.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

                // ArticleListViewModel'i kullanarak verileri model olarak iletebilirsiniz
                var viewModel = new ArticleListViewModel
                {
                    Articles = dataForPage,
                    Message = result.Message,
                    Page = currentPage,
                    TotalPage = totalPages,
                };

                return View(viewModel);
            }
            return View();
        }


        public async Task<IActionResult> GetArticleById(int Id) 
        {
            var category = await _categoryService.GetAllAsync();
            var writer = await _writerService.GetAllAsync();
            var comments = await _articleCommentService.GetAllAsync();
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

    }
}
