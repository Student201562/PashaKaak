namespace SemesterSportsСlub.view.admin {
    partial class fForAdminMainMenu {
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
            this.butBackAuthorization = new System.Windows.Forms.Button();
            this.butEditMenu = new System.Windows.Forms.Button();
            this.butEditPriceList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butBackAuthorization
            // 
            this.butBackAuthorization.Location = new System.Drawing.Point(12, 12);
            this.butBackAuthorization.Name = "butBackAuthorization";
            this.butBackAuthorization.Size = new System.Drawing.Size(75, 23);
            this.butBackAuthorization.TabIndex = 7;
            this.butBackAuthorization.Text = "Назад";
            this.butBackAuthorization.UseVisualStyleBackColor = true;
            this.butBackAuthorization.Click += new System.EventHandler(this.butBackAuthorization_Click);
            // 
            // butEditMenu
            // 
            this.butEditMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butEditMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEditMenu.Location = new System.Drawing.Point(12, 119);
            this.butEditMenu.Name = "butEditMenu";
            this.butEditMenu.Size = new System.Drawing.Size(243, 30);
            this.butEditMenu.TabIndex = 6;
            this.butEditMenu.Text = "Редактировать методики";
            this.butEditMenu.UseVisualStyleBackColor = true;
            this.butEditMenu.Click += new System.EventHandler(this.butEditMenu_Click);
            // 
            // butEditPriceList
            // 
            this.butEditPriceList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butEditPriceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEditPriceList.Location = new System.Drawing.Point(12, 155);
            this.butEditPriceList.Name = "butEditPriceList";
            this.butEditPriceList.Size = new System.Drawing.Size(243, 30);
            this.butEditPriceList.TabIndex = 8;
            this.butEditPriceList.Text = "Редактировать прайс лист";
            this.butEditPriceList.UseVisualStyleBackColor = true;
            this.butEditPriceList.Click += new System.EventHandler(this.butEditPriceList_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Редактировать тренеров";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fForAdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butEditPriceList);
            this.Controls.Add(this.butBackAuthorization);
            this.Controls.Add(this.butEditMenu);
            this.Name = "fForAdminMainMenu";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butBackAuthorization;
        private System.Windows.Forms.Button butEditMenu;
        private System.Windows.Forms.Button butEditPriceList;
        private System.Windows.Forms.Button button1;
    }
}