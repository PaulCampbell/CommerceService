namespace DW.Commerce.Rest.Web.Mvc.Controllers
{
    using System.Web.Mvc;
using DW.Commerce.Rest.Domain;
    using SharpArch.Domain.PersistenceSupport;
    using SharpArch.NHibernate.Contracts.Repositories;
    using SharpArch.NHibernate;

    public class HomeController : Controller
    {
        private INHibernateRepository<Product> _repo;

        public HomeController(INHibernateRepository<Product> repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            var p = new Product
            {
                Description = "Test product description",
                Name = "Test product",
                Price = new decimal(10.99),
                ImageUrl = "http://www.all-out-commerce.com/images/products/testpic.png"
            };
            _repo.DbContext.BeginTransaction();
            _repo.Save(p);

            _repo.DbContext.CommitTransaction();


            var product = _repo.Get(1);
            ViewBag.Product = p;
            return View();
        }

    }
}
