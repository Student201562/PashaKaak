namespace SemesterSportsСlub.view.for_all{
    partial class fAuthorization {
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
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.butfForAcquaintance = new System.Windows.Forms.Button();
            this.butSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.AutoSize = true;
            this.labelAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthorization.Location = new System.Drawing.Point(69, 135);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(129, 24);
            this.labelAuthorization.TabIndex = 0;
            this.labelAuthorization.Text = "Авторизация";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(43, 171);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(180, 20);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Text = "AdminSergey";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(43, 197);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(180, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "1234";
            // 
            // butfForAcquaintance
            // 
            this.butfForAcquaintance.Location = new System.Drawing.Point(13, 13);
            this.butfForAcquaintance.Name = "butfForAcquaintance";
            this.butfForAcquaintance.Size = new System.Drawing.Size(75, 23);
            this.butfForAcquaintance.TabIndex = 4;
            this.butfForAcquaintance.Text = "Назад";
            this.butfForAcquaintance.UseVisualStyleBackColor = true;
            this.butfForAcquaintance.Click += new System.EventHandler(this.butfForAcquaintance_Click);
            // 
            // butSignIn
            // 
            this.butSignIn.Location = new System.Drawing.Point(92, 223);
            this.butSignIn.Name = "butSignIn";
            this.butSignIn.Size = new System.Drawing.Size(75, 23);
            this.butSignIn.TabIndex = 5;
            this.butSignIn.Text = "Войти";
            this.butSignIn.UseVisualStyleBackColor = true;
            this.butSignIn.Click += new System.EventHandler(this.butSignIn_Click);
            // 
            // fAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 423);
            this.Controls.Add(this.butSignIn);
            this.Controls.Add(this.butfForAcquaintance);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.labelAuthorization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fAuthorization";
            this.Text = "fAuthorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button butfForAcquaintance;
        private System.Windows.Forms.Button butSignIn;
    }
}