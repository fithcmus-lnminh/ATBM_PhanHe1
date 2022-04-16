namespace PhanHe1
{
    partial class UpdateRole
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
            this.label2 = new System.Windows.Forms.Label();
            this.updateRoleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.updateRoleCbb = new System.Windows.Forms.ComboBox();
            this.chooseUsernameLb = new System.Windows.Forms.Label();
            this.updatePrivlabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 59;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // updateRoleBtn
            // 
            this.updateRoleBtn.BackColor = System.Drawing.Color.Yellow;
            this.updateRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.updateRoleBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateRoleBtn.Location = new System.Drawing.Point(240, 247);
            this.updateRoleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateRoleBtn.Name = "updateRoleBtn";
            this.updateRoleBtn.Size = new System.Drawing.Size(184, 50);
            this.updateRoleBtn.TabIndex = 57;
            this.updateRoleBtn.Text = "UPDATE";
            this.updateRoleBtn.UseVisualStyleBackColor = false;
            this.updateRoleBtn.Click += new System.EventHandler(this.updateRoleBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(212, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 56;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateRoleCbb
            // 
            this.updateRoleCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateRoleCbb.FormattingEnabled = true;
            this.updateRoleCbb.Location = new System.Drawing.Point(305, 120);
            this.updateRoleCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateRoleCbb.Name = "updateRoleCbb";
            this.updateRoleCbb.Size = new System.Drawing.Size(283, 28);
            this.updateRoleCbb.TabIndex = 55;
            this.updateRoleCbb.SelectedIndexChanged += new System.EventHandler(this.updateRoleCbb_SelectedIndexChanged);
            this.updateRoleCbb.SelectedValueChanged += new System.EventHandler(this.updateRoleCbb_SelectedValueChanged);
            // 
            // chooseUsernameLb
            // 
            this.chooseUsernameLb.AutoSize = true;
            this.chooseUsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameLb.Location = new System.Drawing.Point(76, 120);
            this.chooseUsernameLb.Name = "chooseUsernameLb";
            this.chooseUsernameLb.Size = new System.Drawing.Size(134, 29);
            this.chooseUsernameLb.TabIndex = 54;
            this.chooseUsernameLb.Text = "Chọn role:";
            // 
            // updatePrivlabel
            // 
            this.updatePrivlabel.AutoSize = true;
            this.updatePrivlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.updatePrivlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.updatePrivlabel.Location = new System.Drawing.Point(150, 32);
            this.updatePrivlabel.Name = "updatePrivlabel";
            this.updatePrivlabel.Size = new System.Drawing.Size(395, 52);
            this.updatePrivlabel.TabIndex = 53;
            this.updatePrivlabel.Text = "CHỈNH SỬA ROLE";
            this.updatePrivlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(305, 184);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextbox.Multiline = true;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(283, 32);
            this.passwordTextbox.TabIndex = 60;
            // 
            // UpdateRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 322);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateRoleBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateRoleCbb);
            this.Controls.Add(this.chooseUsernameLb);
            this.Controls.Add(this.updatePrivlabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateRoleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox updateRoleCbb;
        private System.Windows.Forms.Label chooseUsernameLb;
        private System.Windows.Forms.Label updatePrivlabel;
        private System.Windows.Forms.TextBox passwordTextbox;
    }
}