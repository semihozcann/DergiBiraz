using DergiBiraz.Core.Utilities.Result.Abstract;
using DergiBiraz.Entities.Concrete;
using DergiBiraz.Entities.DTOs.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Business.Abstract
{
    public interface IWriterService
    {
        Task<IDataResult<Writer>> GetByIdAsync(int writerId);
        Task<IDataResult<List<Writer>>> GetAllAsync();
        Task<IResult> AddAsync(WriterAddDto writerAddDto);
        Task<IResult> UpdateAsync(WriterUpdateDto writerUpdateDto);
        Task<IResult> DeleteAsync(int writerId);

        List<Writer> GetAll();
    }
}
