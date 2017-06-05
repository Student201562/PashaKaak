namespace SemesterSportsСlub.view.admin {
    partial class fForAdminMainManuListOfMethods {
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
            this.butBackMainMenuAdmin = new System.Windows.Forms.Button();
            this.butDeletMethod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDeleteMethod = new System.Windows.Forms.TextBox();
            this.butAddMethod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butBackMainMenuAdmin
            // 
            this.butBackMainMenuAdmin.Location = new System.Drawing.Point(16, 13);
            this.butBackMainMenuAdmin.Name = "butBackMainMenuAdmin";
            this.butBackMainMenuAdmin.Size = new System.Drawing.Size(75, 75);
            this.butBackMainMenuAdmin.TabIndex = 5;
            this.butBackMainMenuAdmin.Text = "Назад";
            this.butBackMainMenuAdmin.UseVisualStyleBackColor = true;
            this.butBackMainMenuAdmin.Click += new System.EventHandler(this.butBackAuthorization_Click);
            // 
            // butDeletMethod
            // 
            this.butDeletMethod.Location = new System.Drawing.Point(138, 65);
            this.butDeletMethod.Name = "butDeletMethod";
            this.butDeletMethod.Size = new System.Drawing.Size(75, 23);
            this.butDeletMethod.TabIndex = 6;
            this.butDeletMethod.Text = "Удалить";
            this.butDeletMethod.UseVisualStyleBackColor = true;
            this.butDeletMethod.Click += new System.EventHandler(this.butDeletMethod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Удалить по ID_method";
            // 
            // textBoxDeleteMethod
            // 
            this.textBoxDeleteMethod.Location = new System.Drawing.Point(121, 39);
            this.textBoxDeleteMethod.Name = "textBoxDeleteMethod";
            this.textBoxDeleteMethod.Size = new System.Drawing.Size(117, 20);
            this.textBoxDeleteMethod.TabIndex = 8;
            this.textBoxDeleteMethod.Text = "Id";
            // 
            // butAddMethod
            // 
            this.butAddMethod.Location = new System.Drawing.Point(13, 105);
            this.butAddMethod.Name = "butAddMethod";
            this.butAddMethod.Size = new System.Drawing.Size(249, 23);
            this.butAddMethod.TabIndex = 9;
            this.butAddMethod.Text = "Добавить методику";
            this.butAddMethod.UseVisualStyleBackColor = true;
            this.butAddMethod.Click += new System.EventHandler(this.butAddMethod_Click);
            // 
            // fForAdminMainManuListOfMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(274, 431);
            this.Controls.Add(this.butAddMethod);
            this.Controls.Add(this.textBoxDeleteMethod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDeletMethod);
            this.Controls.Add(this.butBackMainMenuAdmin);
            this.Name = "fForAdminMainManuListOfMethods";
            this.Text = "fForAdminMainManuMethod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butBackMainMenuAdmin;
        private System.Windows.Forms.Button butDeletMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDeleteMethod;
        private System.Windows.Forms.Button butAddMethod;
    }
}