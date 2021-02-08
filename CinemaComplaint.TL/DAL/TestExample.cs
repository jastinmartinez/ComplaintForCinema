using CinemaComplaint.BLL.Dto;
using CinemaComplaint.BLL.MapperConfig;
using CinemaComplaint.BLL.Service;
using CinemaComplaint.BLL.Service.Interface;
using ComplaintForCiname.TL.DAL;
using ComplaintForCinema.DAL.Repository.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaComplaint.TL.DAL
{
    [TestClass]
    public class TestExample : IGenericRepositoryUnitTest
    {
        [TestMethod]
        public void A_Insert()
        {
            IGenericService<ComplaintStatusDto> complaintStatusDtoService = new ComplaintStatusService();
            Assert.AreEqual(complaintStatusDtoService.Insert(new ComplaintStatusDto { ID = Guid.Parse("08C8238C-6A54-4DBE-BB2A-E5813E6B67CA"), Description = "Active", Status = true }), 0);
        }

        public void B_GetAll()
        {
            throw new NotImplementedException();
        }

        public void C_Update()
        {
            throw new NotImplementedException();
        }

        public void D_Delete()
        {
            throw new NotImplementedException();
        }
    }
}
