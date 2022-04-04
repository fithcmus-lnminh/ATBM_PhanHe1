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
            this.usernameLb = new System.Windows.Forms.Label();
            this.manageUserlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.createBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createBtn.Location = new System.Drawing.Point(223, 199);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(185, 50);
            this.createBtn.TabIndex = 46;
            this.createBtn.Text = "CREATE";
            this.createBtn.UseVisualStyleBackColor = false;
            // 
            // RoleNameTextbox
            // 
            this.RoleNameTextbox.Location = new System.Drawing.Point(223, 126);
            this.RoleNameTextbox.Multiline = true;
            this.RoleNameTextbox.Name = "RoleNameTextbox";
            this.RoleNameTextbox.Size = new System.Drawing.Size(352, 32);
            this.RoleNameTextbox.TabIndex = 43;
            // 
            // usernameLb
            // 
            this.usernameLb.AutoSize = true;
            this.usernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.usernameLb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.usernameLb.Location = new System.Drawing.Point(58, 126);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(152, 32);
            this.usernameLb.TabIndex = 42;
            this.usernameLb.Text = "Rolename:";
            // 
            // manageUserlabel
            // 
            this.manageUserlabel.AutoSize = true;
            this.manageUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.manageUserlabel.Location = new System.Drawing.Point(199, 26);
            this.manageUserlabel.Name = "manageUserlabel";
            this.manageUserlabel.Size = new System.Drawing.Size(243, 52);
            this.manageUserlabel.TabIndex = 41;
            this.manageUserlabel.Text = "TẠO ROLE";
            this.manageUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(625, 286);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.RoleNameTextbox);
            this.Controls.Add(this.usernameLb);
            this.Controls.Add(this.manageUserlabel);
            this.Name = "CreateRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox RoleNameTextbox;
        private System.Windows.Forms.Label usernameLb;
        private System.Windows.Forms.Label manageUserlabel;
    }
}