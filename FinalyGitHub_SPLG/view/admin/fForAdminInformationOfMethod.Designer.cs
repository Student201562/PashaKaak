namespace SemesterSportsСlub.view.admin {
    partial class fForAdminInformationOfMethod {
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
            this.textBoxForEditNameMethod = new System.Windows.Forms.TextBox();
            this.textBoxForEditDiscriptionMethod = new System.Windows.Forms.TextBox();
            this.butBackInListOfMethod = new System.Windows.Forms.Button();
            this.butSaveMethod = new System.Windows.Forms.Button();
            this.butAddNewMethod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxForEditNameMethod
            // 
            this.textBoxForEditNameMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForEditNameMethod.Location = new System.Drawing.Point(12, 12);
            this.textBoxForEditNameMethod.Multiline = true;
            this.textBoxForEditNameMethod.Name = "textBoxForEditNameMethod";
            this.textBoxForEditNameMethod.Size = new System.Drawing.Size(329, 28);
            this.textBoxForEditNameMethod.TabIndex = 0;
            this.textBoxForEditNameMethod.Text = "Название методики";
            this.textBoxForEditNameMethod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxForEditDiscriptionMethod
            // 
            this.textBoxForEditDiscriptionMethod.Location = new System.Drawing.Point(12, 57);
            this.textBoxForEditDiscriptionMethod.Multiline = true;
            this.textBoxForEditDiscriptionMethod.Name = "textBoxForEditDiscriptionMethod";
            this.textBoxForEditDiscriptionMethod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxForEditDiscriptionMethod.Size = new System.Drawing.Size(329, 294);
            this.textBoxForEditDiscriptionMethod.TabIndex = 1;
            // 
            // butBackInListOfMethod
            // 
            this.butBackInListOfMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butBackInListOfMethod.Location = new System.Drawing.Point(244, 386);
            this.butBackInListOfMethod.Name = "butBackInListOfMethod";
            this.butBackInListOfMethod.Size = new System.Drawing.Size(97, 34);
            this.butBackInListOfMethod.TabIndex = 2;
            this.butBackInListOfMethod.Text = "Назад";
            this.butBackInListOfMethod.UseVisualStyleBackColor = true;
            this.butBackInListOfMethod.Click += new System.EventHandler(this.butBackInListOfMethod_Click);
            // 
            // butSaveMethod
            // 
            this.butSaveMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSaveMethod.Location = new System.Drawing.Point(12, 386);
            this.butSaveMethod.Name = "butSaveMethod";
            this.butSaveMethod.Size = new System.Drawing.Size(226, 34);
            this.butSaveMethod.TabIndex = 3;
            this.butSaveMethod.Text = "Сохранить изменения";
            this.butSaveMethod.UseVisualStyleBackColor = true;
            this.butSaveMethod.Click += new System.EventHandler(this.butSaveMethod_Click);
            // 
            // butAddNewMethod
            // 
            this.butAddNewMethod.Location = new System.Drawing.Point(13, 357);
            this.butAddNewMethod.Name = "butAddNewMethod";
            this.butAddNewMethod.Size = new System.Drawing.Size(328, 23);
            this.butAddNewMethod.TabIndex = 4;
            this.butAddNewMethod.Text = "Добавить методику";
            this.butAddNewMethod.UseVisualStyleBackColor = true;
            this.butAddNewMethod.Click += new System.EventHandler(this.butAddNewMethod_Click);
            // 
            // fForAdminInformationOfMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 432);
            this.Controls.Add(this.butAddNewMethod);
            this.Controls.Add(this.butSaveMethod);
            this.Controls.Add(this.butBackInListOfMethod);
            this.Controls.Add(this.textBoxForEditDiscriptionMethod);
            this.Controls.Add(this.textBoxForEditNameMethod);
            this.Name = "fForAdminInformationOfMethod";
            this.Text = "fForAdminInformationOfMethod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxForEditNameMethod;
        private System.Windows.Forms.TextBox textBoxForEditDiscriptionMethod;
        private System.Windows.Forms.Button butBackInListOfMethod;
        private System.Windows.Forms.Button butSaveMethod;
        private System.Windows.Forms.Button butAddNewMethod;
    }
}