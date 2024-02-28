using DergiBiraz.Business.Abstract;
using DergiBiraz.Entities.DTOs.ArticleComments;
using DergiBiraz.WebMVC.Helpers.Abstract;
using DergiBiraz.WebMVC.Models.ArticleComments;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DergiBiraz.WebMVC.Areas.Admins.Controllers
{
    public class ArticleCommentsController : BaseController
    {

        private readonly IArticleCommentService _articleCommentService;
        private readonly IArticleService _articleService;


        public ArticleCommentsController(IUserAccessor userAccessor, IArticleCommentService articleCommentService, IArticleService articleService) : base(userAccessor)
        {
            _articleCommentService = articleCommentService;
            _articleService = articleService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllArticleComments(ArticleCommentListViewModel articleCommentListViewModel)
        {
            var article = _articleService.GetAll();
            var user = _articleService.GetAll();
            var result = await _articleCommentService.GetAllAsync();

            if (result.Success)
            {
                var articleComment = new ArticleCommentListViewModel
                {
                    ArticleComments = result.Data,
                    Message = result.Message
                };

                return View(articleComment);
            }
            return View();
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ArticleCommentAddViewModel articleCommentAddViewModel)
        {

            if (ModelState.IsValid)
            {
                var articleComment = new ArticleCommentAddDto
                {
                    ArticleId = articleCommentAddViewModel.ArticleId,
                    Content = articleCommentAddViewModel.Content,
                    UserId = articleCommentAddViewModel.UserId,
                };

                var result = await _articleCommentService.AddAsync(articleComment);
                if (result.Success)
                {
                    return RedirectToAction("GetAllArticleComments");
                }
                return View();
            }
            return View();

        }


    }
}
