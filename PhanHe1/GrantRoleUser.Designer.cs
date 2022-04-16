namespace PhanHe1
{
    partial class GrantRoleUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrantRoleUser));
            this.grantBtn = new System.Windows.Forms.Button();
            this.listUserCbb = new System.Windows.Forms.ComboBox();
            this.chooseUsernameLb = new System.Windows.Forms.Label();
            this.manageUserlabel = new System.Windows.Forms.Label();
            this.listRoleCbb = new System.Windows.Forms.ComboBox();
            this.chooseRoleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grantBtn
            // 
            this.grantBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.grantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grantBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grantBtn.Location = new System.Drawing.Point(253, 200);
            this.grantBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grantBtn.Name = "grantBtn";
            this.grantBtn.Size = new System.Drawing.Size(164, 40);
            this.grantBtn.TabIndex = 44;
            this.grantBtn.Text = "GRANT";
            this.grantBtn.UseVisualStyleBackColor = false;
            this.grantBtn.Click += new System.EventHandler(this.grantBtn_Click);
            // 
            // listUserCbb
            // 
            this.listUserCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listUserCbb.FormattingEnabled = true;
            this.listUserCbb.Location = new System.Drawing.Point(331, 97);
            this.listUserCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listUserCbb.Name = "listUserCbb";
            this.listUserCbb.Size = new System.Drawing.Size(226, 24);
            this.listUserCbb.Sorted = true;
            this.listUserCbb.TabIndex = 42;
            // 
            // chooseUsernameLb
            // 
            this.chooseUsernameLb.AutoSize = true;
            this.chooseUsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameLb.Location = new System.Drawing.Point(124, 97);
            this.chooseUsernameLb.Name = "chooseUsernameLb";
            this.chooseUsernameLb.Size = new System.Drawing.Size(184, 25);
            this.chooseUsernameLb.TabIndex = 41;
            this.chooseUsernameLb.Text = "Chọn người dùng:";
            // 
            // manageUserlabel
            // 
            this.manageUserlabel.AutoSize = true;
            this.manageUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.manageUserlabel.Location = new System.Drawing.Point(50, 22);
            this.manageUserlabel.Name = "manageUserlabel";
            this.manageUserlabel.Size = new System.Drawing.Size(551, 42);
            this.manageUserlabel.TabIndex = 40;
            this.manageUserlabel.Text = "CẤP ROLE CHO NGƯỜI DÙNG";
            this.manageUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listRoleCbb
            // 
            this.listRoleCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listRoleCbb.FormattingEnabled = true;
            this.listRoleCbb.Location = new System.Drawing.Point(331, 149);
            this.listRoleCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listRoleCbb.Name = "listRoleCbb";
            this.listRoleCbb.Size = new System.Drawing.Size(226, 24);
            this.listRoleCbb.Sorted = true;
            this.listRoleCbb.TabIndex = 46;
            // 
            // chooseRoleLabel
            // 
            this.chooseRoleLabel.AutoSize = true;
            this.chooseRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseRoleLabel.Location = new System.Drawing.Point(198, 149);
            this.chooseRoleLabel.Name = "chooseRoleLabel";
            this.chooseRoleLabel.Size = new System.Drawing.Size(113, 25);
            this.chooseRoleLabel.TabIndex = 45;
            this.chooseRoleLabel.Text = "Chọn role:";
            // 
            // GrantRoleUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 274);
            this.Controls.Add(this.listRoleCbb);
            this.Controls.Add(this.chooseRoleLabel);
            this.Controls.Add(this.grantBtn);
            this.Controls.Add(this.listUserCbb);
            this.Controls.Add(this.chooseUsernameLb);
            this.Controls.Add(this.manageUserlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GrantRoleUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấp Role cho người dùng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grantBtn;
        private System.Windows.Forms.ComboBox listUserCbb;
        private System.Windows.Forms.Label chooseUsernameLb;
        private System.Windows.Forms.Label manageUserlabel;
        private System.Windows.Forms.ComboBox listRoleCbb;
        private System.Windows.Forms.Label chooseRoleLabel;
    }
}