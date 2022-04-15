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
            this.label1 = new System.Windows.Forms.Label();
            this.listUserCbb = new System.Windows.Forms.ComboBox();
            this.chooseUsernameLb = new System.Windows.Forms.Label();
            this.manageUserlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grantBtn
            // 
            this.grantBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.grantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grantBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grantBtn.Location = new System.Drawing.Point(257, 298);
            this.grantBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grantBtn.Name = "grantBtn";
            this.grantBtn.Size = new System.Drawing.Size(164, 40);
            this.grantBtn.TabIndex = 44;
            this.grantBtn.Text = "GRANT";
            this.grantBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(219, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "xử lý và hiển thị cấp quyền ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listUserCbb
            // 
            this.listUserCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listUserCbb.FormattingEnabled = true;
            this.listUserCbb.Location = new System.Drawing.Point(298, 85);
            this.listUserCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listUserCbb.Name = "listUserCbb";
            this.listUserCbb.Size = new System.Drawing.Size(226, 24);
            this.listUserCbb.TabIndex = 42;
            // 
            // chooseUsernameLb
            // 
            this.chooseUsernameLb.AutoSize = true;
            this.chooseUsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameLb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chooseUsernameLb.Location = new System.Drawing.Point(161, 85);
            this.chooseUsernameLb.Name = "chooseUsernameLb";
            this.chooseUsernameLb.Size = new System.Drawing.Size(113, 25);
            this.chooseUsernameLb.TabIndex = 41;
            this.chooseUsernameLb.Text = "Chọn role:";
            // 
            // manageUserlabel
            // 
            this.manageUserlabel.AutoSize = true;
            this.manageUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.manageUserlabel.Location = new System.Drawing.Point(116, 26);
            this.manageUserlabel.Name = "manageUserlabel";
            this.manageUserlabel.Size = new System.Drawing.Size(443, 42);
            this.manageUserlabel.TabIndex = 40;
            this.manageUserlabel.Text = "CẤP QUYỀN CHO ROLE";
            this.manageUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrantRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.grantBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listUserCbb);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listUserCbb;
        private System.Windows.Forms.Label chooseUsernameLb;
        private System.Windows.Forms.Label manageUserlabel;
    }
}