using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SemesterSportsСlub.domain.recognize;

namespace SemesterSportsСlub.view.for_all {
    public partial class fForAcquaintanceInformationAboutTrainer : Form {
        private Thread th;

        public fForAcquaintanceInformationAboutTrainer(int id_trainer) {
            InitializeComponent();
            RecognizeWhichTrainers recognizeWhichTrainers = new RecognizeWhichTrainers(id_trainer);
            var request = WebRequest.Create(recognizeWhichTrainers.photo_trainer);
            
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream()) {
                pictureBoxPhotoTrainer.Image = Bitmap.FromStream(stream);
            }
            labelLastNameTrainer.Text = recognizeWhichTrainers.lastName + " " + recognizeWhichTrainers.firstName;
            textBoxDescriptionTrainer.Text = recognizeWhichTrainers.discriptionOfTrainer;
            labelCountOfClient.Text = recognizeWhichTrainers.countOfClient.ToString();
        }

        private void butBackInfforAcquaintanceListOfTrainer_Click(object sender, EventArgs e) {
            this.Close();
            th = new Thread(OpenfForAcquaintanceListOfTrainers);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenfForAcquaintanceListOfTrainers()
        {
            Application.Run(new fForAcquaintanceListOfTrainers());
        }
    }
}
