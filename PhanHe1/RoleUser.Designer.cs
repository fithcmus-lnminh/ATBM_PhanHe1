namespace PhanHe1
{
    partial class RoleUser
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
            this.privUserlabel = new System.Windows.Forms.Label();
            this.listRoleCbb = new System.Windows.Forms.ComboBox();
            this.privUserLv = new System.Windows.Forms.ListView();
            this.Grantee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chooseRoleLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // privUserlabel
            // 
            this.privUserlabel.AutoSize = true;
            this.privUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.privUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.privUserlabel.Location = new System.Drawing.Point(71, 34);
            this.privUserlabel.Name = "privUserlabel";
            this.privUserlabel.Size = new System.Drawing.Size(798, 52);
            this.privUserlabel.TabIndex = 44;
            this.privUserlabel.Text = "THÔNG TIN ROLE CỦA NGƯỜI DÙNG";
            this.privUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listRoleCbb
            // 
            this.listRoleCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listRoleCbb.FormattingEnabled = true;
            this.listRoleCbb.Location = new System.Drawing.Point(411, 107);
            this.listRoleCbb.Name = "listRoleCbb";
            this.listRoleCbb.Size = new System.Drawing.Size(254, 28);
            this.listRoleCbb.TabIndex = 43;
            this.listRoleCbb.SelectedIndexChanged += new System.EventHandler(this.listRoleCbb_SelectedIndexChanged);
            // 
            // privUserLv
            // 
            this.privUserLv.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.privUserLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Grantee});
            this.privUserLv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privUserLv.HideSelection = false;
            this.privUserLv.Location = new System.Drawing.Point(140, 162);
            this.privUserLv.Name = "privUserLv";
            this.privUserLv.Size = new System.Drawing.Size(659, 387);
            this.privUserLv.TabIndex = 41;
            this.privUserLv.UseCompatibleStateImageBehavior = false;
            this.privUserLv.View = System.Windows.Forms.View.Details;
            // 
            // Grantee
            // 
            this.Grantee.Text = "Grantee";
            this.Grantee.Width = 350;
            // 
            // chooseRoleLb
            // 
            this.chooseRoleLb.AutoSize = true;
            this.chooseRoleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseRoleLb.Location = new System.Drawing.Point(261, 107);
            this.chooseRoleLb.Name = "chooseRoleLb";
            this.chooseRoleLb.Size = new System.Drawing.Size(134, 29);
            this.chooseRoleLb.TabIndex = 42;
            this.chooseRoleLb.Text = "Chọn role:";
            // 
            // RoleUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(931, 583);
            this.Controls.Add(this.privUserlabel);
            this.Controls.Add(this.listRoleCbb);
            this.Controls.Add(this.privUserLv);
            this.Controls.Add(this.chooseRoleLb);
            this.Name = "RoleUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin role của người dùng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label privUserlabel;
        private System.Windows.Forms.ComboBox listRoleCbb;
        private System.Windows.Forms.ListView privUserLv;
        private System.Windows.Forms.ColumnHeader Grantee;
        private System.Windows.Forms.Label chooseRoleLb;
    }
}