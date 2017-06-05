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
using SemesterSportsСlub.view.client;
using SemesterSportsСlub.view.admin;

namespace SemesterSportsСlub.view.for_all {
    public partial class fAuthorization : Form
    {
        private Thread th;
        private User typeUser;

        public fAuthorization() {
            InitializeComponent();
        }

        private void butfForAcquaintance_Click(object sender, EventArgs e) {
            this.Close();
            th = new Thread(OpenForAcquaintance);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenForAcquaintance(object obj)
        {
            Application.Run(new fForAcquaintance());
        }

        private void butSignIn_Click(object sender, EventArgs e) {
            Infrastructure.Authorization signInProgramm = new Infrastructure.Authorization(tbUserName.Text, tbPassword.Text);
            typeUser = signInProgramm.DownloadWithDb();
            try
            {
                if (signInProgramm.DownloadWithDb().type_user == "Admin")
                {
                    this.Close();
                    th = new Thread(OpenfMainForAdmin);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else if (signInProgramm.DownloadWithDb().type_user == "Client")
                {
                    this.Close();
                    th = new Thread(OpenfMainForClient);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
            catch (Exception exceptionSignIn)
            {
                MessageBox.Show("Неправильный Логин и Пароль", exceptionSignIn.ToString(), MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void OpenfMainForAdmin() {
            Application.Run(new fForAdminMainMenu(typeUser));
        }
        private void OpenfMainForClient() {
            Application.Run(new fForClientMainMenu(typeUser));
        }
    }
}
