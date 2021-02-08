using System;
using System.Linq;
using ComplaintForCinema.DAL.Model;
using ComplaintForCinema.DAL.Repository.Repository;
using DAL.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComplaintForCiname.TL.DAL
{
    [TestClass]
    public class ComplaintLocationRepositoryUnitTest : IGenericRepositoryUnitTest
    {
        private readonly IGenericRepository<ComplaintLocation> complaintLocationRepository = new ComplaintLocationRepository();

        [TestMethod]
        public void A_Insert()
        {
            Assert.AreEqual(complaintLocationRepository.Insert(new ComplaintLocation { ComplaintLocationID = Guid.Parse("08C8238C-6A54-4DBE-BB2A-E5813E6B67CA"), ComplaintLocationDescription = "Mega Centro", ComplaintLocationIsActive = true }), 0);
        }

        [TestMethod]
        public void B_GetAll()
        {
            Assert.IsTrue(complaintLocationRepository.GetAll().Any());
        }

        [TestMethod]
        public void C_Update()
        {
            Assert.IsTrue(complaintLocationRepository.Update(new ComplaintLocation { ComplaintLocationID = Guid.Parse("08C8238C-6A54-4DBE-BB2A-E5813E6B67CA"), ComplaintLocationDescription = "Sambil", ComplaintLocationIsActive = false }));
        }

        [TestMethod]
        public void D_Delete()
        {
            Assert.IsTrue(complaintLocationRepository.Delete(new ComplaintLocation { ComplaintLocationID = Guid.Parse("08C8238C-6A54-4DBE-BB2A-E5813E6B67CA")}));
        }
    }
}
