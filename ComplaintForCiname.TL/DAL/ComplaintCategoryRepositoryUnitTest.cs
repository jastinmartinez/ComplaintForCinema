using System;
using System.Linq;
using ComplaintForCinema.DAL.Model;
using ComplaintForCinema.DAL.Repository.Method;
using DAL.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComplaintForCiname.TL.DAL
{
    [TestClass]
    public class ComplaintCategoryRepositoryUnitTest : IGenericRepositoryUnitTest
    {
        private readonly IGenericRepository<ComplaintCategory> repo = new ComplaintCategoryRepository();

        [TestMethod]
        public void A_Insert()
        {
            Assert.AreEqual(repo.Insert(new ComplaintCategory { ComplaintCategoryID = Guid.Parse("08C8238C-6A54-4DBE-BB2A-E5813E6B67CA"), ComplaintCategoryDescription = "Insert", ComplaintCategoryIsActive = true }), 0);
        }

        [TestMethod]
        public void B_GetAll()
        {
            Assert.IsTrue(condition: repo.GetAll().Any());
        }

        [TestMethod]
        public void C_Update()
        {
            Assert.IsTrue(repo.Update(new ComplaintCategory { ComplaintCategoryID = Guid.Parse("08C8238C-6A54-4DBE-BB2A-E5813E6B67CA"), ComplaintCategoryDescription = "Update", ComplaintCategoryIsActive = false }));
        }

        [TestMethod]
        public void D_Delete()
        {
            Assert.IsTrue(repo.Delete(new ComplaintCategory { ComplaintCategoryID = Guid.Parse("08C8238C-6A54-4DBE-BB2A-E5813E6B67CA") }));
        }

    }
}
