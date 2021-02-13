using ComplaintForCinema.BLL.Dto;
using ComplaintForCinema.BLL.Exceptions;
using ComplaintForCinema.BLL.MapperConfig;
using ComplaintForCinema.BLL.Service.Interface;
using ComplaintForCinema.BLL.Validation;
using ComplaintForCinema.BLL.Validation.Interface;
using ComplaintForCinema.DAL.Model;
using ComplaintForCinema.DAL.Repository.Repository;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintForCinema.BLL.Service
{
    public class ComplaintLocationRepositoryService : IGenericRepositoryService<ComplaintLocationDto>
    {
        private readonly IGenericRepository<ComplaintLocation> complaintLocationRepository;
        private readonly ComplaintLocationDtoValidator complaintLocationDtoValidator;
        public ComplaintLocationRepositoryService()
        {
            complaintLocationRepository = new ComplaintLocationRepository();
            complaintLocationDtoValidator = new ComplaintLocationDtoValidator();
        }
        public bool Delete(ComplaintLocationDto obj)
        {
            return complaintLocationRepository.Delete(AutoMapperConfiguration.To.Map<ComplaintLocation>(obj));
        }

        public ComplaintLocationDto Get(ComplaintLocationDto obj)
        {
            return AutoMapperConfiguration.To.Map<ComplaintLocationDto>(complaintLocationRepository.Get(AutoMapperConfiguration.To.Map<ComplaintLocation>(obj)));
        }

        public IEnumerable<ComplaintLocationDto> GetAll()
        {
            return AutoMapperConfiguration.To.Map<IEnumerable<ComplaintLocationDto>>(complaintLocationRepository.GetAll());
        }

        public long Insert(ComplaintLocationDto obj)
        {
            var validationResult = complaintLocationDtoValidator.Validate(obj);

            if (validationResult.IsValid)
                return complaintLocationRepository.Insert(AutoMapperConfiguration.To.Map<ComplaintLocation>(obj));
            else
                throw new UserValidationException(validationResult.Errors);
        }

        public bool Update(ComplaintLocationDto obj)
        {
            var validationResult = complaintLocationDtoValidator.Validate(obj);

            if (validationResult.IsValid)
                return complaintLocationRepository.Update(AutoMapperConfiguration.To.Map<ComplaintLocation>(obj));
            else
                throw new UserValidationException(validationResult.Errors);

        }
    }
}
