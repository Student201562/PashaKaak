namespace SemesterSportsСlub.view.for_all {
    partial class fForAcquaintanceListOfTrainers {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.butBackAcquaintance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butBackAcquaintance
            // 
            this.butBackAcquaintance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butBackAcquaintance.Location = new System.Drawing.Point(12, 12);
            this.butBackAcquaintance.Name = "butBackAcquaintance";
            this.butBackAcquaintance.Size = new System.Drawing.Size(328, 32);
            this.butBackAcquaintance.TabIndex = 1;
            this.butBackAcquaintance.Text = "Назад";
            this.butBackAcquaintance.UseVisualStyleBackColor = true;
            this.butBackAcquaintance.Click += new System.EventHandler(this.butBackAcquaintance_Click);
            // 
            // fForAcquaintanceListOfTrainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 432);
            this.Controls.Add(this.butBackAcquaintance);
            this.Name = "fForAcquaintanceListOfTrainers";
            this.Text = "fForAcquaintanceListOfTrainers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butBackAcquaintance;
    }
}