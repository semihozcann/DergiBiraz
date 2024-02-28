using DergiBiraz.Core.Utilities.Result.Abstract;
using DergiBiraz.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Business.Abstract
{
    public interface IUserService
    {
        Task<IDataResult<List<User>>> GetAllAsync();
        Task<IDataResult<User>> GetByIdAsync(int userId);

        List<User> GetAll();
    }
}
