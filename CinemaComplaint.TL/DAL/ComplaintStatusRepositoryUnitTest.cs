using System;
using System.Linq;
using ComplaintForCinema.DAL.Model;
using ComplaintForCinema.DAL.Repository.Repository;
using DAL.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComplaintForCiname.TL.DAL
{
    [TestClass]
    public class ComplaintStatusRepositoryUnitTest : IGenericRepositoryUnitTest
    {
        private readonly IGenericRepository<ComplaintStatus> complaintStatusRepository = new ComplaintStatusRepository();

        [TestMethod]
        public void A_Insert()
        {
            Assert.AreEqual(complaintStatusRepository.Insert(new ComplaintStatus { ComplaintStatusID = Guid.Parse("08C8238C-6A54-4DBE-BB2A-E5813E6B67CA"), ComplaintStatusDescription = "Active", ComplaintStatusIsActive = true }), 0);
        }

        [TestMethod]
        public void B_GetAll()
        {
            Assert.IsTrue(complaintStatusRepository.GetAll().Any());
        }

        [TestMethod]
        public void C_Update()
        {
            Assert.IsTrue(complaintStatusRepository.Update(new ComplaintStatus { ComplaintStatusID = Guid.Parse("08C8238C-6A54-4DBE-BB2A-E5813E6B67CA"), ComplaintStatusDescription = "Inactive", ComplaintStatusIsActive = false }));
        }

        [TestMethod]
        public void D_Delete()
        {
            Assert.IsTrue(complaintStatusRepository.Delete(new ComplaintStatus { ComplaintStatusID = Guid.Parse("08C8238C-6A54-4DBE-BB2A-E5813E6B67CA") }));
        }
    }
}
