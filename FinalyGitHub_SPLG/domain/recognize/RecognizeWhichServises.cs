using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterSportsСlub.domain.recognize {
    class RecognizeWhichServises {
        private readonly int idService;
        public string nameService { get; set; }
        public string discriptionService { get; set; }
        public double priceOfService { get; set; }


        public RecognizeWhichServises(int cidService) {
            this.idService = cidService;
            SearchDiscount();
        }

        public void SearchDiscount() {
            var listOfServices = new ListOfServices();

            foreach (var e in listOfServices.ListInformationAboutServices) {
                if (e.idService == idService) {
                    nameService = e.nameService;
                    discriptionService = e.discriptionService;
                    priceOfService = e.priceOfService;
                }
            }
        }
    }
}
