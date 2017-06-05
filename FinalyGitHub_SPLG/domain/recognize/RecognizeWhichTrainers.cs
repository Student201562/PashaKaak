using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterSportsСlub.domain.recognize {
    class RecognizeWhichTrainers {
        private readonly int idTrainer;
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string discriptionOfTrainer { get; set; }
        public string photo_trainer { get; set; }
        public int countOfClient { get; set; }

        public RecognizeWhichTrainers(int cidTrainer) {
            this.idTrainer = cidTrainer;
            SearchTrainer();
        }

        public void SearchTrainer() {
            var listOfTrainers = new ListOfTrainers();

            foreach (var e in listOfTrainers.informationAboutTrainer) {
                if (e.idTrainer == idTrainer) {
                    lastName = e.lastName;
                    firstName = e.firstName;
                    secondName = e.secondName;
                    discriptionOfTrainer = e.discriptionOfTrainer;
                    photo_trainer = e.photoTrainer;
                    countOfClient = e.countOfClients;
                }
            }
        }
    }
}
