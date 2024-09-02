using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETMVCPractice.Models
{
    public class ProgramsStatsViewModel
    {
        public Programs ListOfPrograms { get; set; }    

        public Stats ListOfStats { get; set; }

        public String Title { get; set; }

        public String Description { get; set; }

    }
}