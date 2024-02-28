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
    public class EfWriterDal : BaseEntityRepository<Writer>, IWriterDal
    {
        public EfWriterDal(DbContext context) : base(context)
        {
        }
    }
}
