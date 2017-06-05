namespace SemesterSportsСlub.view.client {
    partial class fForClientInWhichOneMethod {
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
            this.panelForDescription = new System.Windows.Forms.Panel();
            this.labelDescriptionMethod = new System.Windows.Forms.Label();
            this.labelNameMethod = new System.Windows.Forms.Label();
            this.butBackInMetodics = new System.Windows.Forms.Button();
            this.panelForDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForDescription
            // 
            this.panelForDescription.AutoScroll = true;
            this.panelForDescription.Controls.Add(this.labelDescriptionMethod);
            this.panelForDescription.Location = new System.Drawing.Point(12, 44);
            this.panelForDescription.Name = "panelForDescription";
            this.panelForDescription.Size = new System.Drawing.Size(325, 337);
            this.panelForDescription.TabIndex = 1;
            // 
            // labelDescriptionMethod
            // 
            this.labelDescriptionMethod.AutoSize = true;
            this.labelDescriptionMethod.Location = new System.Drawing.Point(3, 4);
            this.labelDescriptionMethod.MaximumSize = new System.Drawing.Size(300, 0);
            this.labelDescriptionMethod.Name = "labelDescriptionMethod";
            this.labelDescriptionMethod.Size = new System.Drawing.Size(35, 13);
            this.labelDescriptionMethod.TabIndex = 0;
            this.labelDescriptionMethod.Text = "label1";
            // 
            // labelNameMethod
            // 
            this.labelNameMethod.AutoSize = true;
            this.labelNameMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameMethod.Location = new System.Drawing.Point(13, 9);
            this.labelNameMethod.Name = "labelNameMethod";
            this.labelNameMethod.Size = new System.Drawing.Size(51, 20);
            this.labelNameMethod.TabIndex = 2;
            this.labelNameMethod.Text = "label1";
            // 
            // butBackInMetodics
            // 
            this.butBackInMetodics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.butBackInMetodics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butBackInMetodics.Location = new System.Drawing.Point(0, 394);
            this.butBackInMetodics.Name = "butBackInMetodics";
            this.butBackInMetodics.Size = new System.Drawing.Size(349, 34);
            this.butBackInMetodics.TabIndex = 3;
            this.butBackInMetodics.Text = "Назад";
            this.butBackInMetodics.UseVisualStyleBackColor = true;
            this.butBackInMetodics.Click += new System.EventHandler(this.butBackInMetodics_Click);
            // 
            // fForClientInWhichOneMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(349, 428);
            this.Controls.Add(this.butBackInMetodics);
            this.Controls.Add(this.labelNameMethod);
            this.Controls.Add(this.panelForDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fForClientInWhichOneMethod";
            this.Text = "Описание метода";
            this.panelForDescription.ResumeLayout(false);
            this.panelForDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelForDescription;
        private System.Windows.Forms.Label labelNameMethod;
        private System.Windows.Forms.Label labelDescriptionMethod;
        private System.Windows.Forms.Button butBackInMetodics;
    }
}