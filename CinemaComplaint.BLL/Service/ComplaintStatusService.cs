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
    public class ComplaintStatusService : IGenericService<ComplaintStatusDto>
    {

        private readonly IGenericRepository<ComplaintStatus> complaintStatusRepo;
     
        public ComplaintStatusService()
        {
            complaintStatusRepo = new ComplaintStatusRepository();
        }

        public bool Delete(ComplaintStatusDto obj)
        {
            return complaintStatusRepo.Delete(AutoMapperConfiguration.Mapper.Map<ComplaintStatus>(obj));
        }

        public IEnumerable<ComplaintStatusDto> GetAll()
        {
            return AutoMapperConfiguration.Mapper.Map<IEnumerable<ComplaintStatusDto>>(complaintStatusRepo.GetAll());
        }

        public long Insert(ComplaintStatusDto obj)
        {
            return complaintStatusRepo.Insert(AutoMapperConfiguration.Mapper.Map<ComplaintStatus>(obj));
        }

        public bool Update(ComplaintStatusDto obj)
        {
            return complaintStatusRepo.Update(AutoMapperConfiguration.Mapper.Map<ComplaintStatus>(obj));
        }
    }
}
