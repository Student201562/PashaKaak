using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SemesterSportsСlub.infrastructure;

namespace SemesterSportsСlub.domain {
    class ListOfServices
    {

        public List<InformationAboutService> ListInformationAboutServices;

        public ListOfServices()
        {
            this.ListInformationAboutServices = new DataBasePriceOfSheet().AddPriceOfListInformationAboutServices();
        }
    }
}
