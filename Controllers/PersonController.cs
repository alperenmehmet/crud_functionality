using CRUDOperation_ASP.NET_Web_Application.Infrastructure.Entities.Concrete;
using CRUDOperation_ASP.NET_Web_Application.Infrastructure.Entities.Enums;
using CRUDOperation_ASP.NET_Web_Application.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDOperation_ASP.NET_Web_Application.Controllers
{
    public class PersonController : BaseController
    {
        #region CreatePerson
        [HttpGet]
        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(PersonDTO personDTO)
        {
            if (ModelState.IsValid)
            {
                Person person = new Person();
                person.Name = personDTO.Name;
                person.LastName = personDTO.LastName;
                person.BirthDate = personDTO.BirthDate;
                dbContext.People.Add(person);
                dbContext.SaveChanges();
                ViewBag.TransactionStatus = 1;
                return View();
            }

            else
            {
                ViewBag.TransactionStatus = 2;
                return View(personDTO);
            }
        }

        #endregion

        #region ListOfPerson

        public ActionResult List() => View(dbContext.People.Where(x => x.Status != Status.Passive).ToList());

        #endregion

        #region UpdatePerson
        [HttpGet]
        public ActionResult Update(int id)
        {
            Person person = dbContext.People.FirstOrDefault(x => x.Id == id);

            if (person != null)
            {
                PersonDTO personDTO = new PersonDTO();
                personDTO.Name = person.Name;
                personDTO.LastName = person.LastName;
                personDTO.BirthDate = person.BirthDate;
                return View(personDTO);
            }

            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Update(PersonDTO personDTO)
        {
            Person person = dbContext.People.FirstOrDefault(x => x.Id == personDTO.Id);

            if (person != null)
            {
                person.Name = personDTO.Name;
                person.LastName = personDTO.LastName;
                person.BirthDate = personDTO.BirthDate;
                person.Status = Status.Modified;
                person.UpdateDate = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("List");
            }

            else
            {
                return View(personDTO);
            }

        }

        #endregion

        #region DeletePerson

        public JsonResult Delete(int id)
        {
            Person person = dbContext.People.FirstOrDefault(x => x.Id == id);

            if (person != null)
            {
                person.DeleteDate = DateTime.Now;
                person.Status = Status.Passive;
                dbContext.SaveChanges();
                return Json("");
            }

            else
            {
                return Json("");
            }
        }

        #endregion
    }
}