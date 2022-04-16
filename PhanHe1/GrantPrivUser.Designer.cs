namespace PhanHe1
{
    partial class GrantPrivUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrantPrivUser));
            this.manageUserlabel = new System.Windows.Forms.Label();
            this.listUserCbb = new System.Windows.Forms.ComboBox();
            this.chooseUsernameLb = new System.Windows.Forms.Label();
            this.grantBtn = new System.Windows.Forms.Button();
            this.listPriCbb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.withAdminOption = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // manageUserlabel
            // 
            this.manageUserlabel.AutoSize = true;
            this.manageUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.manageUserlabel.Location = new System.Drawing.Point(65, 26);
            this.manageUserlabel.Name = "manageUserlabel";
            this.manageUserlabel.Size = new System.Drawing.Size(688, 52);
            this.manageUserlabel.TabIndex = 2;
            this.manageUserlabel.Text = "CẤP QUYỀN CHO NGƯỜI DÙNG";
            this.manageUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listUserCbb
            // 
            this.listUserCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listUserCbb.FormattingEnabled = true;
            this.listUserCbb.Location = new System.Drawing.Point(381, 100);
            this.listUserCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listUserCbb.Name = "listUserCbb";
            this.listUserCbb.Size = new System.Drawing.Size(254, 28);
            this.listUserCbb.Sorted = true;
            this.listUserCbb.TabIndex = 37;
            // 
            // chooseUsernameLb
            // 
            this.chooseUsernameLb.AutoSize = true;
            this.chooseUsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameLb.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chooseUsernameLb.Location = new System.Drawing.Point(142, 99);
            this.chooseUsernameLb.Name = "chooseUsernameLb";
            this.chooseUsernameLb.Size = new System.Drawing.Size(218, 29);
            this.chooseUsernameLb.TabIndex = 36;
            this.chooseUsernameLb.Text = "Chọn người dùng:";
            // 
            // grantBtn
            // 
            this.grantBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.grantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grantBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grantBtn.Location = new System.Drawing.Point(308, 317);
            this.grantBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grantBtn.Name = "grantBtn";
            this.grantBtn.Size = new System.Drawing.Size(184, 50);
            this.grantBtn.TabIndex = 39;
            this.grantBtn.Text = "GRANT";
            this.grantBtn.UseVisualStyleBackColor = false;
            this.grantBtn.Click += new System.EventHandler(this.grantBtn_Click);
            // 
            // listPriCbb
            // 
            this.listPriCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listPriCbb.FormattingEnabled = true;
            this.listPriCbb.Location = new System.Drawing.Point(381, 176);
            this.listPriCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPriCbb.Name = "listPriCbb";
            this.listPriCbb.Size = new System.Drawing.Size(254, 28);
            this.listPriCbb.Sorted = true;
            this.listPriCbb.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(94, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Chọn quyền hệ thống:";
            // 
            // withAdminOption
            // 
            this.withAdminOption.AutoSize = true;
            this.withAdminOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withAdminOption.Location = new System.Drawing.Point(392, 255);
            this.withAdminOption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.withAdminOption.Name = "withAdminOption";
            this.withAdminOption.Size = new System.Drawing.Size(22, 21);
            this.withAdminOption.TabIndex = 40;
            this.withAdminOption.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(124, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "With Admin Option:";
            // 
            // GrantPrivUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.withAdminOption);
            this.Controls.Add(this.grantBtn);
            this.Controls.Add(this.listPriCbb);
            this.Controls.Add(this.listUserCbb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseUsernameLb);
            this.Controls.Add(this.manageUserlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GrantPrivUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấp quyền cho người dùng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manageUserlabel;
        private System.Windows.Forms.ComboBox listUserCbb;
        private System.Windows.Forms.Label chooseUsernameLb;
        private System.Windows.Forms.Button grantBtn;
        private System.Windows.Forms.ComboBox listPriCbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox withAdminOption;
        private System.Windows.Forms.Label label2;
    }
}