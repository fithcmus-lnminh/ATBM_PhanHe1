namespace PhanHe1
{
    partial class RevokePrivRole
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
            this.revokeBtn = new System.Windows.Forms.Button();
            this.listRoleCbb = new System.Windows.Forms.ComboBox();
            this.chooseRolenameLb = new System.Windows.Forms.Label();
            this.manageRolelabel = new System.Windows.Forms.Label();
            this.chooseTypePrivLb = new System.Windows.Forms.Label();
            this.choosePrivLb = new System.Windows.Forms.Label();
            this.listTypePrivCbb = new System.Windows.Forms.ComboBox();
            this.listPrivCbb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // revokeBtn
            // 
            this.revokeBtn.BackColor = System.Drawing.Color.Red;
            this.revokeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.revokeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.revokeBtn.Location = new System.Drawing.Point(402, 331);
            this.revokeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.revokeBtn.Name = "revokeBtn";
            this.revokeBtn.Size = new System.Drawing.Size(184, 50);
            this.revokeBtn.TabIndex = 48;
            this.revokeBtn.Text = "REVOKE";
            this.revokeBtn.UseVisualStyleBackColor = false;
            this.revokeBtn.Click += new System.EventHandler(this.revokeBtn_Click);
            // 
            // listRoleCbb
            // 
            this.listRoleCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listRoleCbb.FormattingEnabled = true;
            this.listRoleCbb.Location = new System.Drawing.Point(402, 141);
            this.listRoleCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listRoleCbb.Name = "listRoleCbb";
            this.listRoleCbb.Size = new System.Drawing.Size(412, 28);
            this.listRoleCbb.TabIndex = 46;
            this.listRoleCbb.SelectedIndexChanged += new System.EventHandler(this.listRoleCbb_SelectedIndexChanged);
            this.listRoleCbb.SelectedValueChanged += new System.EventHandler(this.listRoleCbb_SelectedValueChanged);
            // 
            // chooseRolenameLb
            // 
            this.chooseRolenameLb.AutoSize = true;
            this.chooseRolenameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseRolenameLb.Location = new System.Drawing.Point(175, 141);
            this.chooseRolenameLb.Name = "chooseRolenameLb";
            this.chooseRolenameLb.Size = new System.Drawing.Size(134, 29);
            this.chooseRolenameLb.TabIndex = 45;
            this.chooseRolenameLb.Text = "Chọn role:";
            // 
            // manageRolelabel
            // 
            this.manageRolelabel.AutoSize = true;
            this.manageRolelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageRolelabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.manageRolelabel.Location = new System.Drawing.Point(196, 58);
            this.manageRolelabel.Name = "manageRolelabel";
            this.manageRolelabel.Size = new System.Drawing.Size(607, 52);
            this.manageRolelabel.TabIndex = 44;
            this.manageRolelabel.Text = "THU HỒI QUYỀN CỦA ROLE";
            this.manageRolelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chooseTypePrivLb
            // 
            this.chooseTypePrivLb.AutoSize = true;
            this.chooseTypePrivLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseTypePrivLb.Location = new System.Drawing.Point(175, 198);
            this.chooseTypePrivLb.Name = "chooseTypePrivLb";
            this.chooseTypePrivLb.Size = new System.Drawing.Size(208, 29);
            this.chooseTypePrivLb.TabIndex = 49;
            this.chooseTypePrivLb.Text = "Chọn loại quyền:";
            // 
            // choosePrivLb
            // 
            this.choosePrivLb.AutoSize = true;
            this.choosePrivLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePrivLb.Location = new System.Drawing.Point(175, 258);
            this.choosePrivLb.Name = "choosePrivLb";
            this.choosePrivLb.Size = new System.Drawing.Size(158, 29);
            this.choosePrivLb.TabIndex = 50;
            this.choosePrivLb.Text = "Chọn quyền:";
            // 
            // listTypePrivCbb
            // 
            this.listTypePrivCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listTypePrivCbb.FormattingEnabled = true;
            this.listTypePrivCbb.Location = new System.Drawing.Point(402, 198);
            this.listTypePrivCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listTypePrivCbb.Name = "listTypePrivCbb";
            this.listTypePrivCbb.Size = new System.Drawing.Size(412, 28);
            this.listTypePrivCbb.TabIndex = 51;
            this.listTypePrivCbb.SelectedValueChanged += new System.EventHandler(this.listTypePrivCbb_SelectedValueChanged);
            // 
            // listPrivCbb
            // 
            this.listPrivCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listPrivCbb.FormattingEnabled = true;
            this.listPrivCbb.Location = new System.Drawing.Point(402, 258);
            this.listPrivCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPrivCbb.Name = "listPrivCbb";
            this.listPrivCbb.Size = new System.Drawing.Size(412, 28);
            this.listPrivCbb.TabIndex = 52;
            this.listPrivCbb.SelectedValueChanged += new System.EventHandler(this.listPrivCbb_SelectedValueChanged);
            // 
            // RevokePrivRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 423);
            this.Controls.Add(this.listPrivCbb);
            this.Controls.Add(this.listTypePrivCbb);
            this.Controls.Add(this.choosePrivLb);
            this.Controls.Add(this.chooseTypePrivLb);
            this.Controls.Add(this.revokeBtn);
            this.Controls.Add(this.listRoleCbb);
            this.Controls.Add(this.chooseRolenameLb);
            this.Controls.Add(this.manageRolelabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RevokePrivRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu hồi quyền của Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button revokeBtn;
        private System.Windows.Forms.ComboBox listRoleCbb;
        private System.Windows.Forms.Label chooseRolenameLb;
        private System.Windows.Forms.Label manageRolelabel;
        private System.Windows.Forms.Label chooseTypePrivLb;
        private System.Windows.Forms.Label choosePrivLb;
        private System.Windows.Forms.ComboBox listTypePrivCbb;
        private System.Windows.Forms.ComboBox listPrivCbb;
    }
}