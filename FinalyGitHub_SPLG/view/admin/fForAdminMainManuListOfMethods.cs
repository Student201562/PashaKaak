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
using SemesterSportsСlub.Infrastructure;
using SemesterSportsСlub.MyControls;
using SemesterSportsСlub.view.for_all;

namespace SemesterSportsСlub.view.admin {
    public partial class fForAdminMainManuListOfMethods : Form
    {
        private static int idOfMethod;
        private User _userAdmin;

        public fForAdminMainManuListOfMethods(object userAdmin) {
            InitializeComponent();
            this._userAdmin = (User)userAdmin;
            FillOfButtons();
        }

        private void butBackAuthorization_Click(object sender, EventArgs e) {
            this.Close();
            var th = new Thread(OpenfForAdminMainMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void FillOfButtons() {
            DataBaseConnectionMethdos DataBaseConnectionMethdos = new DataBaseConnectionMethdos();

            DataBaseConnectionMethdos.AddMethods();
            ListOfMethods listOfMethods = new ListOfMethods();
            ButtonWithId[] butListOfMethods = new ButtonWithId[listOfMethods.listOfMethods.Count];

            for (int i = 0; i < listOfMethods.listOfMethods.Count(); i++) {
                butListOfMethods[i] = new ButtonWithId();
                butListOfMethods[i].Size = new Size(this.Width, 50);
                butListOfMethods[i].Location = new Point(0, 50 * i + 150);
                butListOfMethods[i].BackColor = Color.Aqua;
                butListOfMethods[i].Text = listOfMethods.listOfMethods[i]._nameMethods.ToString() + " (" + listOfMethods.listOfMethods[i]._MethodicIds +")";
                butListOfMethods[i].IdButton = listOfMethods.listOfMethods[i]._MethodicIds;
                Controls.Add(butListOfMethods[i]);
                butListOfMethods[i].MouseClick += new MouseEventHandler(fForAdminInformationOfMethod);
            }
        }

        private void fForAdminInformationOfMethod(object sender, EventArgs e)
        {
            idOfMethod =(((ButtonWithId)(sender)).IdButton);
            this.Close();
            var th = new Thread(OpenfForAdminInformationOfMethod);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForAdminInformationOfMethod()
        {
            Application.Run(new fForAdminInformationOfMethod(idOfMethod, _userAdmin));
        }

        private void OpenfForAdminMainMenu()
        {
            Application.Run(new fForAdminMainMenu(_userAdmin));
        }
        
        private void butDeletMethod_Click(object sender, EventArgs e) {
            DataBaseConnectionMethdos dataBaseConnectionMethdos = new DataBaseConnectionMethdos();

            if (!string.IsNullOrEmpty(textBoxDeleteMethod.Text) && !string.IsNullOrWhiteSpace(textBoxDeleteMethod.Text)) {
                dataBaseConnectionMethdos.DeleteMethod(textBoxDeleteMethod.Text);
                this.Close();
                var th = new Thread(OpenfForAdminMainManuListOfMethods);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

                textBoxDeleteMethod.Text = "Методика удалена";
            }
            else {
                MessageBox.Show("Если хотите удалить, заполните поле Id");
            }
        }

        private void OpenfForAdminMainManuListOfMethods()
        {
            Application.Run(new fForAdminMainManuListOfMethods(_userAdmin));
        }

        private void butAddMethod_Click(object sender, EventArgs e) {
            this.Close();
            var th = new Thread(OpenfForAdminInformationOfMethodForAddMethod);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenfForAdminInformationOfMethodForAddMethod() {
            Application.Run(new fForAdminInformationOfMethod(Int32.MaxValue, _userAdmin));
        }
    }
}
