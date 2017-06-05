using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterSportsСlub.domain {
    class InformationAboutService
    {
        public int idService;
        public string nameService;
        public string discriptionService;
        public double priceOfService;

        public InformationAboutService(int cidService, string cnameService, string cdiscriptionService, 
            double cpriceOfService)
        {
            this.idService = cidService;
            this.nameService = cnameService;
            this.discriptionService = cdiscriptionService;
            this.priceOfService = cpriceOfService;
        }
    }
}
