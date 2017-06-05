using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterSportsСlub.domain.recognize {
    class RecognizeWhichDiscounts
    {
        private readonly int idofDiscount;
        public string nameDiscount { get; set; }
        public string discriptionDiscount { get; set; }
        public int discountInpercent { get; set; }
        public DateTime periodOfDiscount { get; set; }

        public RecognizeWhichDiscounts(int cidOfDiscount)
        {
            this.idofDiscount = cidOfDiscount;
            SearchDiscount();
        }

        public void SearchDiscount() {
            ListOfDiscounts listOfDiscounts = new ListOfDiscounts();

            foreach (var e in listOfDiscounts.listInformationAboutDiscounts) {
                if (e.idDiscount == idofDiscount)
                {
                    nameDiscount = e.nameDiscount;
                    discriptionDiscount = e.discriptionDiscount;
                    discountInpercent = e.discountInpercent;
                    periodOfDiscount = e.periodOfDiscount;
                }
            }
        }
    }
}
