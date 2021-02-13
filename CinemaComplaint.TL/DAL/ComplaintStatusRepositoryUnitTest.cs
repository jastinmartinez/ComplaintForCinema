using System;
using System.Linq;
using ComplaintForCinema.TL.BLL.Interface;
using ComplaintForCinema.DAL.Model;
using ComplaintForCinema.DAL.Repository.Repository;
using DAL.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComplaintForCinema.TL.DAL
{
    [TestClass]
    public class ComplaintStatusRepositoryUnitTest : IGenericRepositoryUnitTest
    {
        private readonly IGenericRepository<ComplaintStatus> complaintStatusRepository = new ComplaintStatusRepository();

        [TestMethod]
        public void A_Insert()
        {
            Assert.AreEqual(complaintStatusRepository.Insert(new ComplaintStatus { ComplaintStatusDescription = "Active", ComplaintStatusIsActive = true }), 0);
        }

        [TestMethod]
        public void B_GetAll()
        {
            Assert.IsTrue(complaintStatusRepository.GetAll().Any());
        }

        [TestMethod]
        public void C_Update()
        {
            Assert.IsTrue(complaintStatusRepository.Update(new ComplaintStatus { ComplaintStatusID = complaintStatusRepository.GetAll().OrderByDescending(x => x.ComplaintStatusID).FirstOrDefault().ComplaintStatusID, ComplaintStatusDescription = "Inactive", ComplaintStatusIsActive = false }));
        }

        [TestMethod]
        public void D_Delete()
        {
            Assert.IsTrue(complaintStatusRepository.Delete(new ComplaintStatus { ComplaintStatusID = complaintStatusRepository.GetAll().OrderByDescending(x => x.ComplaintStatusID).FirstOrDefault().ComplaintStatusID }));
        }
    }
}
