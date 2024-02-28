using AutoMapper;
using DergiBiraz.Business.Abstract;
using DergiBiraz.Business.Constant;
using DergiBiraz.Core.Utilities.Result.Abstract;
using DergiBiraz.Core.Utilities.Result.Concrete;
using DergiBiraz.DataAccess.Abstract;
using DergiBiraz.Entities.Concrete;
using DergiBiraz.Entities.DTOs.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Business.Concrete
{
    public class ArticleManager : IArticleService
    {

        #region Injection

        private readonly IArticleDal _articleDal;
        private readonly IMapper _mapper;
        public ArticleManager(IArticleDal articleDal, IMapper mapper)
        {
            _articleDal = articleDal;
            _mapper = mapper;
        }


        #endregion


        public async Task<IResult> AddAsync(ArticleAddDto articleAddDto)
        {
            var article = _mapper.Map<Article>(articleAddDto);
            await _articleDal.AddAsync(article);
            await _articleDal.SaveAsync();
            return new SuccessResult(Messages.ArticleAdded);
        }

        public async Task<IResult> DeleteAsync(int articleId)
        {
            var article = await _articleDal.GetAsync(x => x.Id == articleId);
            if (article != null)
            {
                await _articleDal.DeleteAsync(article);
                await _articleDal.SaveAsync();
                return new SuccessResult(Messages.ArticleDeleted);
            }
            else
            {
                return new ErrorResult(Messages.ArticleNotFound);
            }
        }

        public List<Article> GetAll()
        {
            return _articleDal.GetAll();
        }

        public async Task<IDataResult<List<Article>>> GetAllAsync()
        {
            var articles = await _articleDal.GetAllAsync();
            if (articles != null)
            {
                return new SuccessDataResult<List<Article>>(articles , Messages.ArticleListed);
            }
            else
            {
                return new ErrorDataResult<List<Article>>(null , Messages.ArticleNotFound);
            }
        }

        public async Task<IDataResult<Article>> GetByIdAsync(int articleId)
        {
            var article = await _articleDal.GetAsync(x => x.Id == articleId);
            if (article != null)
            {
                return new SuccessDataResult<Article>(article , Messages.ArticleGeted);
            }
            else
            {
                return new ErrorDataResult<Article>(null , Messages.ArticleNotFound);
            }
        }

        public async Task<IResult> UpdateAsync(ArticleUpdateDto articleUpdateDto)
        {
            var oldArticle = await _articleDal.GetAsync(x => x.Id == articleUpdateDto.Id);
            if (oldArticle != null)
            {
                var article = _mapper.Map<ArticleUpdateDto, Article>(articleUpdateDto , oldArticle);
                var newArticle = await _articleDal.UpdateAsync(article);
                await _articleDal.SaveAsync();
                return new SuccessDataResult<Article>(newArticle , Messages.ArticleUpdated);
            }
            else
            {
                return new ErrorResult(Messages.ArticleNotFound);
            }
        }
    }
}
