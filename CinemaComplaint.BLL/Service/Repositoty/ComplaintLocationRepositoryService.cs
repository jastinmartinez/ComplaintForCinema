using CinemaComplaint.BLL.Dto;
using CinemaComplaint.BLL.MapperConfig;
using CinemaComplaint.BLL.Service.Interface;
using ComplaintForCinema.DAL.Model;
using ComplaintForCinema.DAL.Repository.Repository;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaComplaint.BLL.Service
{
    public class ComplaintLocationRepositoryService : IGenericRepositoryService<ComplaintLocationDto>
    {
        private readonly IGenericRepository<ComplaintLocation> complaintLocationRepository;
        public ComplaintLocationRepositoryService()
        {
            complaintLocationRepository = new ComplaintLocationRepository();
        }
        public bool Delete(ComplaintLocationDto obj)
        {
            return complaintLocationRepository.Delete(AutoMapperConfiguration.To.Map<ComplaintLocation>(obj));
        }

        public ComplaintLocationDto Get(ComplaintLocationDto obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ComplaintLocationDto> GetAll()
        {
            return AutoMapperConfiguration.To.Map<IEnumerable<ComplaintLocationDto>>(complaintLocationRepository.GetAll());
        }

        public long Insert(ComplaintLocationDto obj)
        {
            return complaintLocationRepository.Insert(AutoMapperConfiguration.To.Map<ComplaintLocation>(obj));
        }

        public bool Update(ComplaintLocationDto obj)
        {
            return complaintLocationRepository.Update(AutoMapperConfiguration.To.Map<ComplaintLocation>(obj));
        }
    }
}
