using AutoMapper;
using DergiBiraz.Entities.Concrete;
using DergiBiraz.Entities.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.DataAccess.AutoMapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryAddDto,Category>();
            CreateMap<CategoryUpdateDto,Category>();
            CreateMap<Category, CategoryUpdateDto>();
        }
    }
}
