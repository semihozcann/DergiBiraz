using DergiBiraz.Business.Abstract;
using DergiBiraz.WebMVC.Helpers.Abstract;
using DergiBiraz.WebMVC.Models;
using DergiBiraz.WebMVC.Models.Articles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DergiBiraz.WebMVC.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleService _articleService;
        private readonly IWriterService _writerService;
        private readonly IArticleCommentService _articleCommentService;

        public HomeController(IUserAccessor userAccessor, ILogger<HomeController> logger, IArticleService articleService, IWriterService writerService, IArticleCommentService articleCommentService = null) : base(userAccessor)
        {
            _logger = logger;
            _articleService = articleService;
            _writerService = writerService;
            _articleCommentService = articleCommentService;
        }

        public async Task<IActionResult> Index(ArticleListViewModel articleListViewModel)
        {
            var articleComment = await _articleCommentService.GetAllAsync();
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


        public IActionResult Contact()
        {
            return View();
        }


    }
}
