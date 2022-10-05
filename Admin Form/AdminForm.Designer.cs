namespace University_Info_Center.Admin_Form
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.NavigationPannel = new System.Windows.Forms.Panel();
            this.btnSemester = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.btnDeleteUni = new System.Windows.Forms.Button();
            this.btnUpdateUni = new System.Windows.Forms.Button();
            this.btnInsertUni = new System.Windows.Forms.Button();
            this.btnUniInfo = new System.Windows.Forms.Button();
            this.btnField = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContentPannel = new System.Windows.Forms.Panel();
            this.HeaderPannel = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dashboard1 = new University_Info_Center.Admin_Form.Dashboard();
            this.semester1 = new University_Info_Center.Admin_Form.Semester();
            this.userInfo1 = new University_Info_Center.Admin_Form.UserInfo();
            this.updateUniField1 = new University_Info_Center.Admin_Form.UpdateUniField();
            this.universityInfo1 = new University_Info_Center.Admin_Form.UniversityInfo();
            this.insertUniField1 = new University_Info_Center.Admin_Form.InsertUniField();
            this.field2 = new University_Info_Center.Admin_Form.Field();
            this.deleteUniField1 = new University_Info_Center.Admin_Form.DeleteUniField();
            this.field1 = new University_Info_Center.Admin_Form.Field();
            this.NavigationPannel.SuspendLayout();
            this.ContentPannel.SuspendLayout();
            this.HeaderPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationPannel
            // 
            this.NavigationPannel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NavigationPannel.Controls.Add(this.btnSemester);
            this.NavigationPannel.Controls.Add(this.tableLayoutPanel1);
            this.NavigationPannel.Controls.Add(this.btnDashboard);
            this.NavigationPannel.Controls.Add(this.d);
            this.NavigationPannel.Controls.Add(this.btnUserInfo);
            this.NavigationPannel.Controls.Add(this.btnDeleteUni);
            this.NavigationPannel.Controls.Add(this.btnUpdateUni);
            this.NavigationPannel.Controls.Add(this.btnInsertUni);
            this.NavigationPannel.Controls.Add(this.btnUniInfo);
            this.NavigationPannel.Controls.Add(this.btnField);
            this.NavigationPannel.Controls.Add(this.label4);
            this.NavigationPannel.Controls.Add(this.label2);
            this.NavigationPannel.Controls.Add(this.label1);
            this.NavigationPannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationPannel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPannel.Name = "NavigationPannel";
            this.NavigationPannel.Size = new System.Drawing.Size(196, 663);
            this.NavigationPannel.TabIndex = 1;
            // 
            // btnSemester
            // 
            this.btnSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemester.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemester.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSemester.Image = ((System.Drawing.Image)(resources.GetObject("btnSemester.Image")));
            this.btnSemester.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSemester.Location = new System.Drawing.Point(0, 464);
            this.btnSemester.Name = "btnSemester";
            this.btnSemester.Size = new System.Drawing.Size(196, 59);
            this.btnSemester.TabIndex = 9;
            this.btnSemester.Text = "Semester Info";
            this.btnSemester.UseVisualStyleBackColor = true;
            this.btnSemester.Click += new System.EventHandler(this.btnSemester_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(196, 179);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 155);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.BackgroundImage")));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Location = new System.Drawing.Point(61, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(75, 64);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // d
            // 
            this.d.BackColor = System.Drawing.Color.Crimson;
            this.d.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.d.Image = ((System.Drawing.Image)(resources.GetObject("d.Image")));
            this.d.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.d.Location = new System.Drawing.Point(0, 586);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(196, 67);
            this.d.TabIndex = 8;
            this.d.Text = "Exit";
            this.d.UseVisualStyleBackColor = false;
            this.d.Click += new System.EventHandler(this.d_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInfo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnUserInfo.Image")));
            this.btnUserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserInfo.Location = new System.Drawing.Point(0, 521);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(196, 59);
            this.btnUserInfo.TabIndex = 5;
            this.btnUserInfo.Text = "User Info";
            this.btnUserInfo.UseVisualStyleBackColor = false;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // btnDeleteUni
            // 
            this.btnDeleteUni.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteUni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUni.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDeleteUni.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUni.Image")));
            this.btnDeleteUni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUni.Location = new System.Drawing.Point(0, 407);
            this.btnDeleteUni.Name = "btnDeleteUni";
            this.btnDeleteUni.Size = new System.Drawing.Size(196, 59);
            this.btnDeleteUni.TabIndex = 5;
            this.btnDeleteUni.Text = " Delete University Field";
            this.btnDeleteUni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteUni.UseVisualStyleBackColor = false;
            this.btnDeleteUni.Click += new System.EventHandler(this.btnDeleteUni_Click);
            // 
            // btnUpdateUni
            // 
            this.btnUpdateUni.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateUni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUni.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUpdateUni.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateUni.Image")));
            this.btnUpdateUni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUni.Location = new System.Drawing.Point(0, 350);
            this.btnUpdateUni.Name = "btnUpdateUni";
            this.btnUpdateUni.Size = new System.Drawing.Size(196, 59);
            this.btnUpdateUni.TabIndex = 4;
            this.btnUpdateUni.Text = "Update University Field";
            this.btnUpdateUni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateUni.UseVisualStyleBackColor = false;
            this.btnUpdateUni.Click += new System.EventHandler(this.btnUpdateUni_Click);
            // 
            // btnInsertUni
            // 
            this.btnInsertUni.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInsertUni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertUni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertUni.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnInsertUni.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertUni.Image")));
            this.btnInsertUni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertUni.Location = new System.Drawing.Point(0, 293);
            this.btnInsertUni.Name = "btnInsertUni";
            this.btnInsertUni.Size = new System.Drawing.Size(196, 59);
            this.btnInsertUni.TabIndex = 3;
            this.btnInsertUni.Text = "  Insert University Field";
            this.btnInsertUni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertUni.UseVisualStyleBackColor = false;
            this.btnInsertUni.Click += new System.EventHandler(this.btnInsertUni_Click);
            // 
            // btnUniInfo
            // 
            this.btnUniInfo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUniInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUniInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUniInfo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUniInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnUniInfo.Image")));
            this.btnUniInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUniInfo.Location = new System.Drawing.Point(0, 236);
            this.btnUniInfo.Name = "btnUniInfo";
            this.btnUniInfo.Size = new System.Drawing.Size(196, 59);
            this.btnUniInfo.TabIndex = 2;
            this.btnUniInfo.Text = "University Info";
            this.btnUniInfo.UseVisualStyleBackColor = false;
            this.btnUniInfo.Click += new System.EventHandler(this.btnUniInfo_Click);
            // 
            // btnField
            // 
            this.btnField.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnField.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnField.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnField.Image = ((System.Drawing.Image)(resources.GetObject("btnField.Image")));
            this.btnField.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnField.Location = new System.Drawing.Point(0, 179);
            this.btnField.Name = "btnField";
            this.btnField.Size = new System.Drawing.Size(196, 59);
            this.btnField.TabIndex = 1;
            this.btnField.Text = "Field";
            this.btnField.UseVisualStyleBackColor = false;
            this.btnField.Click += new System.EventHandler(this.btnField_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(53, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pannel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Navigation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(7, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Form";
            // 
            // ContentPannel
            // 
            this.ContentPannel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ContentPannel.Controls.Add(this.dashboard1);
            this.ContentPannel.Controls.Add(this.semester1);
            this.ContentPannel.Controls.Add(this.userInfo1);
            this.ContentPannel.Controls.Add(this.updateUniField1);
            this.ContentPannel.Controls.Add(this.universityInfo1);
            this.ContentPannel.Controls.Add(this.insertUniField1);
            this.ContentPannel.Controls.Add(this.field2);
            this.ContentPannel.Controls.Add(this.deleteUniField1);
            this.ContentPannel.Controls.Add(this.field1);
            this.ContentPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPannel.Location = new System.Drawing.Point(196, 54);
            this.ContentPannel.Name = "ContentPannel";
            this.ContentPannel.Size = new System.Drawing.Size(702, 609);
            this.ContentPannel.TabIndex = 2;
            // 
            // HeaderPannel
            // 
            this.HeaderPannel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.HeaderPannel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HeaderPannel.BackgroundImage")));
            this.HeaderPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeaderPannel.Controls.Add(this.btnLogOut);
            this.HeaderPannel.Controls.Add(this.label3);
            this.HeaderPannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPannel.Location = new System.Drawing.Point(196, 0);
            this.HeaderPannel.Name = "HeaderPannel";
            this.HeaderPannel.Size = new System.Drawing.Size(702, 54);
            this.HeaderPannel.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(555, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(147, 54);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(165, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "University Info Center ";
            // 
            // dashboard1
            // 
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(702, 609);
            this.dashboard1.TabIndex = 8;
            // 
            // semester1
            // 
            this.semester1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.semester1.Location = new System.Drawing.Point(0, 0);
            this.semester1.Name = "semester1";
            this.semester1.Size = new System.Drawing.Size(702, 609);
            this.semester1.TabIndex = 7;
            // 
            // userInfo1
            // 
            this.userInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInfo1.Location = new System.Drawing.Point(0, 0);
            this.userInfo1.Name = "userInfo1";
            this.userInfo1.Size = new System.Drawing.Size(702, 609);
            this.userInfo1.TabIndex = 6;
            // 
            // updateUniField1
            // 
            this.updateUniField1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateUniField1.Location = new System.Drawing.Point(0, 0);
            this.updateUniField1.Name = "updateUniField1";
            this.updateUniField1.Size = new System.Drawing.Size(702, 609);
            this.updateUniField1.TabIndex = 5;
            // 
            // universityInfo1
            // 
            this.universityInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.universityInfo1.Location = new System.Drawing.Point(0, 0);
            this.universityInfo1.Name = "universityInfo1";
            this.universityInfo1.Size = new System.Drawing.Size(702, 609);
            this.universityInfo1.TabIndex = 4;
            // 
            // insertUniField1
            // 
            this.insertUniField1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertUniField1.Location = new System.Drawing.Point(0, 0);
            this.insertUniField1.Name = "insertUniField1";
            this.insertUniField1.Size = new System.Drawing.Size(702, 609);
            this.insertUniField1.TabIndex = 3;
            // 
            // field2
            // 
            this.field2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.field2.Location = new System.Drawing.Point(0, 0);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(702, 609);
            this.field2.TabIndex = 2;
            // 
            // deleteUniField1
            // 
            this.deleteUniField1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteUniField1.Location = new System.Drawing.Point(0, 0);
            this.deleteUniField1.Name = "deleteUniField1";
            this.deleteUniField1.Size = new System.Drawing.Size(702, 609);
            this.deleteUniField1.TabIndex = 1;
            // 
            // field1
            // 
            this.field1.Location = new System.Drawing.Point(0, 57);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(0, 0);
            this.field1.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(898, 663);
            this.ControlBox = false;
            this.Controls.Add(this.ContentPannel);
            this.Controls.Add(this.HeaderPannel);
            this.Controls.Add(this.NavigationPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.NavigationPannel.ResumeLayout(false);
            this.NavigationPannel.PerformLayout();
            this.ContentPannel.ResumeLayout(false);
            this.HeaderPannel.ResumeLayout(false);
            this.HeaderPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel NavigationPannel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnDeleteUni;
        private System.Windows.Forms.Button btnUpdateUni;
        private System.Windows.Forms.Button btnInsertUni;
        private System.Windows.Forms.Button btnUniInfo;
        private System.Windows.Forms.Button btnField;
        private System.Windows.Forms.Panel ContentPannel;
        private System.Windows.Forms.Panel HeaderPannel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Field field1;
        private DeleteUniField deleteUniField1;
        private Field field2;
        private InsertUniField insertUniField1;
        private UniversityInfo universityInfo1;
        private UpdateUniField updateUniField1;
        private UserInfo userInfo1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSemester;
        private Semester semester1;
        private Dashboard dashboard1;
    }
}