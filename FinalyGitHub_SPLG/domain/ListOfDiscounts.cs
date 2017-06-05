using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SemesterSportsСlub.infrastructure;

namespace SemesterSportsСlub.domain {
    class ListOfDiscounts
    {
        public List<InformationAboutDiscount> listInformationAboutDiscounts;

        public ListOfDiscounts() 
        {
           this.listInformationAboutDiscounts = new DataBasePriceOfSheet().AddPriceOfListInformationAboutDiscounts();
        }
    }
}
