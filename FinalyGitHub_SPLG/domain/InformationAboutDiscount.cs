using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterSportsСlub.domain {
    class InformationAboutDiscount
    {
        public int idDiscount;
        public string nameDiscount;
        public string discriptionDiscount;
        public int discountInpercent;
        public DateTime periodOfDiscount;

        public InformationAboutDiscount(int cidDiscount, string cnameDiscount, string cdiscriptionDiscount, 
            int cdiscountInpercent, DateTime cperiodOfDiscount)
        {
            this.idDiscount = cidDiscount;
            this.nameDiscount = cnameDiscount;
            this.discriptionDiscount = cdiscriptionDiscount;
            this.discountInpercent = cdiscountInpercent;
            this.periodOfDiscount = cperiodOfDiscount;
        }

    }
}
