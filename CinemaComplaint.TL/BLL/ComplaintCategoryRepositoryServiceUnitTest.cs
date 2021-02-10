using CinemaComplaint.BLL.Dto;
using CinemaComplaint.BLL.MapperConfig;
using CinemaComplaint.BLL.Service;
using CinemaComplaint.BLL.Service.Interface;
using ComplaintForCiname.TL.DAL;
using ComplaintForCiname.TL.DAL.Interface;
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
    public class ComplaintCategoryRepositoryServiceUnitTest : IGenericRepositoryUnitTest
    {
        private readonly IGenericRepositoryService<ComplaintCategoryDto> complaintStatusDtoService = new ComplaintCategoryRepositoryService();

        [TestMethod]
        public void A_Insert()
        {

            Assert.AreEqual(complaintStatusDtoService.Insert(new ComplaintCategoryDto { ID = Guid.NewGuid(), Description = "Active", Status = true }), 0);
        }

        [TestMethod]
        public void B_GetAll()
        {
            Assert.IsTrue(complaintStatusDtoService.GetAll().Any());
            ;
        }

        [TestMethod]
        public void C_Update()
        {
            Assert.IsTrue(complaintStatusDtoService.Update(new ComplaintCategoryDto { ID = Guid.Parse("08C8238C-6A54-4DBE-BB2A-E5813E6B67CA"), Description = "Update", Status = false }));
        }

        [TestMethod]
        public void D_Delete()
        {
            Assert.IsTrue(complaintStatusDtoService.Delete(new ComplaintCategoryDto { ID = Guid.Parse("08C8238C-6A54-4DBE-BB2A-E5813E6B67CA") }));
        }
    }
}
