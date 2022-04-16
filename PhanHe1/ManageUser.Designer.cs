namespace PhanHe1
{
    partial class ManageUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUser));
            this.manageUserlabel = new System.Windows.Forms.Label();
            this.listUserBtn = new System.Windows.Forms.Button();
            this.userInfoBtn = new System.Windows.Forms.Button();
            this.grantPrivUserBtn = new System.Windows.Forms.Button();
            this.revokePrivUserBtn = new System.Windows.Forms.Button();
            this.grantRoleUserBtn = new System.Windows.Forms.Button();
            this.createUserBtn = new System.Windows.Forms.Button();
            this.deleteUserBtn = new System.Windows.Forms.Button();
            this.updateUserBtn = new System.Windows.Forms.Button();
            this.updatePrivUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageUserlabel
            // 
            this.manageUserlabel.AutoSize = true;
            this.manageUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.manageUserlabel.Location = new System.Drawing.Point(239, 44);
            this.manageUserlabel.Name = "manageUserlabel";
            this.manageUserlabel.Size = new System.Drawing.Size(512, 52);
            this.manageUserlabel.TabIndex = 1;
            this.manageUserlabel.Text = "QUẢN LÝ NGƯỜI DÙNG";
            this.manageUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listUserBtn
            // 
            this.listUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.listUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listUserBtn.Location = new System.Drawing.Point(70, 137);
            this.listUserBtn.Name = "listUserBtn";
            this.listUserBtn.Size = new System.Drawing.Size(262, 151);
            this.listUserBtn.TabIndex = 2;
            this.listUserBtn.Text = "Xem danh sách người dùng";
            this.listUserBtn.UseVisualStyleBackColor = false;
            this.listUserBtn.Click += new System.EventHandler(this.listUserBtn_Click);
            // 
            // userInfoBtn
            // 
            this.userInfoBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.userInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.userInfoBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userInfoBtn.Location = new System.Drawing.Point(374, 137);
            this.userInfoBtn.Name = "userInfoBtn";
            this.userInfoBtn.Size = new System.Drawing.Size(262, 151);
            this.userInfoBtn.TabIndex = 3;
            this.userInfoBtn.Text = "Xem thông tin quyền người dùng";
            this.userInfoBtn.UseVisualStyleBackColor = false;
            this.userInfoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // grantPrivUserBtn
            // 
            this.grantPrivUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.grantPrivUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grantPrivUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grantPrivUserBtn.Location = new System.Drawing.Point(659, 137);
            this.grantPrivUserBtn.Name = "grantPrivUserBtn";
            this.grantPrivUserBtn.Size = new System.Drawing.Size(262, 151);
            this.grantPrivUserBtn.TabIndex = 4;
            this.grantPrivUserBtn.Text = "Cấp quyền người dùng";
            this.grantPrivUserBtn.UseVisualStyleBackColor = false;
            this.grantPrivUserBtn.Click += new System.EventHandler(this.grantPrivUserBtn_Click);
            // 
            // revokePrivUserBtn
            // 
            this.revokePrivUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.revokePrivUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.revokePrivUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.revokePrivUserBtn.Location = new System.Drawing.Point(70, 341);
            this.revokePrivUserBtn.Name = "revokePrivUserBtn";
            this.revokePrivUserBtn.Size = new System.Drawing.Size(262, 151);
            this.revokePrivUserBtn.TabIndex = 5;
            this.revokePrivUserBtn.Text = "Thu hồi quyền người dùng";
            this.revokePrivUserBtn.UseVisualStyleBackColor = false;
            this.revokePrivUserBtn.Click += new System.EventHandler(this.revokePrivUserBtn_Click);
            // 
            // grantRoleUserBtn
            // 
            this.grantRoleUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.grantRoleUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grantRoleUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grantRoleUserBtn.Location = new System.Drawing.Point(659, 341);
            this.grantRoleUserBtn.Name = "grantRoleUserBtn";
            this.grantRoleUserBtn.Size = new System.Drawing.Size(262, 151);
            this.grantRoleUserBtn.TabIndex = 6;
            this.grantRoleUserBtn.Text = "Cấp role cho người dùng";
            this.grantRoleUserBtn.UseVisualStyleBackColor = false;
            this.grantRoleUserBtn.Click += new System.EventHandler(this.grantRoleUserBtn_Click);
            // 
            // createUserBtn
            // 
            this.createUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.createUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.createUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createUserBtn.Location = new System.Drawing.Point(70, 548);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Size = new System.Drawing.Size(262, 151);
            this.createUserBtn.TabIndex = 8;
            this.createUserBtn.Text = "Tạo người dùng";
            this.createUserBtn.UseVisualStyleBackColor = false;
            this.createUserBtn.Click += new System.EventHandler(this.createUserBtn_Click);
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deleteUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteUserBtn.Location = new System.Drawing.Point(365, 548);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(271, 151);
            this.deleteUserBtn.TabIndex = 9;
            this.deleteUserBtn.Text = "Xóa người dùng";
            this.deleteUserBtn.UseVisualStyleBackColor = false;
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // updateUserBtn
            // 
            this.updateUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.updateUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.updateUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateUserBtn.Location = new System.Drawing.Point(659, 548);
            this.updateUserBtn.Name = "updateUserBtn";
            this.updateUserBtn.Size = new System.Drawing.Size(262, 151);
            this.updateUserBtn.TabIndex = 10;
            this.updateUserBtn.Text = "Sửa người dùng";
            this.updateUserBtn.UseVisualStyleBackColor = false;
            this.updateUserBtn.Click += new System.EventHandler(this.updateUserBtn_Click);
            // 
            // updatePrivUserBtn
            // 
            this.updatePrivUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.updatePrivUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.updatePrivUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updatePrivUserBtn.Location = new System.Drawing.Point(374, 341);
            this.updatePrivUserBtn.Name = "updatePrivUserBtn";
            this.updatePrivUserBtn.Size = new System.Drawing.Size(262, 151);
            this.updatePrivUserBtn.TabIndex = 11;
            this.updatePrivUserBtn.Text = "Chỉnh sửa quyền người dùng";
            this.updatePrivUserBtn.UseVisualStyleBackColor = false;
            this.updatePrivUserBtn.Click += new System.EventHandler(this.updatePrivUserBtn_Click);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 767);
            this.Controls.Add(this.updatePrivUserBtn);
            this.Controls.Add(this.updateUserBtn);
            this.Controls.Add(this.deleteUserBtn);
            this.Controls.Add(this.createUserBtn);
            this.Controls.Add(this.grantRoleUserBtn);
            this.Controls.Add(this.revokePrivUserBtn);
            this.Controls.Add(this.grantPrivUserBtn);
            this.Controls.Add(this.userInfoBtn);
            this.Controls.Add(this.listUserBtn);
            this.Controls.Add(this.manageUserlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUser";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manageUserlabel;
        private System.Windows.Forms.Button listUserBtn;
        private System.Windows.Forms.Button userInfoBtn;
        private System.Windows.Forms.Button grantPrivUserBtn;
        private System.Windows.Forms.Button revokePrivUserBtn;
        private System.Windows.Forms.Button grantRoleUserBtn;
        private System.Windows.Forms.Button createUserBtn;
        private System.Windows.Forms.Button deleteUserBtn;
        private System.Windows.Forms.Button updateUserBtn;
        private System.Windows.Forms.Button updatePrivUserBtn;
    }
}