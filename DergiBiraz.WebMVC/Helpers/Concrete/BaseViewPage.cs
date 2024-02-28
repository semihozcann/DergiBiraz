using DergiBiraz.Entities.Concrete;
using DergiBiraz.WebMVC.Helpers.Abstract;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Razor;

namespace DergiBiraz.WebMVC.Helpers.Concrete
{
    public abstract class BaseViewPage<TModel> : RazorPage<TModel>
    {
        [RazorInject]
        public IUserAccessor _userAccessor { get; set; }

        public User CurrentUser
        {
            get
            {
                if (User != null)
                {
                    return _userAccessor.GetUser();
                }
                else
                {
                    return null;
                }
            }
        }

    }
}
