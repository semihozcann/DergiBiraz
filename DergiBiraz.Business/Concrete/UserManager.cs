using DergiBiraz.Business.Abstract;
using DergiBiraz.Business.Constant;
using DergiBiraz.Core.Utilities.Result.Abstract;
using DergiBiraz.Core.Utilities.Result.Concrete;
using DergiBiraz.DataAccess.Abstract;
using DergiBiraz.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Business.Concrete
{
    public class UserManager : IUserService
    {

        #region Injection

        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        #endregion

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public async Task<IDataResult<List<User>>> GetAllAsync()
        {
            var users = await _userDal.GetAllAsync();
            if (users != null)
            {
                return new SuccessDataResult<List<User>>(users , Messages.UserListed);
            }
            else
            {
                return new ErrorDataResult<List<User>>(null , Messages.UserNotFound);
            }
        }

        public async Task<IDataResult<User>> GetByIdAsync(int userId)
        {
            var user = await _userDal.GetAsync(x => x.Id == userId);
            if (user != null)
            {
                return new SuccessDataResult<User>(user , Messages.UserGeted);
            }
            else
            {
                return new ErrorDataResult<User>(null , Messages.UserNotFound);
            }
        }
    }
}
