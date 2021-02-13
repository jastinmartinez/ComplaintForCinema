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
    public class ComplaintLocationRepositoryUnitTest : IGenericRepositoryUnitTest
    {
        private readonly IGenericRepository<ComplaintLocation> complaintLocationRepository = new ComplaintLocationRepository();

        [TestMethod]
        public void A_Insert()
        {
            Assert.AreEqual(complaintLocationRepository.Insert(new ComplaintLocation { ComplaintLocationDescription = "Example", ComplaintLocationIsActive = true }), 0);
        }

        [TestMethod]
        public void B_GetAll()
        {
            Assert.IsTrue(complaintLocationRepository.GetAll().Any());
        }

        [TestMethod]
        public void C_Update()
        {
            Assert.IsTrue(complaintLocationRepository.Update(new ComplaintLocation { ComplaintLocationID = complaintLocationRepository.GetAll().OrderByDescending(x => x.ComplaintLocationID).FirstOrDefault().ComplaintLocationID, ComplaintLocationDescription = "Sambil", ComplaintLocationIsActive = false }));
        }

        [TestMethod]
        public void D_Delete()
        {
            Assert.IsTrue(complaintLocationRepository.Delete(new ComplaintLocation { ComplaintLocationID = complaintLocationRepository.GetAll().OrderByDescending(x => x.ComplaintLocationID).FirstOrDefault().ComplaintLocationID }));
        }
    }
}
