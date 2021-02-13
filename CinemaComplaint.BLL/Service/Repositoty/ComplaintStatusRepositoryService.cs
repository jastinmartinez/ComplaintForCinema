using AutoMapper;
using ComplaintForCinema.BLL.Dto;
using ComplaintForCinema.BLL.Exceptions;
using ComplaintForCinema.BLL.MapperConfig;
using ComplaintForCinema.BLL.Service.Interface;
using ComplaintForCinema.BLL.Validation;
using ComplaintForCinema.DAL.Model;
using ComplaintForCinema.DAL.Repository.Repository;
using DAL.Repository;
using System;
using System.Collections.Generic;



namespace ComplaintForCinema.BLL.Service
{
    public class ComplaintStatusRepositoryService : IGenericRepositoryService<ComplaintStatusDto>
    {

        private readonly IGenericRepository<ComplaintStatus> complaintStatusRepo;
        private readonly ComplaintStatusDtoValidator complaintStatusDtoValidator;

        public ComplaintStatusRepositoryService()
        {
            complaintStatusRepo = new ComplaintStatusRepository();
            complaintStatusDtoValidator = new ComplaintStatusDtoValidator();
        }

        public bool Delete(ComplaintStatusDto obj)
        {
            return complaintStatusRepo.Delete(AutoMapperConfiguration.To.Map<ComplaintStatus>(obj));
        }

        public ComplaintStatusDto Get(ComplaintStatusDto obj)
        {
            return AutoMapperConfiguration.To.Map<ComplaintStatusDto>(complaintStatusRepo.Get(AutoMapperConfiguration.To.Map<ComplaintStatus>(obj)));
        }

        public IEnumerable<ComplaintStatusDto> GetAll()
        {
            return AutoMapperConfiguration.To.Map<IEnumerable<ComplaintStatusDto>>(complaintStatusRepo.GetAll());
        }

        public long Insert(ComplaintStatusDto obj)
        {
            var validationResult = complaintStatusDtoValidator.Validate(obj);
            if (validationResult.IsValid)
                return complaintStatusRepo.Insert(AutoMapperConfiguration.To.Map<ComplaintStatus>(obj));
            else
                throw new UserValidationException(validationResult.Errors);
        }

        public bool Update(ComplaintStatusDto obj)
        {
            var validationResult = complaintStatusDtoValidator.Validate(obj);
            if (validationResult.IsValid)
                return complaintStatusRepo.Update(AutoMapperConfiguration.To.Map<ComplaintStatus>(obj));
            else
                throw new UserValidationException(validationResult.Errors);
        }
    }
}
