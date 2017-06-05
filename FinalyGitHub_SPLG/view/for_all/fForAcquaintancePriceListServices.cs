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
using SemesterSportsСlub.domain;
using SemesterSportsСlub.infrastructure;
using SemesterSportsСlub.MyControls;

namespace SemesterSportsСlub.view.for_all {
    public partial class fForAcquaintancePriceListServices : Form
    {
        private Thread th;
        private static int idOfService;
        public fForAcquaintancePriceListServices() {
            InitializeComponent();
            AddButtonsOnfForAcquaPriceOfListServices();
        }

        private void butBackfForAcquaPriceListService_Click(object sender, EventArgs e) {
            this.Close();
            th = new Thread(OpenfForAcquaintancePriceList);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void AddButtonsOnfForAcquaPriceOfListServices() {
            DataBasePriceOfSheet dataBasePriceOfSheet = new DataBasePriceOfSheet();

            dataBasePriceOfSheet.AddPriceOfListInformationAboutServices();
            var listOfServices = new ListOfServices();
            ButtonWithId[] butListOfMethods = new ButtonWithId[listOfServices.ListInformationAboutServices.Count];

            for (int i = 0; i < listOfServices.ListInformationAboutServices.Count; i++) {
                butListOfMethods[i] = new ButtonWithId();
                butListOfMethods[i].Size = new Size(this.Width - 70, 50);
                butListOfMethods[i].Location = new Point(20, 50 * i + 50);
                butListOfMethods[i].BackColor = Color.Aqua;
                butListOfMethods[i].Text = listOfServices.ListInformationAboutServices[i].nameService.ToString();
                butListOfMethods[i].IdButton = listOfServices.ListInformationAboutServices[i].idService;
                Controls.Add(butListOfMethods[i]);
                butListOfMethods[i].MouseClick += new MouseEventHandler(OpenfForAcquePriceOfListInfoDiscount);
            }
        }

        private void OpenfForAcquePriceOfListInfoDiscount(object sender, EventArgs e) {
            idOfService = ((ButtonWithId)(sender)).IdButton;
            this.Close();
            th = new Thread(OpenfForAcquePriceOfListInformationServices);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForAcquePriceOfListInformationServices() {
            Application.Run(new fForAcquaintancePriceOfListInformationService(idOfService));
        }
        private void OpenfForAcquaintancePriceList()
        {
            Application.Run(new fForAcquaintancePriceOfList());
        }
    }
}
