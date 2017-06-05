using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SemesterSportsСlub.domain;
using SemesterSportsСlub.infrastructure;
using SemesterSportsСlub.Infrastructure;

namespace SemesterSportsСlub.view.admin {
    public partial class fForAdminEditPriceList : Form
    {
        DataBasePriceOfSheet dataBasePriceOfSheet = new DataBasePriceOfSheet();
        ListOfServices listOfServices = new ListOfServices();
        ListOfDiscounts listOfDiscounts = new ListOfDiscounts();
        private User _userAdmin;

        int indexRow;
        private Thread th;

        public fForAdminEditPriceList(object userAdmin) {
            InitializeComponent();
            this._userAdmin = (User)userAdmin;
        }

        private void fForAdminEditPriceList_Load(object sender, EventArgs e)
        {
            DataBasePriceOfSheet dataBasePriceOfSheet = new DataBasePriceOfSheet();
            dataBasePriceOfSheet.AddDataInDataGridViewDiscount(dataGridViewDiscount);
            dataBasePriceOfSheet.AddDataInDataGridViewService(dataGridViewService);
        }
        //Для Услуг
        private void добавитьДанныеToolStripMenuItem_Click_1(object sender, EventArgs e) {
            dataBasePriceOfSheet.AddRowInDataGridViewService(tbNameService.Text, tbPrieceService.Text, tbDiscriptionService.Text);
            dataBasePriceOfSheet.AddDataInDataGridViewService(dataGridViewService);
        }

        private void dataGridViewService_CellClick(object sender, DataGridViewCellEventArgs e) {
            indexRow = e.RowIndex;
            if (e.RowIndex != -1)
            {
                tbIdService.Text = dataGridViewService.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbNameService.Text = dataGridViewService.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbPrieceService.Text = dataGridViewService.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbDiscriptionService.Text = dataGridViewService.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        private void обновитьДанныеToolStripMenuItem_Click(object sender, EventArgs e) {
            try
            {
                listOfServices.ListInformationAboutServices[indexRow].idService = Convert.ToInt32(tbIdService.Text);
                listOfServices.ListInformationAboutServices[indexRow].nameService = tbNameService.Text;
                listOfServices.ListInformationAboutServices[indexRow].priceOfService = Convert.ToDouble(tbPrieceService.Text);
                listOfServices.ListInformationAboutServices[indexRow].discriptionService = tbDiscriptionService.Text;
                dataBasePriceOfSheet.UpdateDataInDataGridViewService(Convert.ToString(tbIdService.Text), tbNameService.Text,
                    tbPrieceService.Text, tbDiscriptionService.Text);
                dataBasePriceOfSheet.AddDataInDataGridViewService(dataGridViewService);
            }
            catch (Exception exceptionEnterError)
            {
                MessageBox.Show("Проверьте данные!!! \n 'Цена услуги' может состоять только из цифр." +
                                "", exceptionEnterError.Message, MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void удалитьДанныеToolStripMenuItem_Click(object sender, EventArgs e) {
            tbIdService.Text = dataGridViewService.Rows[indexRow].Cells[0].Value.ToString();
            dataBasePriceOfSheet.DeleteDataInDataGridViewService(tbIdService.Text);
            dataBasePriceOfSheet.AddDataInDataGridViewService(dataGridViewService);
        }

        //Для Скидок
        private void добавитьДанныеToolStripMenuItem1_Click(object sender, EventArgs e) {
            dataBasePriceOfSheet.AddRowInDataGridViewDiscount(tbNameDiscount.Text, tbDiscountInPercent.Text, 
                Convert.ToDateTime(dateTimePickerPeriod.Text), tbDiscriptionOfDiscount.Text);
            dataBasePriceOfSheet.AddDataInDataGridViewDiscount(dataGridViewDiscount);
        }

        private void dataGridViewDiscount_CellClick(object sender, DataGridViewCellEventArgs e) {
            indexRow = e.RowIndex;
            if (e.RowIndex != -1) {
                tbIdDiscount.Text = dataGridViewDiscount.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbNameDiscount.Text = dataGridViewDiscount.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbDiscountInPercent.Text = dataGridViewDiscount.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePickerPeriod.Text = dataGridViewDiscount.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbDiscriptionOfDiscount.Text = dataGridViewDiscount.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void обновитьДанныеToolStripMenuItem1_Click(object sender, EventArgs e) {
            try
            {
                    if (Convert.ToInt32(tbDiscountInPercent.Text) < 100)
                    {
                        listOfDiscounts.listInformationAboutDiscounts[indexRow].idDiscount =
                            Convert.ToInt32(tbIdDiscount.Text);
                        listOfDiscounts.listInformationAboutDiscounts[indexRow].nameDiscount = tbNameDiscount.Text;
                        listOfDiscounts.listInformationAboutDiscounts[indexRow].discountInpercent =
                            Convert.ToInt32(tbDiscountInPercent.Text);
                        listOfDiscounts.listInformationAboutDiscounts[indexRow].periodOfDiscount =
                            Convert.ToDateTime(dateTimePickerPeriod.Text);
                        listOfDiscounts.listInformationAboutDiscounts[indexRow].discriptionDiscount =
                            tbDiscriptionOfDiscount.Text;
                        dataBasePriceOfSheet.UpdateDataInDataGridViewDiscount(tbIdDiscount.Text, tbNameDiscount.Text,
                            tbDiscountInPercent.Text, Convert.ToDateTime(dateTimePickerPeriod.Text),
                            tbDiscriptionOfDiscount.Text);
                        dataBasePriceOfSheet.AddDataInDataGridViewDiscount(dataGridViewDiscount);
                    }
                    else
                    {
                        MessageBox.Show("Проверьте данные!!! \n 'Скидка в процентах' должна быть меньше 100!." +
                              "", "Ошибка в формате ввода", MessageBoxButtons.OK,
             MessageBoxIcon.Error);
                    }
                }
            catch (Exception exceptionEnter)
            {
                MessageBox.Show("Проверьте данные!!! \n 'Скидка в процентах' не должна содержать посторонии знаки, кроме цифр!." +
                               "", exceptionEnter.Message, MessageBoxButtons.OK,
              MessageBoxIcon.Error);
            }
        }

        private void удалитьДанныеToolStripMenuItem1_Click(object sender, EventArgs e) {
            tbIdDiscount.Text = dataGridViewDiscount.Rows[indexRow].Cells[0].Value.ToString();
            dataBasePriceOfSheet.DeleteDataInDataGridViewDiscount(tbIdDiscount.Text);
            dataBasePriceOfSheet.AddDataInDataGridViewDiscount(dataGridViewDiscount);
        }

        private void назадToolStripMenuItem_Click_1(object sender, EventArgs e) {
            this.Close();
            th = new Thread(OpenfForAdminMainMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForAdminMainMenu()
        {
            Application.Run(new fForAdminMainMenu(_userAdmin));
        }

        private void выйтиToolStripMenuItem1_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}