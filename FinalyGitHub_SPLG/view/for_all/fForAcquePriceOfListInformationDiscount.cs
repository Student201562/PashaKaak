using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SemesterSportsСlub.domain;
using SemesterSportsСlub.domain.recognize;

namespace SemesterSportsСlub.view.for_all {
    public partial class fForAcquePriceOfListInformationDiscount : Form
    {

        private Thread th;
        public fForAcquePriceOfListInformationDiscount(int idOfDiscount) {
            InitializeComponent();
            var recognizeWhichDiscount = new RecognizeWhichDiscounts(idOfDiscount);
            labelNameDiscount.Text = recognizeWhichDiscount.nameDiscount;
            labelDiscriptionDiscount.Text = recognizeWhichDiscount.discriptionDiscount;
            labelDiscountInpercent.Text = recognizeWhichDiscount.discountInpercent.ToString() + "%";
            labelTimePeriodDiscount.Text = recognizeWhichDiscount.periodOfDiscount.ToString();

        }

        private void butBackOnfAcquePriceOfListDiscount_Click(object sender, EventArgs e) {
            this.Close();
            th = new Thread(OpenfForAcquaPriceOfListDiscount);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForAcquaPriceOfListDiscount()
        {
            Application.Run(new fForAcquaPriceListDiscount());
        }
    }
}
