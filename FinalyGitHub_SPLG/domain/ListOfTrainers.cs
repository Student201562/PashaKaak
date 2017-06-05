using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SemesterSportsСlub.infrastructure;

namespace SemesterSportsСlub.domain {
    class ListOfTrainers
    {
        public List<InformationAboutTrainer> informationAboutTrainer;

        public ListOfTrainers()
        {
            this.informationAboutTrainer = new DataBaseTrainers().AddPriceOfListInformationAboutTrainers();
        }
    }
}
