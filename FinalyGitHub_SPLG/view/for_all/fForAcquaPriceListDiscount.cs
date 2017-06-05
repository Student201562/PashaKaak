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
using SemesterSportsСlub.infrastructure;
using SemesterSportsСlub.Infrastructure;
using SemesterSportsСlub.MyControls;

namespace SemesterSportsСlub.view.for_all {
    public partial class fForAcquaPriceListDiscount : Form
    {

        private Thread th;
        public static int idDiscount;
        public fForAcquaPriceListDiscount() {
            InitializeComponent();
            AddButtonsOnfForAcquaPriceListDiscount();
        }

        public void AddButtonsOnfForAcquaPriceListDiscount()
        {
            DataBasePriceOfSheet dataBasePriceOfSheet = new DataBasePriceOfSheet();

            dataBasePriceOfSheet.AddPriceOfListInformationAboutDiscounts();
            ListOfDiscounts listOfDiscounts = new ListOfDiscounts();
            ButtonWithId[] butListOfMethods = new ButtonWithId[listOfDiscounts.listInformationAboutDiscounts.Count];

            for (int i = 0; i < listOfDiscounts.listInformationAboutDiscounts.Count; i++) {
                butListOfMethods[i] = new ButtonWithId();
                butListOfMethods[i].Size = new Size(this.Width, 50);
                butListOfMethods[i].Location = new Point(0, 50 * i + 50);
                butListOfMethods[i].BackColor = Color.Aqua;
                butListOfMethods[i].Text = listOfDiscounts.listInformationAboutDiscounts[i].nameDiscount.ToString();
                butListOfMethods[i].IdButton = listOfDiscounts.listInformationAboutDiscounts[i].idDiscount;
                Controls.Add(butListOfMethods[i]);
                butListOfMethods[i].MouseClick += new MouseEventHandler(OpenfForAcquePriceOfListInfoDiscount);
            }
        }

        private void OpenfForAcquePriceOfListInfoDiscount(object sender, EventArgs e)
        {
            idDiscount = ((ButtonWithId)(sender)).IdButton;
            this.Close();
            th = new Thread(OpenfForAcquePriceOfListInformationDiscount);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForAcquePriceOfListInformationDiscount()
        {
            Application.Run(new fForAcquePriceOfListInformationDiscount(idDiscount));
        }

        private void butBackfForAcquaintancePriceOfList_Click(object sender, EventArgs e) {
            this.Close();
            th = new Thread(OpenfForAcquaintancePriceOfList);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForAcquaintancePriceOfList()
        {
            Application.Run(new fForAcquaintancePriceOfList());
        }
    }
}
