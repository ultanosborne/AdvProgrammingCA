namespace AdvProgrammingCA
{
    partial class StudentDB
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
            this.btLogout = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lblHistory = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpView = new System.Windows.Forms.TabPage();
            this.tbpNew = new System.Windows.Forms.TabPage();
            this.tbpEdit = new System.Windows.Forms.TabPage();
            this.tbpDelete = new System.Windows.Forms.TabPage();
            this.tbpHistory = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(226, 392);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(135, 35);
            this.btLogout.TabIndex = 0;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(415, 392);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(135, 35);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblHistory.Location = new System.Drawing.Point(558, 38);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(191, 20);
            this.lblHistory.TabIndex = 5;
            this.lblHistory.Text = "View Database History";
            this.lblHistory.Click += new System.EventHandler(this.lblHistory_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblDelete.Location = new System.Drawing.Point(419, 38);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(131, 20);
            this.lblDelete.TabIndex = 4;
            this.lblDelete.Text = "Delete Student";
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblEdit.Location = new System.Drawing.Point(294, 38);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(110, 20);
            this.lblEdit.TabIndex = 3;
            this.lblEdit.Text = "Edit Student";
            this.lblEdit.Click += new System.EventHandler(this.lblEdit_Click);
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblNew.Location = new System.Drawing.Point(169, 38);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(112, 20);
            this.lblNew.TabIndex = 2;
            this.lblNew.Text = "New Student";
            this.lblNew.Click += new System.EventHandler(this.lblNew_Click);
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblView.Location = new System.Drawing.Point(21, 38);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(130, 20);
            this.lblView.TabIndex = 6;
            this.lblView.Text = "View Database";
            this.lblView.Click += new System.EventHandler(this.lblView_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpView);
            this.tabControl1.Controls.Add(this.tbpNew);
            this.tabControl1.Controls.Add(this.tbpEdit);
            this.tabControl1.Controls.Add(this.tbpDelete);
            this.tabControl1.Controls.Add(this.tbpHistory);
            this.tabControl1.Location = new System.Drawing.Point(25, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 324);
            this.tabControl1.TabIndex = 7;
            // 
            // tbpView
            // 
            this.tbpView.BackColor = System.Drawing.SystemColors.Control;
            this.tbpView.Location = new System.Drawing.Point(4, 22);
            this.tbpView.Name = "tbpView";
            this.tbpView.Padding = new System.Windows.Forms.Padding(3);
            this.tbpView.Size = new System.Drawing.Size(716, 298);
            this.tbpView.TabIndex = 0;
            // 
            // tbpNew
            // 
            this.tbpNew.BackColor = System.Drawing.SystemColors.Control;
            this.tbpNew.Location = new System.Drawing.Point(4, 22);
            this.tbpNew.Name = "tbpNew";
            this.tbpNew.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNew.Size = new System.Drawing.Size(716, 298);
            this.tbpNew.TabIndex = 1;
            // 
            // tbpEdit
            // 
            this.tbpEdit.BackColor = System.Drawing.SystemColors.Control;
            this.tbpEdit.Location = new System.Drawing.Point(4, 22);
            this.tbpEdit.Name = "tbpEdit";
            this.tbpEdit.Size = new System.Drawing.Size(716, 298);
            this.tbpEdit.TabIndex = 2;
            // 
            // tbpDelete
            // 
            this.tbpDelete.BackColor = System.Drawing.SystemColors.Control;
            this.tbpDelete.Location = new System.Drawing.Point(4, 22);
            this.tbpDelete.Name = "tbpDelete";
            this.tbpDelete.Size = new System.Drawing.Size(716, 298);
            this.tbpDelete.TabIndex = 3;
            // 
            // tbpHistory
            // 
            this.tbpHistory.BackColor = System.Drawing.SystemColors.Control;
            this.tbpHistory.Location = new System.Drawing.Point(4, 22);
            this.tbpHistory.Name = "tbpHistory";
            this.tbpHistory.Size = new System.Drawing.Size(716, 298);
            this.tbpHistory.TabIndex = 4;
            // 
            // StudentDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "StudentDB";
            this.Text = "DBS Student Management System";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpView;
        private System.Windows.Forms.TabPage tbpNew;
        private System.Windows.Forms.TabPage tbpEdit;
        private System.Windows.Forms.TabPage tbpDelete;
        private System.Windows.Forms.TabPage tbpHistory;
    }
}