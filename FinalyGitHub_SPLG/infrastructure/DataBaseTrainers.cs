using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SemesterSportsСlub.domain;

namespace SemesterSportsСlub.infrastructure {
    class DataBaseTrainers {

        private string connectionServer =
          @"Data Source=KIRILLKAP\SQLEXPRESS;Initial Catalog=Sport Club;Integrated Security=True";

        public List<InformationAboutTrainer> AddPriceOfListInformationAboutTrainers() {

            List<InformationAboutTrainer> infrInformationAboutTrainers = new List<InformationAboutTrainer>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionServer)) {
                sqlConnection.Open();
                LinqSqlSportClubDataContext contex = new LinqSqlSportClubDataContext();

                var linqQuary = from t in contex.Trainers
                                select t;

                foreach (var e in linqQuary) {
                    infrInformationAboutTrainers.Add(new InformationAboutTrainer(e.id_trainer, e.last_name, e.first_name, e.second_name,
                        e.discription_of_trainer, e.count_of_client.Value, e.photo_trainer));
                }

                sqlConnection.Close();
                return infrInformationAboutTrainers;
            }
        }
    }
}
