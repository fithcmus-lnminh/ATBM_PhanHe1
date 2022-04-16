namespace PhanHe1
{
    partial class RolePriv
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
            this.chooseRoleLb = new System.Windows.Forms.Label();
            this.Admin_Option = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.privUserLv = new System.Windows.Forms.ListView();
            this.GRANTEE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GRANTED_ROLE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // privUserlabel
            // 
            this.privUserlabel.AutoSize = true;
            this.privUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.privUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.privUserlabel.Location = new System.Drawing.Point(30, 20);
            this.privUserlabel.Name = "privUserlabel";
            this.privUserlabel.Size = new System.Drawing.Size(566, 42);
            this.privUserlabel.TabIndex = 40;
            this.privUserlabel.Text = "THÔNG TIN QUYỀN CỦA ROLE";
            this.privUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listRoleCbb
            // 
            this.listRoleCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listRoleCbb.FormattingEnabled = true;
            this.listRoleCbb.Location = new System.Drawing.Point(279, 78);
            this.listRoleCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listRoleCbb.Name = "listRoleCbb";
            this.listRoleCbb.Size = new System.Drawing.Size(226, 24);
            this.listRoleCbb.Sorted = true;
            this.listRoleCbb.TabIndex = 39;
            this.listRoleCbb.SelectedIndexChanged += new System.EventHandler(this.listRoleCbb_SelectedIndexChanged);
            // 
            // chooseRoleLb
            // 
            this.chooseRoleLb.AutoSize = true;
            this.chooseRoleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseRoleLb.Location = new System.Drawing.Point(146, 78);
            this.chooseRoleLb.Name = "chooseRoleLb";
            this.chooseRoleLb.Size = new System.Drawing.Size(113, 25);
            this.chooseRoleLb.TabIndex = 38;
            this.chooseRoleLb.Text = "Chọn role:";
            // 
            // Admin_Option
            // 
            this.Admin_Option.Text = "Admin Option";
            this.Admin_Option.Width = 150;
            // 
            // privUserLv
            // 
            this.privUserLv.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.privUserLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GRANTEE,
            this.GRANTED_ROLE,
            this.Admin_Option});
            this.privUserLv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privUserLv.HideSelection = false;
            this.privUserLv.Location = new System.Drawing.Point(38, 122);
            this.privUserLv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.privUserLv.Name = "privUserLv";
            this.privUserLv.Size = new System.Drawing.Size(586, 310);
            this.privUserLv.TabIndex = 37;
            this.privUserLv.UseCompatibleStateImageBehavior = false;
            this.privUserLv.View = System.Windows.Forms.View.Details;
            // 
            // GRANTEE
            // 
            this.GRANTEE.Text = "GRANTEE";
            this.GRANTEE.Width = 150;
            // 
            // GRANTED_ROLE
            // 
            this.GRANTED_ROLE.Text = "GRANTED_ROLE";
            this.GRANTED_ROLE.Width = 150;
            // 
            // RolePriv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(679, 457);
            this.Controls.Add(this.privUserlabel);
            this.Controls.Add(this.listRoleCbb);
            this.Controls.Add(this.privUserLv);
            this.Controls.Add(this.chooseRoleLb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RolePriv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin quyền của role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label privUserlabel;
        private System.Windows.Forms.ComboBox listRoleCbb;
        private System.Windows.Forms.Label chooseRoleLb;
        private System.Windows.Forms.ColumnHeader Admin_Option;
        private System.Windows.Forms.ListView privUserLv;
        private System.Windows.Forms.ColumnHeader GRANTEE;
        private System.Windows.Forms.ColumnHeader GRANTED_ROLE;
    }
}