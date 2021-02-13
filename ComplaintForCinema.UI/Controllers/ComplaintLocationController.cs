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
    public class ComplaintLocationController : Controller
    {
        private readonly IGenericRepositoryService<ComplaintLocationDto> complaintLocationRepositoryService = new ComplaintLocationRepositoryService();

        // GET: ComplaintLocation
        public ActionResult Index()
        {
            return View(complaintLocationRepositoryService.GetAll());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ComplaintLocationDto obj)
        {
            try
            {
                complaintLocationRepositoryService.Insert(obj);
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
        public ActionResult Edit(ComplaintLocationDto ID)
        {
            try
            {
                complaintLocationRepositoryService.Update(ID);
                return RedirectToAction("Index");
            }
            catch (UserValidationException ex)
            {
                foreach (var errors in ex.ValidationFailures)
                {
                    ModelState.AddModelError(errors.PropertyName, errors.ErrorMessage);
                }
            }
            return View(ID);
        }

        public ActionResult Edit(Guid? obj)
        {
            if (obj is null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            var complaintLocation = complaintLocationRepositoryService.Get(new ComplaintLocationDto { ID = obj });

            if (complaintLocation is null)
                return HttpNotFound();

            return View(complaintLocation);
        }

        public ActionResult Details(ComplaintLocationDto obj)
        {
            if (obj is null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            var complaintLocation = complaintLocationRepositoryService.Get(obj);

            if (complaintLocation is null)
                return HttpNotFound();

            return View(complaintLocation);
        }

        public ActionResult Delete(ComplaintLocationDto obj)
        {
            if (obj is null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            var complaintLocation = complaintLocationRepositoryService.Get(obj);

            if (complaintLocation is null)
                return HttpNotFound();

            return View(complaintLocation);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmation(ComplaintLocationDto obj)
        {

            complaintLocationRepositoryService.Delete(obj);
            return RedirectToAction("Index");
        }

    }
}