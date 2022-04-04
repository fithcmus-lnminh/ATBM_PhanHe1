namespace PhanHe1
{
    partial class UpdatePrivRole
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
            this.chooseRoleLb = new System.Windows.Forms.Label();
            this.updatePrivlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grantBtn
            // 
            this.grantBtn.BackColor = System.Drawing.Color.Yellow;
            this.grantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grantBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grantBtn.Location = new System.Drawing.Point(286, 372);
            this.grantBtn.Name = "grantBtn";
            this.grantBtn.Size = new System.Drawing.Size(185, 50);
            this.grantBtn.TabIndex = 49;
            this.grantBtn.Text = "UPDATE";
            this.grantBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(233, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "xử lý và hiển thị sửa quyền ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listUserCbb
            // 
            this.listUserCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listUserCbb.FormattingEnabled = true;
            this.listUserCbb.Location = new System.Drawing.Point(369, 102);
            this.listUserCbb.Name = "listUserCbb";
            this.listUserCbb.Size = new System.Drawing.Size(254, 28);
            this.listUserCbb.TabIndex = 47;
            // 
            // chooseRoleLb
            // 
            this.chooseRoleLb.AutoSize = true;
            this.chooseRoleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseRoleLb.Location = new System.Drawing.Point(136, 101);
            this.chooseRoleLb.Name = "chooseRoleLb";
            this.chooseRoleLb.Size = new System.Drawing.Size(134, 29);
            this.chooseRoleLb.TabIndex = 46;
            this.chooseRoleLb.Text = "Chọn role:";
            // 
            // updatePrivlabel
            // 
            this.updatePrivlabel.AutoSize = true;
            this.updatePrivlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.updatePrivlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.updatePrivlabel.Location = new System.Drawing.Point(62, 24);
            this.updatePrivlabel.Name = "updatePrivlabel";
            this.updatePrivlabel.Size = new System.Drawing.Size(668, 52);
            this.updatePrivlabel.TabIndex = 45;
            this.updatePrivlabel.Text = "CHỈNH SỬA QUYỀN CỦA ROLE";
            this.updatePrivlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdatePrivRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grantBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listUserCbb);
            this.Controls.Add(this.chooseRoleLb);
            this.Controls.Add(this.updatePrivlabel);
            this.Name = "UpdatePrivRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa quyền của Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grantBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listUserCbb;
        private System.Windows.Forms.Label chooseRoleLb;
        private System.Windows.Forms.Label updatePrivlabel;
    }
}