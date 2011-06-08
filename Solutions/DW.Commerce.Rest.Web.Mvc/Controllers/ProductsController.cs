using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SharpArch.NHibernate.Contracts.Repositories;
using DW.Commerce.Rest.Domain;
using SharpArch.NHibernate.Web.Mvc;

namespace DW.Commerce.Rest.Web.Mvc.Controllers
{
    public class ProductsController : Controller
    {
        private INHibernateRepository<Product> _repo;

        public ProductsController(INHibernateRepository<Product> repo)
        {
            _repo = repo;
        }


        [Transaction]
        public ActionResult Index()
        {
            var products = _repo.GetAll();
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        [Transaction]
        public ActionResult Show(int Id)
        {
            return Json(_repo.Get(Id), JsonRequestBehavior.AllowGet);
        }
    }
}
