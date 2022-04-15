namespace PhanHe1
{
    partial class ListUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListUser));
            this.manageUserlabel = new System.Windows.Forms.Label();
            this.ListUserlv = new System.Windows.Forms.ListView();
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // manageUserlabel
            // 
            this.manageUserlabel.AutoSize = true;
            this.manageUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.manageUserlabel.Location = new System.Drawing.Point(29, 21);
            this.manageUserlabel.Name = "manageUserlabel";
            this.manageUserlabel.Size = new System.Drawing.Size(400, 72);
            this.manageUserlabel.TabIndex = 2;
            this.manageUserlabel.Text = "DANH SÁCH NGƯỜI DÙNG \r\nTRONG HỆ THỐNG";
            this.manageUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListUserlv
            // 
            this.ListUserlv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.username});
            this.ListUserlv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ListUserlv.HideSelection = false;
            this.ListUserlv.Location = new System.Drawing.Point(36, 110);
            this.ListUserlv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListUserlv.Name = "ListUserlv";
            this.ListUserlv.Size = new System.Drawing.Size(423, 398);
            this.ListUserlv.TabIndex = 0;
            this.ListUserlv.UseCompatibleStateImageBehavior = false;
            this.ListUserlv.View = System.Windows.Forms.View.Details;
            // 
            // username
            // 
            this.username.Text = "Tên người dùng";
            this.username.Width = 475;
            // 
            // ListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(498, 530);
            this.Controls.Add(this.ListUserlv);
            this.Controls.Add(this.manageUserlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách người dùng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manageUserlabel;
        private System.Windows.Forms.ListView ListUserlv;
        private System.Windows.Forms.ColumnHeader username;
    }
}