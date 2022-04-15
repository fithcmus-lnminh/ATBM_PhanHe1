namespace PhanHe1
{
    partial class DeleteRole
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
            this.deleteRoleBtn = new System.Windows.Forms.Button();
            this.deleteRoleCbb = new System.Windows.Forms.ComboBox();
            this.chooseUsernameLb = new System.Windows.Forms.Label();
            this.deleteUserLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteRoleBtn
            // 
            this.deleteRoleBtn.BackColor = System.Drawing.Color.Red;
            this.deleteRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deleteRoleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteRoleBtn.Location = new System.Drawing.Point(183, 148);
            this.deleteRoleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteRoleBtn.Name = "deleteRoleBtn";
            this.deleteRoleBtn.Size = new System.Drawing.Size(164, 40);
            this.deleteRoleBtn.TabIndex = 52;
            this.deleteRoleBtn.Text = "DELETE";
            this.deleteRoleBtn.UseVisualStyleBackColor = false;
            this.deleteRoleBtn.Click += new System.EventHandler(this.deleteRoleBtn_Click);
            // 
            // deleteRoleCbb
            // 
            this.deleteRoleCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deleteRoleCbb.FormattingEnabled = true;
            this.deleteRoleCbb.Location = new System.Drawing.Point(260, 100);
            this.deleteRoleCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteRoleCbb.Name = "deleteRoleCbb";
            this.deleteRoleCbb.Size = new System.Drawing.Size(226, 24);
            this.deleteRoleCbb.TabIndex = 51;
            this.deleteRoleCbb.SelectedValueChanged += new System.EventHandler(this.deleteRoleCbb_SelectedValueChanged);
            // 
            // chooseUsernameLb
            // 
            this.chooseUsernameLb.AutoSize = true;
            this.chooseUsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameLb.Location = new System.Drawing.Point(47, 100);
            this.chooseUsernameLb.Name = "chooseUsernameLb";
            this.chooseUsernameLb.Size = new System.Drawing.Size(113, 25);
            this.chooseUsernameLb.TabIndex = 50;
            this.chooseUsernameLb.Text = "Chọn role:";
            // 
            // deleteUserLb
            // 
            this.deleteUserLb.AutoSize = true;
            this.deleteUserLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deleteUserLb.ForeColor = System.Drawing.Color.MediumBlue;
            this.deleteUserLb.Location = new System.Drawing.Point(149, 32);
            this.deleteUserLb.Name = "deleteUserLb";
            this.deleteUserLb.Size = new System.Drawing.Size(209, 42);
            this.deleteUserLb.TabIndex = 49;
            this.deleteUserLb.Text = "XÓA ROLE";
            this.deleteUserLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 230);
            this.Controls.Add(this.deleteRoleBtn);
            this.Controls.Add(this.deleteRoleCbb);
            this.Controls.Add(this.chooseUsernameLb);
            this.Controls.Add(this.deleteUserLb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DeleteRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteRoleBtn;
        private System.Windows.Forms.ComboBox deleteRoleCbb;
        private System.Windows.Forms.Label chooseUsernameLb;
        private System.Windows.Forms.Label deleteUserLb;
    }
}