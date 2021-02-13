using AutoMapper;
using ComplaintForCinema.BLL.Dto;
using ComplaintForCinema.DAL.Model;

namespace ComplaintForCinema.BLL.MapperConfig
{
    public class AutoMapperConfiguration
    {
        private static MapperConfiguration _mapperConfiguration;
        private static Mapper _Mapper;
        public static Mapper To
        {
            get
            {
                if (_mapperConfiguration is null)
                {
                    _mapperConfiguration = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<ComplaintStatus, ComplaintStatusDto>()
                        .ForMember(s => s.ID, t => t.MapFrom(d => d.ComplaintStatusID))
                        .ForMember(s => s.Description, t => t.MapFrom(d => d.ComplaintStatusDescription))
                        .ForMember(s => s.Status, t => t.MapFrom(d => d.ComplaintStatusIsActive))
                        .ReverseMap();

                        cfg.CreateMap<ComplaintCategory, ComplaintCategoryDto>()
                        .ForMember(s => s.ID, t => t.MapFrom(d => d.ComplaintCategoryID))
                        .ForMember(s => s.Description, t => t.MapFrom(d => d.ComplaintCategoryDescription))
                        .ForMember(s => s.Status, t => t.MapFrom(d => d.ComplaintCategoryIsActive))
                        .ReverseMap();

                        cfg.CreateMap<ComplaintLocation, ComplaintLocationDto>()
                        .ForMember(s => s.ID, t => t.MapFrom(d => d.ComplaintLocationID))
                        .ForMember(s => s.Description, t => t.MapFrom(d => d.ComplaintLocationDescription))
                        .ForMember(s => s.Status, t => t.MapFrom(d => d.ComplaintLocationIsActive))
                        .ReverseMap();
                    }
                   );

                    _Mapper = new Mapper(_mapperConfiguration);
                }
                return _Mapper;
            }
        }

    }
}
