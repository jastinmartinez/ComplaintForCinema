using ComplaintForCinema.BLL.Dto;
using ComplaintForCinema.BLL.Exceptions;
using ComplaintForCinema.BLL.Service;
using ComplaintForCinema.BLL.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace ComplaintForCinema.Controllers
{
    public class ComplaintStatusController : Controller
    {
        private readonly IGenericRepositoryService<ComplaintStatusDto> complaintStatusRepositoryService = new ComplaintStatusRepositoryService();
        // GET: ComplainStatus
        public ActionResult Index()
        {
            return View(complaintStatusRepositoryService.GetAll());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ComplaintStatusDto obj)
        {
            try
            {
                complaintStatusRepositoryService.Insert(obj);
                return RedirectToAction("Index");
            }
            catch (UserValidationException ex)
            {

                foreach (var errors in ex.ValidationFailures)
                {
                    ModelState.AddModelError(errors.PropertyName, errors.ErrorMessage);
                }
            }
            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(ComplaintStatusDto obj)
        {
            try
            {
                complaintStatusRepositoryService.Update(obj);
                return RedirectToAction("Index");
            }
            catch (UserValidationException ex)
            {

                foreach (var errors in ex.ValidationFailures)
                {
                    ModelState.AddModelError(errors.PropertyName, errors.ErrorMessage);
                }
            }
            return View(obj);
        }

        public ActionResult Edit(Guid? ID)
        {
            if (ID is null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            var complaintStatus = complaintStatusRepositoryService.Get(new ComplaintStatusDto { ID = ID });

            if (complaintStatus is null)
                return HttpNotFound();

            return View(complaintStatus);
        }

        public ActionResult Details(ComplaintStatusDto obj)
        {
            if (obj is null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            var complaintStatus = complaintStatusRepositoryService.Get(obj);

            if (complaintStatus is null)
                return HttpNotFound();

            return View(complaintStatus);
        }

        public ActionResult Delete(ComplaintStatusDto obj)
        {
            if (obj is null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            var complaintStatus = complaintStatusRepositoryService.Get(obj);

            if (complaintStatus is null)
                return HttpNotFound();

            return View(complaintStatus);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmation(ComplaintStatusDto obj)
        {
            complaintStatusRepositoryService.Delete(obj);
            return RedirectToAction("Index");
        }
    }
}