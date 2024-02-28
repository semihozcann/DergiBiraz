using AutoMapper;
using DergiBiraz.Entities.Concrete;
using DergiBiraz.Entities.DTOs.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.DataAccess.AutoMapper
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleAddDto,Article>();
            CreateMap<ArticleUpdateDto,Article>();
            CreateMap<Article, ArticleUpdateDto>();
        }
    }
}
