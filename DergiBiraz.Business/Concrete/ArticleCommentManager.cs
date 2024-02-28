using AutoMapper;
using DergiBiraz.Business.Abstract;
using DergiBiraz.Business.Constant;
using DergiBiraz.Core.Utilities.Result.Abstract;
using DergiBiraz.Core.Utilities.Result.Concrete;
using DergiBiraz.DataAccess.Abstract;
using DergiBiraz.Entities.Concrete;
using DergiBiraz.Entities.DTOs.ArticleComments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Business.Concrete
{
    public class ArticleCommentManager : IArticleCommentService
    {

        #region Injection

        private readonly IArticleCommentDal _articleCommentDal;
        private readonly IMapper _mapper;

        public ArticleCommentManager(IArticleCommentDal articleCommentDal, IMapper mapper)
        {
            _articleCommentDal = articleCommentDal;
            _mapper = mapper;
        }

        #endregion

        public async Task<IResult> AddAsync(ArticleCommentAddDto articleCommentAddDto)
        {
            var comment = _mapper.Map<ArticleComment>(articleCommentAddDto);
            await _articleCommentDal.AddAsync(comment);
            await _articleCommentDal.SaveAsync();
            return new SuccessResult(Messages.CommentAdded);
        }

        public async Task<IResult> DeleteAsync(int articleCommentId)
        {
            var comment = await _articleCommentDal.GetAsync(x => x.Id == articleCommentId);
            if (comment != null)
            {
                await _articleCommentDal.DeleteAsync(comment);
                await _articleCommentDal.SaveAsync();
                return new SuccessResult(Messages.CommentDeleted);
            }
            else
            {
                return new ErrorResult(Messages.CommentNotFound);
            }
        }

        public List<ArticleComment> GetAll()
        {
            return _articleCommentDal.GetAll();
        }

        public async Task<IDataResult<List<ArticleComment>>> GetAllAsync()
        {
            var comments = await _articleCommentDal.GetAllAsync();
            if (comments != null)
            {
                return new SuccessDataResult<List<ArticleComment>>(comments , Messages.CommentListed);
            }
            else
            {
                return new ErrorDataResult<List<ArticleComment>>(null , Messages.CommentNotFound);
            }
        }

        public async Task<IDataResult<ArticleComment>> GetByIdAsync(int articleCommentId)
        {
            var comment = await _articleCommentDal.GetAsync(x => x.Id == articleCommentId);
            if (comment != null)
            {
                return new SuccessDataResult<ArticleComment>(comment , Messages.CommentGeted);
            }
            else
            {
                return new ErrorDataResult<ArticleComment>(null , Messages.CommentNotFound);
            }
        }

        public async Task<IResult> UpdateAsync(ArticleCommentUpdateDto articleCommentUpdateDto)
        {
            var oldComment = await _articleCommentDal.GetAsync(x => x.Id == articleCommentUpdateDto.Id);
            if (oldComment != null)
            {
                var comment = _mapper.Map<ArticleCommentUpdateDto, ArticleComment>(articleCommentUpdateDto, oldComment);
                var newComment = await _articleCommentDal.UpdateAsync(comment);
                await _articleCommentDal.SaveAsync();
                return new SuccessDataResult<ArticleComment>(newComment , Messages.CommentUpdated);
            }
            else
            {
                return new ErrorResult(Messages.CommentNotFound);
            }
        }
    }
}
