using DergiBiraz.Core.Utilities.Result.Abstract;
using DergiBiraz.Entities.Concrete;
using DergiBiraz.Entities.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Business.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<Category>> GetByIdAsync(int categoryId);
        Task<IDataResult<List<Category>>> GetAllAsync();
        Task<IResult> AddAsync(CategoryAddDto categoryAddDto);
        Task<IResult> UpdateAsync(CategoryUpdateDto categoryUpdateDto);
        Task<IResult> DeleteAsync(int categoryId);

        List<Category> GetAll();
    }
}
