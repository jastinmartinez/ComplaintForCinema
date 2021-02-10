using AutoMapper;
using CinemaComplaint.BLL.Dto;
using CinemaComplaint.BLL.MapperConfig;
using CinemaComplaint.BLL.Service.Interface;
using ComplaintForCinema.DAL.Model;
using ComplaintForCinema.DAL.Repository.Repository;
using DAL.Repository;
using System;
using System.Collections.Generic;



namespace CinemaComplaint.BLL.Service
{
    public class ComplaintStatusRepositoryService : IGenericRepositoryService<ComplaintStatusDto>
    {

        private readonly IGenericRepository<ComplaintStatus> complaintStatusRepo;
     
        public ComplaintStatusRepositoryService()
        {
            complaintStatusRepo = new ComplaintStatusRepository();
        }

        public bool Delete(ComplaintStatusDto obj)
        {
            return complaintStatusRepo.Delete(AutoMapperConfiguration.To.Map<ComplaintStatus>(obj));
        }

        public ComplaintStatusDto Get(ComplaintStatusDto obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ComplaintStatusDto> GetAll()
        {
            return AutoMapperConfiguration.To.Map<IEnumerable<ComplaintStatusDto>>(complaintStatusRepo.GetAll());
        }

        public long Insert(ComplaintStatusDto obj)
        {
            return complaintStatusRepo.Insert(AutoMapperConfiguration.To.Map<ComplaintStatus>(obj));
        }

        public bool Update(ComplaintStatusDto obj)
        {
            return complaintStatusRepo.Update(AutoMapperConfiguration.To.Map<ComplaintStatus>(obj));
        }
    }
}
