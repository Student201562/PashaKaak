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
using SemesterSportsСlub.domain.recognize;
using SemesterSportsСlub.Infrastructure;
using SemesterSportsСlub.view.client;

namespace SemesterSportsСlub.view.admin {
    public partial class fForAdminInformationOfMethod : Form
    {
        private int idMethod;
        private User _userAdmin;

        public fForAdminInformationOfMethod(int idOfMethod, object userAdmin)
        {
            this.idMethod = idOfMethod;
            InitializeComponent();
            this._userAdmin = (User) userAdmin;
            RecognizeWhichMethodic recognizeWhichMethodic = new RecognizeWhichMethodic(idOfMethod);
            textBoxForEditNameMethod.Text = recognizeWhichMethodic.NameMethod;
            textBoxForEditDiscriptionMethod.Text = recognizeWhichMethodic.DescriptionOfMethod;
        }

        private void butBackInListOfMethod_Click(object sender, EventArgs e) {
            this.Close();
            var th = new Thread(OpenfForAdminMainManuListOfMethods);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForAdminMainManuListOfMethods() {
            Application.Run(new fForAdminMainManuListOfMethods(_userAdmin));
        }

        private void butSaveMethod_Click(object sender, EventArgs e) {
            DataBaseConnectionMethdos dataBaseConnectionMethdos = new DataBaseConnectionMethdos();

            if (!string.IsNullOrEmpty(textBoxForEditNameMethod.Text) && !string.IsNullOrWhiteSpace(textBoxForEditNameMethod.Text) &&
                !string.IsNullOrEmpty(textBoxForEditDiscriptionMethod.Text) && !string.IsNullOrWhiteSpace(textBoxForEditDiscriptionMethod.Text)) {
                dataBaseConnectionMethdos.ChangedMethod(idMethod.ToString(), textBoxForEditNameMethod.Text, textBoxForEditDiscriptionMethod.Text);
                    MessageBox.Show("Данные изменены!");
                }
            else {
                MessageBox.Show("Для изменения метода нельзя оставлять поля незаполнеными");
            }
        }

        private void butAddNewMethod_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(textBoxForEditNameMethod.Text) &&
                !string.IsNullOrWhiteSpace(textBoxForEditNameMethod.Text) && !string.IsNullOrEmpty(textBoxForEditDiscriptionMethod.Text) && (!string.IsNullOrWhiteSpace(textBoxForEditDiscriptionMethod.Text)))
            {
                  DataBaseConnectionMethdos dataBaseConnectionMethdos = new DataBaseConnectionMethdos();
                  dataBaseConnectionMethdos.AddNewMethod(textBoxForEditNameMethod.Text, textBoxForEditDiscriptionMethod.Text);
                MessageBox.Show("Методика добавлена!");
            }
            else {
                MessageBox.Show("Для изменения метода нельзя оставлять поля незаполнеными");
            }
        }
    }
}
