﻿namespace MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls
{
    partial class ctrlGenralApplicationInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlDrivingLicenseApplicationInfo1 = new MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls.ctrlDrivingLicenseApplicationInfo();
            this.ctrlApplicationBasicProccessInfo1 = new MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls.ctrlApplicationBasicProccessInfo();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
            this.panel1.Controls.Add(this.ctrlApplicationBasicProccessInfo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 571);
            this.panel1.TabIndex = 0;
           
            // ctrlDrivingLicenseApplicationInfo1
            // 
            this.ctrlDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(10, 250);
            this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(995, 233);
            this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 1;
            // 
            // ctrlApplicationBasicProccessInfo1
            // 
            this.ctrlApplicationBasicProccessInfo1.Location = new System.Drawing.Point(73, 36);
            this.ctrlApplicationBasicProccessInfo1.Name = "ctrlApplicationBasicProccessInfo1";
            this.ctrlApplicationBasicProccessInfo1.Size = new System.Drawing.Size(869, 194);
            this.ctrlApplicationBasicProccessInfo1.TabIndex = 0;
            // 
            // ctrlGenralApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ctrlGenralApplicationInfo";
            this.Size = new System.Drawing.Size(1015, 571);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ctrlApplicationBasicProccessInfo ctrlApplicationBasicProccessInfo1;
        private ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
    }
}
