using ASPDOTNETMVC.Models;
using System.Web.Mvc;

namespace ASPDOTNETMVC.Controllers
{
    public class StoreProductsController : Controller
    {
        // GET: StoreProducts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOfProducts()
        {
            Product myobj = new Product();
            myobj.ProductID = 1;
            myobj.ProductName = "Engine Oil";
            myobj.ProductDescription = "GM Engine Oil";

            // ViewData["myproducts"] = myobj;
            //ViewBag.ViewProducts = myobj;

            return View(myobj);


        }
        public ActionResult DisplayProdService()
        {
            Product myproduct = new Product()
            {
                ProductID = 4,
                ProductName = "Break oil",
                ProductDescription = "Break oil for the Chevy cars"
            };

            Services myservices = new Services()
            {
                OilChnage = " For all the cars",
                CarWash = "Only $10",
                EngineCheck = "Free for all cars"
            };

            ProdServicesViewModel myProdServices = new ProdServicesViewModel()
            {
                ProductPPName = myproduct,
                ServicesPPName = myservices,
                Title = "List Products and Services",
                Message = " This shows the list of prod & services"
            };


            return View(myProdServices);


        }



    }
}
