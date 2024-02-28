using DergiBiraz.Core.DataAccess.Concrete;
using DergiBiraz.DataAccess.Abstract;
using DergiBiraz.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfArticleDal : BaseEntityRepository<Article>, IArticleDal
    {
        public EfArticleDal(DbContext context) : base(context)
        {
        }
    }
}
