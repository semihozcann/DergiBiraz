using DergiBiraz.Core.Utilities.Result.Abstract;
using DergiBiraz.Entities.Concrete;
using DergiBiraz.Entities.DTOs.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Business.Abstract
{
    public interface IArticleService
    {
        Task<IDataResult<List<Article>>> GetAllAsync();
        Task<IDataResult<Article>> GetByIdAsync(int articleId);

        Task<IResult> AddAsync(ArticleAddDto articleAddDto);
        Task<IResult> UpdateAsync(ArticleUpdateDto articleUpdateDto);
        Task<IResult> DeleteAsync(int articleId);

        List<Article> GetAll();
    }
}
