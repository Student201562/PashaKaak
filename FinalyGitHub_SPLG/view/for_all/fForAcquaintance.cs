using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SemesterSportsСlub.view.client;
using SemesterSportsСlub.view.admin;
using SemesterSportsСlub.Infrastructure;

namespace SemesterSportsСlub.view.for_all {
    public partial class fForAcquaintance : Form
    {
        Thread th;
        public fForAcquaintance() {
            InitializeComponent();
        }

        private void butAuthorization_Click(object sender, EventArgs e) {
            this.Close();
            th = new Thread(OpenForAuthorizathoin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void butPriceList_Click(object sender, EventArgs e) {
            this.Close();
            th = new Thread(OpenForAcquaintancePriceOfList);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenForAcquaintancePriceOfList()
        {
            Application.Run(new fForAcquaintancePriceOfList());    
        }

        private void OpenForAuthorizathoin(object obj) {
            Application.Run(new fAuthorization());
        }

        private void butTrainerList_Click(object sender, EventArgs e) {
            this.Close();
            th = new Thread(OpenfForAcquaintanceListOfTrainers);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenfForAcquaintanceListOfTrainers(object obj) {
            Application.Run(new fForAcquaintanceListOfTrainers());
        }
    }
}
