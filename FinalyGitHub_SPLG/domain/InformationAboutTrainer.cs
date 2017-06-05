using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterSportsСlub.domain {
    class InformationAboutTrainer
    {
        public int idTrainer;
        public string lastName;
        public string firstName;
        public string secondName;
        public string discriptionOfTrainer;
        public int countOfClients;
        public string photoTrainer;

        public InformationAboutTrainer(int cid_trainer, string clast_name, string cfirst_name,
            string csecond_name, string discriptionOfTrainer, int ccount_of_clients, string photo_trainer)
        {
            this.idTrainer = cid_trainer;
            this.lastName = clast_name;
            this.firstName = cfirst_name;
            this.secondName = csecond_name;
            this.discriptionOfTrainer = discriptionOfTrainer;
            this.countOfClients = ccount_of_clients;
            this.photoTrainer = photo_trainer;
        }
    }
}
