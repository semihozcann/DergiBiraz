using DergiBiraz.Core.Utilities.IoC;
using DergiBiraz.DataAccess.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Business.DependencyResolvers
{
    public class AutoMapperModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(
                typeof(ArticleProfile),
                typeof(CategoryProfile),
                typeof(ArticleCommentProfile),
                typeof(WriterProfile)


                );
        }
    }
}
