﻿using ComplaintForCinema.BLL.Dto;
using ComplaintForCinema.BLL.Service;
using ComplaintForCinema.BLL.Service.Interface;
using ComplaintForCinema.TL.BLL.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintForCinema.TL.BLL
{
    [TestClass]
    public class ComplaintLocationRepositoryServiceUnitTest : IGenericRepositoryUnitTest
    {
        private readonly IGenericRepositoryService<ComplaintLocationDto> complaintStatusDtoService = new ComplaintLocationRepositoryService();

        [TestMethod]
        public void A_Insert()
        {

            Assert.AreEqual(complaintStatusDtoService.Insert(new ComplaintLocationDto { Description = "Active", Status = true }), 0);
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
            Assert.IsTrue(complaintStatusDtoService.Update(new ComplaintLocationDto { ID = complaintStatusDtoService.GetAll().OrderByDescending(x => x.ID).FirstOrDefault().ID, Description = "Update", Status = false }));
        }

        [TestMethod]
        public void D_Delete()
        {
            Assert.IsTrue(complaintStatusDtoService.Delete(new ComplaintLocationDto { ID = complaintStatusDtoService.GetAll().OrderByDescending(x => x.ID).FirstOrDefault().ID }));
        }
    }
}
