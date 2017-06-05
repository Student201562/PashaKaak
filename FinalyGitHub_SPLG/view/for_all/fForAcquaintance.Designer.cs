namespace SemesterSportsСlub.view.for_all {
    partial class fForAcquaintance {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.butAuthorization = new System.Windows.Forms.Button();
            this.butHallList = new System.Windows.Forms.Button();
            this.butTrainerList = new System.Windows.Forms.Button();
            this.butPriceList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butAuthorization
            // 
            this.butAuthorization.Location = new System.Drawing.Point(12, 12);
            this.butAuthorization.Name = "butAuthorization";
            this.butAuthorization.Size = new System.Drawing.Size(99, 23);
            this.butAuthorization.TabIndex = 0;
            this.butAuthorization.Text = "Авторизация";
            this.butAuthorization.UseVisualStyleBackColor = true;
            this.butAuthorization.Click += new System.EventHandler(this.butAuthorization_Click);
            // 
            // butHallList
            // 
            this.butHallList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butHallList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butHallList.Location = new System.Drawing.Point(3, 229);
            this.butHallList.Name = "butHallList";
            this.butHallList.Size = new System.Drawing.Size(255, 41);
            this.butHallList.TabIndex = 1;
            this.butHallList.Text = "Список залов";
            this.butHallList.UseVisualStyleBackColor = true;
            // 
            // butTrainerList
            // 
            this.butTrainerList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butTrainerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butTrainerList.Location = new System.Drawing.Point(3, 188);
            this.butTrainerList.Name = "butTrainerList";
            this.butTrainerList.Size = new System.Drawing.Size(255, 41);
            this.butTrainerList.TabIndex = 2;
            this.butTrainerList.Text = "Список тренеров";
            this.butTrainerList.UseVisualStyleBackColor = true;
            this.butTrainerList.Click += new System.EventHandler(this.butTrainerList_Click);
            // 
            // butPriceList
            // 
            this.butPriceList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butPriceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butPriceList.Location = new System.Drawing.Point(3, 147);
            this.butPriceList.Name = "butPriceList";
            this.butPriceList.Size = new System.Drawing.Size(255, 41);
            this.butPriceList.TabIndex = 3;
            this.butPriceList.Text = "Прайс лист";
            this.butPriceList.UseVisualStyleBackColor = true;
            this.butPriceList.Click += new System.EventHandler(this.butPriceList_Click);
            // 
            // fForAcquaintance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 419);
            this.Controls.Add(this.butPriceList);
            this.Controls.Add(this.butTrainerList);
            this.Controls.Add(this.butHallList);
            this.Controls.Add(this.butAuthorization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fForAcquaintance";
            this.Text = "Для ознакомления";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butAuthorization;
        private System.Windows.Forms.Button butHallList;
        private System.Windows.Forms.Button butTrainerList;
        private System.Windows.Forms.Button butPriceList;
    }
}

