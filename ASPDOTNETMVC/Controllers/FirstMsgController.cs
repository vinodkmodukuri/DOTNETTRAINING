using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPDOTNETMVC.Controllers
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        public override string ToString()
        {
            return this.CustomerName + " " + this.CustomerAddress;
        }

    }

    public class FirstMsgController : Controller
    {

        
        // GET: FirstMsg
        public ActionResult Index()
        {
            return View();
        }

        public string Message()
        {
            return "Welcome to ASP.NET MVC";
        }

        public Customer MyCustomer()
        {
            Customer myobj = new Customer();
            myobj.CustomerName = "Rob";
            myobj.CustomerAddress = "1234 N May ave";
            return myobj;
        }

        [NonAction]
        public string Project()

        {
            return " This is a test method";
        }

       public ActionResult Test1()
        {
            return View();
        }
    }
}