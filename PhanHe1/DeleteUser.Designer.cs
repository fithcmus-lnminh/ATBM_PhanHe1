namespace PhanHe1
{
    partial class DeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUser));
            this.deleteBtn = new System.Windows.Forms.Button();
            this.deleteUserCbb = new System.Windows.Forms.ComboBox();
            this.chooseUsernameLb = new System.Windows.Forms.Label();
            this.deleteUserLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteBtn.Location = new System.Drawing.Point(198, 131);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(164, 40);
            this.deleteBtn.TabIndex = 48;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // deleteUserCbb
            // 
            this.deleteUserCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deleteUserCbb.FormattingEnabled = true;
            this.deleteUserCbb.Location = new System.Drawing.Point(275, 83);
            this.deleteUserCbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteUserCbb.Name = "deleteUserCbb";
            this.deleteUserCbb.Size = new System.Drawing.Size(226, 24);
            this.deleteUserCbb.TabIndex = 46;
            this.deleteUserCbb.SelectedValueChanged += new System.EventHandler(this.deleteUserCbb_SelectedValueChanged);
            // 
            // chooseUsernameLb
            // 
            this.chooseUsernameLb.AutoSize = true;
            this.chooseUsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameLb.Location = new System.Drawing.Point(62, 83);
            this.chooseUsernameLb.Name = "chooseUsernameLb";
            this.chooseUsernameLb.Size = new System.Drawing.Size(184, 25);
            this.chooseUsernameLb.TabIndex = 45;
            this.chooseUsernameLb.Text = "Chọn người dùng:";
            // 
            // deleteUserLb
            // 
            this.deleteUserLb.AutoSize = true;
            this.deleteUserLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deleteUserLb.ForeColor = System.Drawing.Color.MediumBlue;
            this.deleteUserLb.Location = new System.Drawing.Point(106, 20);
            this.deleteUserLb.Name = "deleteUserLb";
            this.deleteUserLb.Size = new System.Drawing.Size(348, 42);
            this.deleteUserLb.TabIndex = 44;
            this.deleteUserLb.Text = "XÓA NGƯỜI DÙNG";
            this.deleteUserLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(579, 200);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.deleteUserCbb);
            this.Controls.Add(this.chooseUsernameLb);
            this.Controls.Add(this.deleteUserLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa người dùng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox deleteUserCbb;
        private System.Windows.Forms.Label chooseUsernameLb;
        private System.Windows.Forms.Label deleteUserLb;
    }
}