using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SemesterSportsСlub.domain;
using SemesterSportsСlub.view.client;
using SemesterSportsСlub.Infrastructure;
using SemesterSportsСlub.MyControls;

namespace SemesterSportsСlub.view.client {
    public partial class fForClientLIstOfMethodologies : Form
    {
        private Thread th;
        public static int IdMethod;
        private User _userClient;

        public fForClientLIstOfMethodologies(object userClient) {
            InitializeComponent();
            this._userClient = (User)userClient;
            FillOfButtons();
        }

        private void butBackInListOfmethodic_Click(object sender, EventArgs e) {
            this.Close();
            th = new Thread(OpenfForClientMainMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();   
        }

        private void OpenfForClientMainMenu()
        {
            Application.Run(new fForClientMainMenu(_userClient));
        }

        private void FillOfButtons()
        {
            DataBaseConnectionMethdos dataBaseConnectionMethdos = new DataBaseConnectionMethdos();

            dataBaseConnectionMethdos.AddMethods();
            ListOfMethods listOfMethods = new ListOfMethods();
            ButtonWithId[] butListOfMethods = new ButtonWithId[listOfMethods.listOfMethods.Count];

            for (int i = 0; i < listOfMethods.listOfMethods.Count(); i++) {
                butListOfMethods[i] = new ButtonWithId();
                butListOfMethods[i].Size = new Size(this.Width, 50);
                butListOfMethods[i].Location = new Point(0,50*i + 50);
                butListOfMethods[i].BackColor = Color.Aqua;
                butListOfMethods[i].Text = listOfMethods.listOfMethods[i]._nameMethods.ToString();
                butListOfMethods[i].IdButton = listOfMethods.listOfMethods[i]._MethodicIds;
                Controls.Add(butListOfMethods[i]);
                butListOfMethods[i].MouseClick += new MouseEventHandler(OpenButInfForClientListOfMethods);
            }
        }

        private void OpenButInfForClientListOfMethods(object sender, EventArgs e)
        {
            IdMethod = (((ButtonWithId)(sender)).IdButton);
            this.Close();
            th = new Thread(OpenfForClientInWhichOneMethod);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForClientInWhichOneMethod()
        {
            Application.Run(new fForClientInWhichOneMethod(IdMethod, _userClient));
        }
    }
}
