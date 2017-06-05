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

namespace SemesterSportsСlub.view.for_all{
    public partial class fForAcquaintancePriceOfList : Form
    {
        private Thread th;
        public fForAcquaintancePriceOfList() {
            InitializeComponent();
        }

        private void butAcquPriceOfListDiscount_Click(object sender, EventArgs e) {
            this.Close();
            th = new Thread(OpenForAcquaPriceListDiscount);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void butfAcquaintancePriceOfListBack_Click(object sender, EventArgs e) {
            this.Close();
            th = new Thread(OpenForAcquaintance);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenForAcquaPriceListDiscount() {
            Application.Run(new fForAcquaPriceListDiscount());
        }

        private void OpenForAcquaintance() {
            Application.Run(new fForAcquaintance());
        }

        private void butAcquPriceOfListService_Click(object sender, EventArgs e) {
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
