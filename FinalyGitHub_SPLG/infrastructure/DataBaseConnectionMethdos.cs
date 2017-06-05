using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SemesterSportsСlub.domain;

namespace SemesterSportsСlub.Infrastructure {
    class DataBaseConnectionMethdos {
        public List<Method> ListOfMethod;

        private string connectionServer =
            @"Data Source=KIRILLKAP\SQLEXPRESS;Initial Catalog=Sport Club;Integrated Security=True";
        public DataBaseConnectionMethdos() {
            this.ListOfMethod = new List<Method>();
        }

        public List<Method> AddMethods() {
            using (SqlConnection sqlConnection = new SqlConnection(connectionServer)) {
                sqlConnection.Open();
                string quary = "SELECT Id, NameMethod, DescriptionOfProcedure " +
                               "FROM [Methods]";
                SqlCommand command = new SqlCommand(quary, sqlConnection);
                SqlDataReader sqlDataReader = command.ExecuteReader();

                if (sqlDataReader.HasRows) {
                    while (sqlDataReader.Read())
                    {
                        ListOfMethod.Add(new Method((sqlDataReader.GetValue(0)).ToString(), (sqlDataReader.GetValue(1).ToString()),
                                        (sqlDataReader.GetValue(2).ToString())));
                    }
                }
                sqlDataReader.Close();
                sqlConnection.Close();

                return ListOfMethod;
            }
        }
        public void DeleteMethod(string IdMethod) {
            using (SqlConnection sqlConnection = new SqlConnection(connectionServer)) {
                sqlConnection.Open();
                LinqSqlSportClubDataContext contex = new LinqSqlSportClubDataContext();
                var deleteMethod =
                from d in contex.Methods
                where d.Id == Convert.ToInt32(IdMethod)
                select d;
                try
                {
                        foreach (var detail in deleteMethod) {
                        contex.Methods.DeleteOnSubmit(detail);
                        }

                    contex.SubmitChanges();
                }
                catch (Exception e)
                {
                     MessageBox.Show("Возможные ошибки: 1) Проверте заполнено ли поле *Удалить по ID_method*\n" +
                                     "2) Возможно вы ввели не цифру, ID-не может содержать символы, буквы и тд.", e.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sqlConnection.Close();
            }
        }

        public void ChangedMethod(string idMethod, string newNameMethod, string newDiscriptionMethod) {

            using (SqlConnection sqlConnection = new SqlConnection(connectionServer)) {
                sqlConnection.Open();
                LinqSqlSportClubDataContext context = new LinqSqlSportClubDataContext();
                var writing = from t in context.Methods
                              where t.Id == Convert.ToInt32(idMethod)
                              select t;
                    foreach (var n in writing) {
                        n.NameMethod = newNameMethod;
                        n.DescriptionOfProcedure = newDiscriptionMethod;
                    }
                    context.SubmitChanges();
                sqlConnection.Close();
            }
        }

        public void AddNewMethod(string newNameMethod, string newDiscriptionMethod)
        {
            LinqSqlSportClubDataContext contex = new LinqSqlSportClubDataContext();
            Methods newMethods = new Methods
            {
                NameMethod = newNameMethod,
                DescriptionOfProcedure = newDiscriptionMethod
            };
            contex.Methods.InsertOnSubmit(newMethods);
            contex.SubmitChanges();
        }
    }
}
