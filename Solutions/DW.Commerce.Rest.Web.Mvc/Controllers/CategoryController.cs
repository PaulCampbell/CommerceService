using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SharpArch.NHibernate.Web.Mvc;
using DW.Commerce.Rest.Domain;
using SharpArch.NHibernate.Contracts.Repositories;

namespace DW.Commerce.Rest.Web.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        private INHibernateRepository<Category> _repo;

        public CategoryController(INHibernateRepository<Category> repo)
        {
            _repo = repo;
        }

        [Transaction]
        public ActionResult Index()
        {
            return Json(_repo.GetAll(), JsonRequestBehavior.AllowGet);
        }

        [Transaction]
        public ActionResult Show(int Id)
        {
            return Json(_repo.Get(Id), JsonRequestBehavior.AllowGet);
        }

    }
}
