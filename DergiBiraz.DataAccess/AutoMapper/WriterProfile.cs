using AutoMapper;
using DergiBiraz.Entities.Concrete;
using DergiBiraz.Entities.DTOs.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.DataAccess.AutoMapper
{
    public class WriterProfile : Profile
    {
        public WriterProfile()
        {
            CreateMap<WriterAddDto,Writer>();
            CreateMap<WriterUpdateDto,Writer>();
            CreateMap<Writer, WriterUpdateDto>();
        }
    }
}
