using DergiBiraz.Business.Abstract;
using DergiBiraz.Entities.Concrete;
using DergiBiraz.Entities.DTOs.Writers;
using DergiBiraz.WebMVC.Helpers.Abstract;
using DergiBiraz.WebMVC.Models.Writers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DergiBiraz.WebMVC.Areas.Admins.Controllers
{
    public class WritersController : BaseController
    {
        public WritersController(IUserAccessor userAccessor, IWriterService writerService, IFileHelper fileHelper) : base(userAccessor)
        {
            _writerService = writerService;
            _fileHelper = fileHelper;
        }

        private readonly IWriterService _writerService;
        private readonly IFileHelper _fileHelper;


        public async Task<IActionResult> GetAllWriters()
        {
            var result = await _writerService.GetAllAsync();

            var writers = new WriterListViewModel
            {
                Writers = result.Data,
                Message = result.Message,
            };

            if (result.Success)
            {
                return View(writers);
            }
            return View();
        }



        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Add(WriterAddViewModel writerAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var writer = new WriterAddDto
                {
                    FirstName = writerAddViewModel.FirstName,
                    LastName = writerAddViewModel.LastName,
                    Description = writerAddViewModel.Description,
                    FacebookUrl = writerAddViewModel.FacebookUrl,
                    LinkedInUrl = writerAddViewModel.LinkedInUrl,
                    InstagramUrl = writerAddViewModel.InstagramUrl,
                    TwitterUrl = writerAddViewModel.TwitterUrl,
                    Job = writerAddViewModel.Job
                };

                var result = await _writerService.AddAsync(writer);
                if (result.Success)
                {
                    return RedirectToAction("GetAllWriters");
                }
                return View();
            }
            return View();
        }

        public async Task<IActionResult> Update(int Id)
        {
            var result = await _writerService.GetByIdAsync(Id);

            var writer = new WriterUpdateViewModel
            {
                Id = result.Data.Id,
                FirstName = result.Data.FirstName,
                LastName = result.Data.LastName,
                Description = result.Data.Description,
                FacebookUrl = result.Data.FacebookUrl,
                InstagramUrl = result.Data.InstagramUrl,
                TwitterUrl = result.Data.TwitterUrl,
                LinkedInUrl = result.Data.LinkedInUrl,
                Job = result.Data.Job
            };
            return View(writer);
         }

        [HttpPost]
        public async Task<IActionResult> Update(WriterUpdateViewModel writerUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                var writer = new WriterUpdateDto
                {
                    Id = writerUpdateViewModel.Id,
                    FirstName = writerUpdateViewModel.FirstName,
                    LastName = writerUpdateViewModel.LastName,
                    Description = writerUpdateViewModel.Description,
                    FacebookUrl = writerUpdateViewModel.FacebookUrl,
                    InstagramUrl = writerUpdateViewModel.InstagramUrl,
                    TwitterUrl = writerUpdateViewModel.TwitterUrl,
                    LinkedInUrl = writerUpdateViewModel.LinkedInUrl,
                    Job = writerUpdateViewModel.Job
                };

                var result = await _writerService.UpdateAsync(writer);

                if (result.Success)
                {
                    return RedirectToAction("GetAllWriters");
                }
                return View(writer);
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _writerService.DeleteAsync(id);
            if (result.Success)
            {
                return RedirectToAction("GetAllWriters");
            }
            return View(result);
        }
    }
}
