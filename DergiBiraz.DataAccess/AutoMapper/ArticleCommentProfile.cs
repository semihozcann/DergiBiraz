using AutoMapper;
using DergiBiraz.Entities.Concrete;
using DergiBiraz.Entities.DTOs.ArticleComments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.DataAccess.AutoMapper
{
    public class ArticleCommentProfile : Profile
    {
        public ArticleCommentProfile()
        {
            CreateMap<ArticleCommentAddDto,ArticleComment>();
            CreateMap<ArticleCommentUpdateDto,ArticleComment>();
            CreateMap<ArticleComment, ArticleCommentUpdateDto>();
        }
    }
}
