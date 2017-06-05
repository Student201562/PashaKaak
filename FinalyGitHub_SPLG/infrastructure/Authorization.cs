using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SemesterSportsСlub.domain;
using SemesterSportsСlub.view;


namespace SemesterSportsСlub.Infrastructure {
    class Authorization {
        private string _userName;
        private string _password;

        public Authorization(string userNameTextBox, string passwordTextBox) {
            this._userName = userNameTextBox;
            this._password = passwordTextBox;
        }

        public User DownloadWithDb()
        {
            User newUser;
            LinqSqlSportClubDataContext contex = new LinqSqlSportClubDataContext();

            var quaryOnLogin = from t in contex.Authorization
                where t.Login == _userName && t.Password == _password
                select t;
            foreach (var e in quaryOnLogin)
            {
                newUser = new User(e.id_user, e.TypeUser, e.last_name, e.first_name, e.second_name,
                    Convert.ToDateTime(e.date_of_burn), Convert.ToInt32(e.id_tainer));
                return newUser;
            }
            return null;
        }
    }
}
