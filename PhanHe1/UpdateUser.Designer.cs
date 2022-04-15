namespace PhanHe1
{
    partial class UpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUser));
            this.updateUserBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.updateUserCbb = new System.Windows.Forms.ComboBox();
            this.chooseUsernameLb = new System.Windows.Forms.Label();
            this.updatePrivlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updateUserBtn
            // 
            this.updateUserBtn.BackColor = System.Drawing.Color.Yellow;
            this.updateUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.updateUserBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateUserBtn.Location = new System.Drawing.Point(251, 195);
            this.updateUserBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateUserBtn.Name = "updateUserBtn";
            this.updateUserBtn.Size = new System.Drawing.Size(164, 40);
            this.updateUserBtn.TabIndex = 49;
            this.updateUserBtn.Text = "UPDATE";
            this.updateUserBtn.UseVisualStyleBackColor = false;
            this.updateUserBtn.Click += new System.EventHandler(this.updateUserBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(219, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 48;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateUserCbb
            // 
            this.updateUserCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateUserCbb.FormattingEnabled = true;
            this.updateUserCbb.Location = new System.Drawing.Point(328, 82);
            this.updateUserCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateUserCbb.Name = "updateUserCbb";
            this.updateUserCbb.Size = new System.Drawing.Size(252, 24);
            this.updateUserCbb.TabIndex = 47;
            this.updateUserCbb.SelectedValueChanged += new System.EventHandler(this.updateUserCbb_SelectedValueChanged);
            // 
            // chooseUsernameLb
            // 
            this.chooseUsernameLb.AutoSize = true;
            this.chooseUsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameLb.Location = new System.Drawing.Point(121, 82);
            this.chooseUsernameLb.Name = "chooseUsernameLb";
            this.chooseUsernameLb.Size = new System.Drawing.Size(184, 25);
            this.chooseUsernameLb.TabIndex = 46;
            this.chooseUsernameLb.Text = "Chọn người dùng:";
            // 
            // updatePrivlabel
            // 
            this.updatePrivlabel.AutoSize = true;
            this.updatePrivlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.updatePrivlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.updatePrivlabel.Location = new System.Drawing.Point(86, 19);
            this.updatePrivlabel.Name = "updatePrivlabel";
            this.updatePrivlabel.Size = new System.Drawing.Size(473, 42);
            this.updatePrivlabel.TabIndex = 45;
            this.updatePrivlabel.Text = "CHỈNH SỬA NGƯỜI DÙNG";
            this.updatePrivlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(328, 135);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextbox.Multiline = true;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(252, 26);
            this.passwordTextbox.TabIndex = 59;
            // 
            // UpdateUser
            // 
            this.AcceptButton = this.updateUserBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 264);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateUserBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateUserCbb);
            this.Controls.Add(this.chooseUsernameLb);
            this.Controls.Add(this.updatePrivlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa người dùng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateUserBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox updateUserCbb;
        private System.Windows.Forms.Label chooseUsernameLb;
        private System.Windows.Forms.Label updatePrivlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextbox;
    }
}