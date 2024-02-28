using DergiBiraz.Core.Utilities.Result.Abstract;
using DergiBiraz.Entities.Concrete;
using DergiBiraz.Entities.DTOs.ArticleComments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Business.Abstract
{
    public interface IArticleCommentService
    {
        Task<IDataResult<ArticleComment>> GetByIdAsync(int articleCommentId);
        Task<IDataResult<List<ArticleComment>>> GetAllAsync();
        Task<IResult> AddAsync(ArticleCommentAddDto articleCommentAddDto);
        Task<IResult> UpdateAsync(ArticleCommentUpdateDto articleCommentUpdateDto);
        Task<IResult> DeleteAsync(int articleCommentId);

        List<ArticleComment> GetAll();
    }
}
