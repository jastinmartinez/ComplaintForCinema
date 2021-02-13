using ComplaintForCinema.BLL.Dto;
using ComplaintForCinema.BLL.Exceptions;
using ComplaintForCinema.BLL.MapperConfig;
using ComplaintForCinema.BLL.Service.Interface;
using ComplaintForCinema.BLL.Validation;
using ComplaintForCinema.DAL.Model;
using ComplaintForCinema.DAL.Repository;
using ComplaintForCinema.DAL.Repository.Repository;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintForCinema.BLL.Service
{
    public class ComplaintCategoryRepositoryService : IGenericRepositoryService<ComplaintCategoryDto>
    {
        private readonly IGenericRepository<ComplaintCategory> complaintCategoryRepository;
        private readonly ComplaintCategoryDtoValidator complaintCategoryDtoValidator;
        public ComplaintCategoryRepositoryService()
        {
            complaintCategoryRepository = new ComplaintCategoryRepository();
            complaintCategoryDtoValidator = new ComplaintCategoryDtoValidator();
        }

        public bool Delete(ComplaintCategoryDto obj)
        {
            return complaintCategoryRepository.Delete(AutoMapperConfiguration.To.Map<ComplaintCategory>(obj));
        }

        public ComplaintCategoryDto Get(ComplaintCategoryDto obj)
        {
            return AutoMapperConfiguration.To.Map<ComplaintCategoryDto>(complaintCategoryRepository.Get(AutoMapperConfiguration.To.Map<ComplaintCategory>(obj)));
        }

        public IEnumerable<ComplaintCategoryDto> GetAll()
        {
            return AutoMapperConfiguration.To.Map<IEnumerable<ComplaintCategoryDto>>(complaintCategoryRepository.GetAll());
        }

        public long Insert(ComplaintCategoryDto obj)
        {
            if (complaintCategoryDtoValidator.ValidationResult(obj).IsValid)
                return complaintCategoryRepository.Insert(AutoMapperConfiguration.To.Map<ComplaintCategory>(obj));
            else
                throw new UserValidationException(complaintCategoryDtoValidator.ValidationResult(obj).Errors);
        }

        public bool Update(ComplaintCategoryDto obj)
        {
            if (complaintCategoryDtoValidator.ValidationResult(obj).IsValid)
                return complaintCategoryRepository.Update(AutoMapperConfiguration.To.Map<ComplaintCategory>(obj));
            else
                throw new UserValidationException(complaintCategoryDtoValidator.ValidationResult(obj).Errors);
        }
    }
}
