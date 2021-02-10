using CinemaComplaint.BLL.Dto;
using CinemaComplaint.BLL.Exceptions;
using CinemaComplaint.BLL.Service;
using CinemaComplaint.BLL.Service.Interface;
using CinemaComplaint.BLL.Validation;
using System;
using System.Net;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace ComplaintForCinema.Controllers
{

    public class ComplaintCategoryController : Controller
    {

        private readonly IGenericRepositoryService<ComplaintCategoryDto> complaintCategoryRepositoryService = new ComplaintCategoryRepositoryService();

        public ActionResult Index()
        {
            return View(complaintCategoryRepositoryService.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ComplaintCategoryDto categoryDto)
        {
            try
            {
                complaintCategoryRepositoryService.Insert(categoryDto);
                return RedirectToAction("Index");
            }
            catch (UserValidationException ex)
            {
                foreach (var error in ex.ValidationFailures)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }

            return View(categoryDto);
        }
        public ActionResult Edit(Guid? ID)
        {
            if (ID is null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var categoryDetail = complaintCategoryRepositoryService.Get(new ComplaintCategoryDto { ID = ID });

            if (categoryDetail is null)
                return HttpNotFound();

            return View(categoryDetail);
        }


        [HttpPost]
        public ActionResult Edit(ComplaintCategoryDto categoryDto)
        {
            try
            {
                complaintCategoryRepositoryService.Update(categoryDto);
                return RedirectToAction("Index");
            }
            catch (UserValidationException ex)
            {
                foreach (var error in ex.ValidationFailures)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }

            return View(categoryDto);
        }

        public ActionResult Details(ComplaintCategoryDto categoryDto)
        {
            if (categoryDto is null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var categoryDetail = complaintCategoryRepositoryService.Get(categoryDto);

            if (categoryDetail is null)
                return HttpNotFound();

            return View(categoryDetail);
        }

        public ActionResult Delete(ComplaintCategoryDto categoryDto)
        {
            if (categoryDto is null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var categoryDetail = complaintCategoryRepositoryService.Get(categoryDto);

            if (categoryDetail is null)
                return HttpNotFound();

            return View(categoryDetail);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(ComplaintCategoryDto categoryDto)
        {
            complaintCategoryRepositoryService.Delete(categoryDto);
            return RedirectToAction("Index");
        }
    }
}