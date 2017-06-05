using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SemesterSportsСlub.domain;
using SemesterSportsСlub.infrastructure;
using SemesterSportsСlub.MyControls;

namespace SemesterSportsСlub.view.for_all {
    public partial class fForAcquaintanceListOfTrainers : Form
    {

        private Thread th;
        private static int id_trainer; 
        public fForAcquaintanceListOfTrainers() {
            InitializeComponent();
            AddButtonsOnfForAcquaPriceOfListServices();
        }

        public void AddButtonsOnfForAcquaPriceOfListServices() {
            DataBaseTrainers dataBaseTrainers = new DataBaseTrainers();

            dataBaseTrainers.AddPriceOfListInformationAboutTrainers();
            var listOfTrainers = new ListOfTrainers();
            ButtonWithId[] butListOfMethods = new ButtonWithId[listOfTrainers.informationAboutTrainer.Count];

            for (int i = 0; i < listOfTrainers.informationAboutTrainer.Count; i++) {
                butListOfMethods[i] = new ButtonWithId();
                butListOfMethods[i].Size = new Size(this.Width - 70, 50);
                butListOfMethods[i].Location = new Point(20, 50 * i + 50);
                butListOfMethods[i].BackColor = Color.Aqua;
                butListOfMethods[i].Text = listOfTrainers.informationAboutTrainer[i].lastName + " " + listOfTrainers.informationAboutTrainer[i].firstName+ " " + listOfTrainers.informationAboutTrainer[i].secondName;
                butListOfMethods[i].IdButton = listOfTrainers.informationAboutTrainer[i].idTrainer;
                Controls.Add(butListOfMethods[i]);
                butListOfMethods[i].MouseClick += new MouseEventHandler(eventOnfForAcquaListOfTrainers);
            }
        }

        public void eventOnfForAcquaListOfTrainers(object sender,EventArgs e)
        {
            id_trainer = ((ButtonWithId)(sender)).IdButton;
            this.Close();
            th = new Thread(OpenfForAcquaListOfTrainers);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void OpenfForAcquaListOfTrainers()
        {
            Application.Run(new fForAcquaintanceInformationAboutTrainer(id_trainer));
        }

        private void butBackAcquaintance_Click(object sender, EventArgs e) {
            this.Close();
            th = new Thread(OpenfForAcquaintance);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void OpenfForAcquaintance() {
            Application.Run(new fForAcquaintance());
        }
    }
}
