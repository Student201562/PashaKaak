using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterSportsСlub.domain {
    class User
    {
        public int id_user;
        public string type_user;
        public string last_name;
        public string first_name;
        public string second_name;
        public DateTime date_of_burn;
        public int id_trainer;

        public User(int cid_user, string ctype_user, string clast_name, string cfirst_name, string csecond_name, 
            DateTime cdate_of_burn, int cid_trainer)
        {
            this.id_user = cid_user;
            this.type_user = ctype_user;
            this.last_name = clast_name;
            this.first_name = cfirst_name;
            this.second_name = csecond_name;
            this.date_of_burn = cdate_of_burn;
            this.id_trainer = cid_trainer;
        }
    }
}
