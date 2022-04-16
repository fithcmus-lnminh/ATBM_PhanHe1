namespace PhanHe1
{
    partial class UserPriv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPriv));
            this.listUserCbb = new System.Windows.Forms.ComboBox();
            this.privUserLv = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Privilege = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Admin_option = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chooseUsernameLb = new System.Windows.Forms.Label();
            this.privUserlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listUserCbb
            // 
            this.listUserCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listUserCbb.FormattingEnabled = true;
            this.listUserCbb.Location = new System.Drawing.Point(455, 100);
            this.listUserCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listUserCbb.Name = "listUserCbb";
            this.listUserCbb.Size = new System.Drawing.Size(226, 24);
            this.listUserCbb.Sorted = true;
            this.listUserCbb.TabIndex = 35;
            this.listUserCbb.SelectedIndexChanged += new System.EventHandler(this.listUserCbb_SelectedIndexChanged);
            // 
            // privUserLv
            // 
            this.privUserLv.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.privUserLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.Privilege,
            this.Admin_option});
            this.privUserLv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privUserLv.HideSelection = false;
            this.privUserLv.Location = new System.Drawing.Point(39, 158);
            this.privUserLv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.privUserLv.Name = "privUserLv";
            this.privUserLv.Size = new System.Drawing.Size(831, 310);
            this.privUserLv.TabIndex = 33;
            this.privUserLv.UseCompatibleStateImageBehavior = false;
            this.privUserLv.View = System.Windows.Forms.View.Details;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 150;
            // 
            // Privilege
            // 
            this.Privilege.Text = "Privilege";
            this.Privilege.Width = 350;
            // 
            // Admin_option
            // 
            this.Admin_option.Text = "Admin Option";
            this.Admin_option.Width = 125;
            // 
            // chooseUsernameLb
            // 
            this.chooseUsernameLb.AutoSize = true;
            this.chooseUsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameLb.Location = new System.Drawing.Point(248, 99);
            this.chooseUsernameLb.Name = "chooseUsernameLb";
            this.chooseUsernameLb.Size = new System.Drawing.Size(184, 25);
            this.chooseUsernameLb.TabIndex = 34;
            this.chooseUsernameLb.Text = "Chọn người dùng:";
            // 
            // privUserlabel
            // 
            this.privUserlabel.AutoSize = true;
            this.privUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.privUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.privUserlabel.Location = new System.Drawing.Point(130, 31);
            this.privUserlabel.Name = "privUserlabel";
            this.privUserlabel.Size = new System.Drawing.Size(616, 42);
            this.privUserlabel.TabIndex = 36;
            this.privUserlabel.Text = "THÔNG TIN QUYỀN NGƯỜI DÙNG";
            this.privUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserPriv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(916, 512);
            this.Controls.Add(this.privUserlabel);
            this.Controls.Add(this.listUserCbb);
            this.Controls.Add(this.privUserLv);
            this.Controls.Add(this.chooseUsernameLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserPriv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin quyền người dùng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listUserCbb;
        private System.Windows.Forms.ListView privUserLv;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Privilege;
        private System.Windows.Forms.ColumnHeader Admin_option;
        private System.Windows.Forms.Label chooseUsernameLb;
        private System.Windows.Forms.Label privUserlabel;
    }
}