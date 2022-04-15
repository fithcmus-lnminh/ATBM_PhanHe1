namespace PhanHe1
{
    partial class RevokePrivUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevokePrivUser));
            this.listUserCbb = new System.Windows.Forms.ComboBox();
            this.chooseUsernameLb = new System.Windows.Forms.Label();
            this.manageUserlabel = new System.Windows.Forms.Label();
            this.revokeBtn = new System.Windows.Forms.Button();
            this.chooseTypePrivLb = new System.Windows.Forms.Label();
            this.listTypePrivCbb = new System.Windows.Forms.ComboBox();
            this.choosePrivLb = new System.Windows.Forms.Label();
            this.listPrivCbb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listUserCbb
            // 
            this.listUserCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listUserCbb.FormattingEnabled = true;
            this.listUserCbb.Location = new System.Drawing.Point(331, 140);
            this.listUserCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listUserCbb.Name = "listUserCbb";
            this.listUserCbb.Size = new System.Drawing.Size(362, 24);
            this.listUserCbb.TabIndex = 41;
            this.listUserCbb.SelectedValueChanged += new System.EventHandler(this.listUserCbb_SelectedValueChanged);
            // 
            // chooseUsernameLb
            // 
            this.chooseUsernameLb.AutoSize = true;
            this.chooseUsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameLb.Location = new System.Drawing.Point(124, 140);
            this.chooseUsernameLb.Name = "chooseUsernameLb";
            this.chooseUsernameLb.Size = new System.Drawing.Size(184, 25);
            this.chooseUsernameLb.TabIndex = 40;
            this.chooseUsernameLb.Text = "Chọn người dùng:";
            // 
            // manageUserlabel
            // 
            this.manageUserlabel.AutoSize = true;
            this.manageUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.manageUserlabel.Location = new System.Drawing.Point(152, 43);
            this.manageUserlabel.Name = "manageUserlabel";
            this.manageUserlabel.Size = new System.Drawing.Size(564, 42);
            this.manageUserlabel.TabIndex = 39;
            this.manageUserlabel.Text = "THU HỒI QUYỀN NGƯỜI DÙNG";
            this.manageUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revokeBtn
            // 
            this.revokeBtn.BackColor = System.Drawing.Color.Red;
            this.revokeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.revokeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.revokeBtn.Location = new System.Drawing.Point(331, 289);
            this.revokeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.revokeBtn.Name = "revokeBtn";
            this.revokeBtn.Size = new System.Drawing.Size(164, 40);
            this.revokeBtn.TabIndex = 43;
            this.revokeBtn.Text = "REVOKE";
            this.revokeBtn.UseVisualStyleBackColor = false;
            this.revokeBtn.Click += new System.EventHandler(this.revokeBtn_Click);
            // 
            // chooseTypePrivLb
            // 
            this.chooseTypePrivLb.AutoSize = true;
            this.chooseTypePrivLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseTypePrivLb.Location = new System.Drawing.Point(124, 184);
            this.chooseTypePrivLb.Name = "chooseTypePrivLb";
            this.chooseTypePrivLb.Size = new System.Drawing.Size(176, 25);
            this.chooseTypePrivLb.TabIndex = 44;
            this.chooseTypePrivLb.Text = "Chọn loại quyền:";
            // 
            // listTypePrivCbb
            // 
            this.listTypePrivCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listTypePrivCbb.FormattingEnabled = true;
            this.listTypePrivCbb.Location = new System.Drawing.Point(331, 185);
            this.listTypePrivCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listTypePrivCbb.Name = "listTypePrivCbb";
            this.listTypePrivCbb.Size = new System.Drawing.Size(362, 24);
            this.listTypePrivCbb.TabIndex = 45;
            this.listTypePrivCbb.SelectedValueChanged += new System.EventHandler(this.listTypePrivCbb_SelectedValueChanged);
            // 
            // choosePrivLb
            // 
            this.choosePrivLb.AutoSize = true;
            this.choosePrivLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePrivLb.Location = new System.Drawing.Point(124, 226);
            this.choosePrivLb.Name = "choosePrivLb";
            this.choosePrivLb.Size = new System.Drawing.Size(136, 25);
            this.choosePrivLb.TabIndex = 46;
            this.choosePrivLb.Text = "Chọn quyền:";
            // 
            // listPrivCbb
            // 
            this.listPrivCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listPrivCbb.FormattingEnabled = true;
            this.listPrivCbb.Location = new System.Drawing.Point(331, 227);
            this.listPrivCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPrivCbb.Name = "listPrivCbb";
            this.listPrivCbb.Size = new System.Drawing.Size(362, 24);
            this.listPrivCbb.TabIndex = 47;
            this.listPrivCbb.SelectedValueChanged += new System.EventHandler(this.listPrivCbb_SelectedValueChanged);
            // 
            // RevokePrivUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(893, 361);
            this.Controls.Add(this.listPrivCbb);
            this.Controls.Add(this.choosePrivLb);
            this.Controls.Add(this.listTypePrivCbb);
            this.Controls.Add(this.chooseTypePrivLb);
            this.Controls.Add(this.revokeBtn);
            this.Controls.Add(this.listUserCbb);
            this.Controls.Add(this.chooseUsernameLb);
            this.Controls.Add(this.manageUserlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RevokePrivUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu hồi quyền người dùng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox listUserCbb;
        private System.Windows.Forms.Label chooseUsernameLb;
        private System.Windows.Forms.Label manageUserlabel;
        private System.Windows.Forms.Button revokeBtn;
        private System.Windows.Forms.Label chooseTypePrivLb;
        private System.Windows.Forms.ComboBox listTypePrivCbb;
        private System.Windows.Forms.Label choosePrivLb;
        private System.Windows.Forms.ComboBox listPrivCbb;
    }
}