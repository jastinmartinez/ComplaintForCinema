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
    public class ComplaintCategoryRepositoryUnitTest : IGenericRepositoryUnitTest
    {
        private readonly IGenericRepository<ComplaintCategory> complaintcategoryRepository = new ComplaintCategoryRepository();

        [TestMethod]
        public void A_Insert()
        {
            Assert.AreEqual(complaintcategoryRepository.Insert(new ComplaintCategory {  ComplaintCategoryDescription = "Insert", ComplaintCategoryIsActive = true }), 0);
        }

        [TestMethod]
        public void B_GetAll()
        {
            Assert.IsTrue(condition: complaintcategoryRepository.GetAll().Any());
        }

        [TestMethod]
        public void C_Update()
        {
            Assert.IsTrue(complaintcategoryRepository.Update(new ComplaintCategory { ComplaintCategoryID = complaintcategoryRepository.GetAll().OrderByDescending(x => x.ComplaintCategoryID).FirstOrDefault().ComplaintCategoryID, ComplaintCategoryDescription = "Update", ComplaintCategoryIsActive = false }));
        }

        [TestMethod]
        public void D_Delete()
        {
            Assert.IsTrue(complaintcategoryRepository.Delete(new ComplaintCategory { ComplaintCategoryID = complaintcategoryRepository.GetAll().OrderByDescending(x => x.ComplaintCategoryID).FirstOrDefault().ComplaintCategoryID }));
        }

    }
}
