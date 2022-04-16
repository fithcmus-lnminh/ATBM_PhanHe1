namespace PhanHe1
{
    partial class GrantRole
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
            this.grantBtn = new System.Windows.Forms.Button();
            this.listRoleCbb = new System.Windows.Forms.ComboBox();
            this.chooseUsernameLb = new System.Windows.Forms.Label();
            this.manageUserlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listPriCbb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.withAdminOption = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // grantBtn
            // 
            this.grantBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.grantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grantBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grantBtn.Location = new System.Drawing.Point(297, 324);
            this.grantBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grantBtn.Name = "grantBtn";
            this.grantBtn.Size = new System.Drawing.Size(184, 50);
            this.grantBtn.TabIndex = 44;
            this.grantBtn.Text = "GRANT";
            this.grantBtn.UseVisualStyleBackColor = false;
            this.grantBtn.Click += new System.EventHandler(this.grantBtn_Click);
            // 
            // listRoleCbb
            // 
            this.listRoleCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listRoleCbb.FormattingEnabled = true;
            this.listRoleCbb.Location = new System.Drawing.Point(335, 106);
            this.listRoleCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listRoleCbb.Name = "listRoleCbb";
            this.listRoleCbb.Size = new System.Drawing.Size(254, 28);
            this.listRoleCbb.Sorted = true;
            this.listRoleCbb.TabIndex = 42;
            // 
            // chooseUsernameLb
            // 
            this.chooseUsernameLb.AutoSize = true;
            this.chooseUsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameLb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chooseUsernameLb.Location = new System.Drawing.Point(181, 106);
            this.chooseUsernameLb.Name = "chooseUsernameLb";
            this.chooseUsernameLb.Size = new System.Drawing.Size(134, 29);
            this.chooseUsernameLb.TabIndex = 41;
            this.chooseUsernameLb.Text = "Chọn role:";
            // 
            // manageUserlabel
            // 
            this.manageUserlabel.AutoSize = true;
            this.manageUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.manageUserlabel.Location = new System.Drawing.Point(130, 32);
            this.manageUserlabel.Name = "manageUserlabel";
            this.manageUserlabel.Size = new System.Drawing.Size(521, 52);
            this.manageUserlabel.TabIndex = 40;
            this.manageUserlabel.Text = "CẤP QUYỀN CHO ROLE";
            this.manageUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(45, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Chọn quyền hệ thống:";
            // 
            // listPriCbb
            // 
            this.listPriCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listPriCbb.FormattingEnabled = true;
            this.listPriCbb.Location = new System.Drawing.Point(335, 181);
            this.listPriCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPriCbb.Name = "listPriCbb";
            this.listPriCbb.Size = new System.Drawing.Size(254, 28);
            this.listPriCbb.Sorted = true;
            this.listPriCbb.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(78, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 29);
            this.label3.TabIndex = 41;
            this.label3.Text = "With Admin Option:";
            // 
            // withAdminOption
            // 
            this.withAdminOption.AutoSize = true;
            this.withAdminOption.Location = new System.Drawing.Point(335, 256);
            this.withAdminOption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.withAdminOption.Name = "withAdminOption";
            this.withAdminOption.Size = new System.Drawing.Size(22, 21);
            this.withAdminOption.TabIndex = 45;
            this.withAdminOption.UseVisualStyleBackColor = true;
            // 
            // GrantRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.withAdminOption);
            this.Controls.Add(this.grantBtn);
            this.Controls.Add(this.listPriCbb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listRoleCbb);
            this.Controls.Add(this.chooseUsernameLb);
            this.Controls.Add(this.manageUserlabel);
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GrantRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấp quyền cho Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grantBtn;
        private System.Windows.Forms.ComboBox listRoleCbb;
        private System.Windows.Forms.Label chooseUsernameLb;
        private System.Windows.Forms.Label manageUserlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listPriCbb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox withAdminOption;
    }
}