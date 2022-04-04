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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.listRoleCbb = new System.Windows.Forms.ComboBox();
            this.chooseUsernameLb = new System.Windows.Forms.Label();
            this.deleteUserLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteBtn.Location = new System.Drawing.Point(206, 185);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(185, 50);
            this.deleteBtn.TabIndex = 52;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // listRoleCbb
            // 
            this.listRoleCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listRoleCbb.FormattingEnabled = true;
            this.listRoleCbb.Location = new System.Drawing.Point(292, 125);
            this.listRoleCbb.Name = "listRoleCbb";
            this.listRoleCbb.Size = new System.Drawing.Size(254, 28);
            this.listRoleCbb.TabIndex = 51;
            // 
            // chooseUsernameLb
            // 
            this.chooseUsernameLb.AutoSize = true;
            this.chooseUsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameLb.Location = new System.Drawing.Point(53, 125);
            this.chooseUsernameLb.Name = "chooseUsernameLb";
            this.chooseUsernameLb.Size = new System.Drawing.Size(218, 29);
            this.chooseUsernameLb.TabIndex = 50;
            this.chooseUsernameLb.Text = "Chọn người dùng:";
            // 
            // deleteUserLb
            // 
            this.deleteUserLb.AutoSize = true;
            this.deleteUserLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deleteUserLb.ForeColor = System.Drawing.Color.MediumBlue;
            this.deleteUserLb.Location = new System.Drawing.Point(168, 40);
            this.deleteUserLb.Name = "deleteUserLb";
            this.deleteUserLb.Size = new System.Drawing.Size(245, 52);
            this.deleteUserLb.TabIndex = 49;
            this.deleteUserLb.Text = "XÓA ROLE";
            this.deleteUserLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 287);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.listRoleCbb);
            this.Controls.Add(this.chooseUsernameLb);
            this.Controls.Add(this.deleteUserLb);
            this.Name = "DeleteRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox listRoleCbb;
        private System.Windows.Forms.Label chooseUsernameLb;
        private System.Windows.Forms.Label deleteUserLb;
    }
}