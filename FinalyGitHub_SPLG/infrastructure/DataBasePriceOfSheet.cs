using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SemesterSportsСlub.domain;

namespace SemesterSportsСlub.infrastructure {
    class DataBasePriceOfSheet {
        LinqSqlSportClubDataContext context = new LinqSqlSportClubDataContext();
        public List<InformationAboutDiscount> AddPriceOfListInformationAboutDiscounts() {

            List<InformationAboutDiscount> listInformationAboutDiscounts = new List<InformationAboutDiscount>();

                var linqQuary = from t in context.Discounts
                                select t;

                foreach (var e in linqQuary) {
                    listInformationAboutDiscounts.Add(new InformationAboutDiscount(e.id, e.NameDiscount, e.DiscriptionOfDiscount,
                        e.DiscountInpercent.Value, e.Period.Value));
                }

                return listInformationAboutDiscounts;
        }

        public List<InformationAboutService> AddPriceOfListInformationAboutServices() {

            List<InformationAboutService> listInformationAboutServices = new List<InformationAboutService>();

                var linqQuary = from t in context.Services
                                select t;

                foreach (var e in linqQuary) {
                    listInformationAboutServices.Add(new InformationAboutService(e.id_service, e.NameService, e.DiscriptionOfService,
                        e.PriceOfService.Value));
                }

                return listInformationAboutServices;
        }

        //Методы для таблицы Услуги
        public void AddDataInDataGridViewService(DataGridView dataGridViewService) {
            var quary = from t in context.Services
                        select t;
            dataGridViewService.DataSource = quary.ToList();
        }

        public void AddRowInDataGridViewService(string cnameService, string cPriceOfService, string cDiscriptionName) 
        {
            Services newServices = new Services
            {
                NameService = cnameService,
                PriceOfService = Convert.ToDouble(cPriceOfService),
                DiscriptionOfService = cDiscriptionName
            };

            context.Services.InsertOnSubmit(newServices);
            context.SubmitChanges();
        }

        public void UpdateDataInDataGridViewService(string cIdService, string cnameService, string cPriceOfService, string cDiscriptionName)
        {
            
            var quary = from t in context.Services
                where t.id_service == Convert.ToInt32(cIdService)
                select t;

            foreach (var nServices in quary)
            {
                nServices.NameService = cnameService;
                nServices.PriceOfService = Convert.ToDouble(cPriceOfService);
                nServices.DiscriptionOfService = cDiscriptionName;
            }

            context.SubmitChanges();
        }

        public void DeleteDataInDataGridViewService(string cIdService)
        {
            var quary = from t in context.Services
                        where t.id_service == Convert.ToInt32(cIdService)
                        select t;

            foreach (var nServices in quary) {
                context.Services.DeleteOnSubmit(nServices);
            }

            context.SubmitChanges();
        }

        //Методы для таблицы Скидки
        public void AddDataInDataGridViewDiscount(DataGridView dataGridViewDiscount) {
            var quary = from t in context.Discounts
                        select t;
            dataGridViewDiscount.DataSource = quary.ToList();
        }

        public void AddRowInDataGridViewDiscount(string cnameDiscount, string cdiscountInPercent, DateTime cperiod, string cdiscriptionOfDiscount) {
            Discounts newDiscounts = new Discounts
            {
                NameDiscount = cnameDiscount,
                DiscountInpercent = Convert.ToInt32(cdiscountInPercent),
                Period = cperiod,
                DiscriptionOfDiscount = cdiscriptionOfDiscount
            };

            context.Discounts.InsertOnSubmit(newDiscounts);
            context.SubmitChanges();
        }

        public void UpdateDataInDataGridViewDiscount(string cidDiscount, string cnameDiscount, string cdiscountInPercent, DateTime cperiod, string cdiscriptionOfDiscount) {

            var quary = from t in context.Discounts
                        where t.id == Convert.ToInt32(cidDiscount)
                        select t;

            foreach (var nDiscount in quary) {
                nDiscount.NameDiscount = cnameDiscount;
                nDiscount.DiscountInpercent = Convert.ToInt32(cdiscountInPercent);
                nDiscount.Period = cperiod;
                nDiscount.DiscriptionOfDiscount = cdiscriptionOfDiscount;
            }

            context.SubmitChanges();
        }

        public void DeleteDataInDataGridViewDiscount(string cidDiscount) {
            var quary = from t in context.Discounts
                        where t.id == Convert.ToInt32(cidDiscount)
                        select t;

            foreach (var nDiscount in quary) {
                context.Discounts.DeleteOnSubmit(nDiscount);
            }

            context.SubmitChanges();
        }
    }
}
//string connection = @"Data Source=KIRILLKAP\SQLEXPRESS;Initial Catalog=Sport Club;Integrated Security=True";
//SqlConnection sqlConnection = new SqlConnection(connection);
//SqlCommand sqlCommand = new SqlCommand("select * from [Discounts];", sqlConnection);

//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
//sqlDataAdapter.SelectCommand = sqlCommand;
//DataTable table = new DataTable();
//sqlDataAdapter.Fill(table);
//BindingSource bindingSource = new BindingSource();
//bindingSource.DataSource = table;
//dataGridViewDiscount.DataSource = bindingSource;
//sqlDataAdapter.Update(table);