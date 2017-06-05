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
using SemesterSportsСlub.Infrastructure;
using SemesterSportsСlub.view.for_all;

namespace SemesterSportsСlub.view.client {
    public partial class fForClientMainMenu : Form
    {
        private Thread th;
        private User _userClient;
        public fForClientMainMenu(object user_Client) {
            InitializeComponent();
            this._userClient = (User)user_Client;
        }

        private void butListOFMethodologies_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenfForClientListOfMethodologies);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForClientListOfMethodologies()
        {
            Application.Run(new fForClientLIstOfMethodologies(_userClient));
        }

        private void butBackForAcquaintance_Click(object sender, EventArgs e) {
            this.Close();
            th = new Thread(OpenfForAcquaintance);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForAcquaintance() {
            Application.Run(new fForAcquaintance());
        }
    }
}
