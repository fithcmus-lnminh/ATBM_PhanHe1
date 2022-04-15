namespace PhanHe1
{
    partial class CreateRole
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
            this.createBtn = new System.Windows.Forms.Button();
            this.RoleNameTextbox = new System.Windows.Forms.TextBox();
            this.rolenameLb = new System.Windows.Forms.Label();
            this.manageUserlabel = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.createBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createBtn.Location = new System.Drawing.Point(198, 225);
            this.createBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(164, 40);
            this.createBtn.TabIndex = 46;
            this.createBtn.Text = "CREATE";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // RoleNameTextbox
            // 
            this.RoleNameTextbox.Location = new System.Drawing.Point(198, 101);
            this.RoleNameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoleNameTextbox.Multiline = true;
            this.RoleNameTextbox.Name = "RoleNameTextbox";
            this.RoleNameTextbox.Size = new System.Drawing.Size(313, 26);
            this.RoleNameTextbox.TabIndex = 43;
            // 
            // rolenameLb
            // 
            this.rolenameLb.AutoSize = true;
            this.rolenameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rolenameLb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rolenameLb.Location = new System.Drawing.Point(52, 101);
            this.rolenameLb.Name = "rolenameLb";
            this.rolenameLb.Size = new System.Drawing.Size(130, 29);
            this.rolenameLb.TabIndex = 42;
            this.rolenameLb.Text = "Rolename:";
            // 
            // manageUserlabel
            // 
            this.manageUserlabel.AutoSize = true;
            this.manageUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.manageUserlabel.Location = new System.Drawing.Point(177, 21);
            this.manageUserlabel.Name = "manageUserlabel";
            this.manageUserlabel.Size = new System.Drawing.Size(207, 42);
            this.manageUserlabel.TabIndex = 41;
            this.manageUserlabel.Text = "TẠO ROLE";
            this.manageUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.passwordLb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.passwordLb.Location = new System.Drawing.Point(52, 159);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(126, 29);
            this.passwordLb.TabIndex = 47;
            this.passwordLb.Text = "Password:";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(198, 159);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextbox.Multiline = true;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(313, 26);
            this.PasswordTextbox.TabIndex = 48;
            // 
            // CreateRole
            // 
            this.AcceptButton = this.createBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 293);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.RoleNameTextbox);
            this.Controls.Add(this.rolenameLb);
            this.Controls.Add(this.manageUserlabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox RoleNameTextbox;
        private System.Windows.Forms.Label rolenameLb;
        private System.Windows.Forms.Label manageUserlabel;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.TextBox PasswordTextbox;
    }
}