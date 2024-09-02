using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETMVC.Models
{
    public class ProdServicesViewModel
    {
        public Product ProductPPName { get; set; }

        public Services ServicesPPName { get; set; }    

        public string Title { get; set; }

        public string Message { get; set; }

    }
}