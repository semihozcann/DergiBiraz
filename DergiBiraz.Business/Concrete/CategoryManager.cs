using AutoMapper;
using DergiBiraz.Business.Abstract;
using DergiBiraz.Business.Constant;
using DergiBiraz.Core.Utilities.Result.Abstract;
using DergiBiraz.Core.Utilities.Result.Concrete;
using DergiBiraz.DataAccess.Abstract;
using DergiBiraz.Entities.Concrete;
using DergiBiraz.Entities.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        #region Injection

        private readonly ICategoryDal _categoryDal;
        private readonly IMapper _mapper;
        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }

        #endregion

        public async Task<IResult> AddAsync(CategoryAddDto categoryAddDto)
        {
            var category = _mapper.Map<Category>(categoryAddDto);
            await _categoryDal.AddAsync(category);
            await _categoryDal.SaveAsync();
            return new SuccessResult(Messages.CategoryAdded);
        }

        public async Task<IResult> DeleteAsync(int categoryId)
        {
            var category = await _categoryDal.GetAsync(x => x.Id == categoryId);
            if (category != null)
            {
                await _categoryDal.DeleteAsync(category);
                await _categoryDal.SaveAsync();
                return new SuccessResult(Messages.CategoryDeleted);
            }
            else
            {
                return new ErrorResult(Messages.CategoryNotFound);
            }
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public async Task<IDataResult<List<Category>>> GetAllAsync()
        {
            var categories = await _categoryDal.GetAllAsync();
            if (categories != null)
            {
                return new SuccessDataResult<List<Category>>(categories , Messages.CategoryListed);
            }
            else
            {
                return new ErrorDataResult<List<Category>>(null , Messages.CategoryNotFound);
            }
        }

        public async Task<IDataResult<Category>> GetByIdAsync(int categoryId)
        {
            var category = await _categoryDal.GetAsync(x => x.Id == categoryId);
            if (category != null)
            {
                return new SuccessDataResult<Category>(category , Messages.CategoryGeted);
            }
            else
            {
                return new ErrorDataResult<Category>(null , Messages.CategoryNotFound);
            }
        }

        public async Task<IResult> UpdateAsync(CategoryUpdateDto categoryUpdateDto)
        {
            var oldCategory = await _categoryDal.GetAsync(x => x.Id == categoryUpdateDto.Id);
            if (oldCategory != null)
            {
                var category = _mapper.Map<CategoryUpdateDto, Category>(categoryUpdateDto, oldCategory);
                var newCategory = await _categoryDal.UpdateAsync(category);
                await _categoryDal.SaveAsync();
                return new SuccessDataResult<Category>(newCategory , Messages.CategoryUpdated);
            }
            else
            {
                return new ErrorResult(Messages.CategoryNotFound);
            }
            
        }
    }
}
