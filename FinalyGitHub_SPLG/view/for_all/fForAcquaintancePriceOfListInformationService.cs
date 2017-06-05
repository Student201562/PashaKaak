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
using SemesterSportsСlub.domain.recognize;

namespace SemesterSportsСlub.view.for_all {
    public partial class fForAcquaintancePriceOfListInformationService : Form
    {
        private Thread th;
        public fForAcquaintancePriceOfListInformationService(int idService) {
            InitializeComponent();
            var recognizeWhichDiscount = new RecognizeWhichServises(idService);
            labelNameService.Text = recognizeWhichDiscount.nameService;
            labelDiscriptionService.Text = recognizeWhichDiscount.discriptionService;
            labelPriceOfService.Text = recognizeWhichDiscount.priceOfService.ToString();
        }

        private void butBackOnfAcquePriceOfListService_Click(object sender, EventArgs e) {
            this.Close();
            th = new Thread(OpenfForAcquaintancePriceListServices);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForAcquaintancePriceListServices()
        {
            Application.Run(new fForAcquaintancePriceListServices());
        }
    }
}
