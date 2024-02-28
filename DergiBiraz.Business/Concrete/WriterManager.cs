using AutoMapper;
using DergiBiraz.Business.Abstract;
using DergiBiraz.Business.Constant;
using DergiBiraz.Core.Utilities.Result.Abstract;
using DergiBiraz.Core.Utilities.Result.Concrete;
using DergiBiraz.DataAccess.Abstract;
using DergiBiraz.Entities.Concrete;
using DergiBiraz.Entities.DTOs.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Business.Concrete
{
    public class WriterManager : IWriterService
    {

        #region Injection

        private readonly IWriterDal _writerDal;
        private readonly IMapper _mapper;

        public WriterManager(IWriterDal writerDal, IMapper mapper)
        {
            _writerDal = writerDal;
            _mapper = mapper;
        }

        #endregion


        public async Task<IResult> AddAsync(WriterAddDto writerAddDto)
        {
            var writer = _mapper.Map<Writer>(writerAddDto);
            await _writerDal.AddAsync(writer);
            await _writerDal.SaveAsync();
            return new SuccessResult(Messages.WriterAdded);
        }

        public async Task<IResult> DeleteAsync(int writerId)
        {
            var writer = await _writerDal.GetAsync(x => x.Id == writerId);
            if (writer != null)
            {
                await _writerDal.DeleteAsync(writer);
                await _writerDal.SaveAsync();
                return new SuccessResult(Messages.WriterDeleted);
            }
            else
            {
                return new ErrorResult(Messages.WriterNotFound);
            }
        }

        public List<Writer> GetAll()
        {
            return _writerDal.GetAll();
        }

        public async Task<IDataResult<List<Writer>>> GetAllAsync()
        {
            var writers = await _writerDal.GetAllAsync();
            if (writers != null)
            {
                return new SuccessDataResult<List<Writer>>(writers , Messages.WriterListed);
            }
            else
            {
                return new ErrorDataResult<List<Writer>>(null , Messages.WriterNotFound);
            }
        }

        public async Task<IDataResult<Writer>> GetByIdAsync(int writerId)
        {
            var writer = await _writerDal.GetAsync(x => x.Id == writerId);
            if (writer != null)
            {
                return new SuccessDataResult<Writer>(writer , Messages.WriterGeted);
            }
            else
            {
                return new ErrorDataResult<Writer>(null , Messages.WriterNotFound);
            }
        }

        public async Task<IResult> UpdateAsync(WriterUpdateDto writerUpdateDto)
        {
            var oldWriter = await _writerDal.GetAsync(x => x.Id == writerUpdateDto.Id);
            if (oldWriter != null)
            {
                var writer = _mapper.Map<WriterUpdateDto, Writer>(writerUpdateDto , oldWriter);
                var newWriter = await _writerDal.UpdateAsync(writer);
                await _writerDal.SaveAsync();
                return new SuccessDataResult<Writer>(newWriter , Messages.WriterUpdated);
            }
            else
            {
                return new ErrorResult(Messages.WriterNotFound);
            }
        }
    }
}
