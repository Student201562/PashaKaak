using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SemesterSportsСlub.domain;
using System.Threading;
using SemesterSportsСlub.domain.recognize;
using SemesterSportsСlub.view.client;

namespace SemesterSportsСlub.view.client {
    public partial class fForClientInWhichOneMethod : Form
    {

        private Thread th;
        private User _userClient;

        public fForClientInWhichOneMethod(int idOfMethod, object userClient)
        {
            InitializeComponent();
            this._userClient = (User)userClient;

            var recognizesNameAndDescription = new RecognizeWhichMethodic(idOfMethod);
            labelNameMethod.Text = recognizesNameAndDescription.NameMethod;
            labelDescriptionMethod.Text = recognizesNameAndDescription.DescriptionOfMethod;

        }

        private void butBackInMetodics_Click(object sender, EventArgs e) {

            this.Close();
            th = new Thread(OpenfForClientListOfMethodologies);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForClientListOfMethodologies()
        {
            Application.Run(new fForClientLIstOfMethodologies(_userClient));
        }
    }
}
