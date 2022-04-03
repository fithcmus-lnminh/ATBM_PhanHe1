namespace PhanHe1
{
    partial class FormRoot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoot));
            this.label1 = new System.Windows.Forms.Label();
            this.manageUserBtn = new System.Windows.Forms.Button();
            this.manageRoleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(84, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATABASE ADMINISTRATOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manageUserBtn
            // 
            this.manageUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.manageUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.manageUserBtn.Location = new System.Drawing.Point(103, 160);
            this.manageUserBtn.Name = "manageUserBtn";
            this.manageUserBtn.Size = new System.Drawing.Size(262, 151);
            this.manageUserBtn.TabIndex = 1;
            this.manageUserBtn.Text = "QUẢN LÝ USER";
            this.manageUserBtn.UseVisualStyleBackColor = false;
            this.manageUserBtn.Click += new System.EventHandler(this.manageUserBtn_Click);
            // 
            // manageRoleBtn
            // 
            this.manageRoleBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.manageRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageRoleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.manageRoleBtn.Location = new System.Drawing.Point(431, 160);
            this.manageRoleBtn.Name = "manageRoleBtn";
            this.manageRoleBtn.Size = new System.Drawing.Size(262, 151);
            this.manageRoleBtn.TabIndex = 2;
            this.manageRoleBtn.Text = "QUẢN LÝ ROLE";
            this.manageRoleBtn.UseVisualStyleBackColor = false;
            this.manageRoleBtn.Click += new System.EventHandler(this.manageRoleBtn_Click);
            // 
            // FormRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.manageRoleBtn);
            this.Controls.Add(this.manageUserBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRoot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị viên";
            this.Load += new System.EventHandler(this.FormRoot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button manageUserBtn;
        private System.Windows.Forms.Button manageRoleBtn;
    }
}