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
using SemesterSportsСlub.view.admin;
using SemesterSportsСlub.Infrastructure;
using SemesterSportsСlub.view.for_all;

namespace SemesterSportsСlub.view.admin {
    public partial class fForAdminMainMenu : Form
    {
        private User _userAdmin;
        public fForAdminMainMenu(object typeUser)
        {
            InitializeComponent();
            this._userAdmin = (User)typeUser;
        }

        private void butBackAuthorization_Click(object sender, EventArgs e) {
            this.Close();
            var th = new Thread(OpenfForAcquaintance);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForAcquaintance()
        {
            Application.Run(new fForAcquaintance());
        }

        private void butEditMenu_Click(object sender, EventArgs e) {
            this.Close();
            var th = new Thread(OpenfForAdminMainMenuMethods);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForAdminMainMenuMethods() {
            Application.Run(new fForAdminMainManuListOfMethods(_userAdmin));
        }

        private void butEditPriceList_Click(object sender, EventArgs e) {
            this.Close();
            var th = new Thread(OpenfForAdminEditPriceList);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForAdminEditPriceList() {
            Application.Run(new fForAdminEditPriceList(_userAdmin));
        }
    }
}
