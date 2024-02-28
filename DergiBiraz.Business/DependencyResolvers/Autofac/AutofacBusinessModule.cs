using Autofac;
using DergiBiraz.Business.Abstract;
using DergiBiraz.Business.Concrete;
using DergiBiraz.DataAccess.Abstract;
using DergiBiraz.DataAccess.Concrete.EntityFramework;
using DergiBiraz.DataAccess.Concrete.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<DergiBirazContex>().As<DbContext>().SingleInstance();

            builder.RegisterType<EfArticleDal>().As<IArticleDal>();
            builder.RegisterType<ArticleManager>().As<IArticleService>();

            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();

            builder.RegisterType<EfArticleCommentDal>().As<IArticleCommentDal>();
            builder.RegisterType<ArticleCommentManager>().As<IArticleCommentService>();

            builder.RegisterType<EfWriterDal>().As<IWriterDal>();
            builder.RegisterType<WriterManager>().As<IWriterService>();

            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<UserManager>().As<IUserService>();



        }
    }
}
