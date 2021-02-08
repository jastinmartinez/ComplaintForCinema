using AutoMapper;
using CinemaComplaint.BLL.Dto;
using ComplaintForCinema.DAL.Model;

namespace CinemaComplaint.BLL.MapperConfig
{
    public class AutoMapperConfiguration
    {

        public static Mapper Mapper
        {
            get
            {
                var mapperConfiguration = new MapperConfiguration(cfg =>
                cfg.CreateMap<ComplaintStatus, ComplaintStatusDto>()
                .ForMember(s => s.ID, t => t.MapFrom(d => d.ComplaintStatusID))
                .ForMember(s => s.Description, t => t.MapFrom(d => d.ComplaintStatusDescription))
                .ForMember(s => s.Status, t => t.MapFrom(d => d.ComplaintStatusIsActive)).ReverseMap()
                );
                return new Mapper(mapperConfiguration);
            }
        }

    }
}
