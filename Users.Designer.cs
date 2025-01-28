namespace PROJECT_ONT23
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.label2 = new System.Windows.Forms.Label();
            this.btnUserManSystemExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserSurname = new System.Windows.Forms.TextBox();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.cmbUserStatus = new System.Windows.Forms.ComboBox();
            this.dgvDisplayUsers = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnUserManExit = new System.Windows.Forms.Button();
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbUserTitle = new System.Windows.Forms.ComboBox();
            this.cmbFilterByRole = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFilterUserName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(267, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "USERS MANAGEMENT SYSTEM";
            // 
            // btnUserManSystemExit
            // 
            this.btnUserManSystemExit.BackColor = System.Drawing.Color.Transparent;
            this.btnUserManSystemExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManSystemExit.FlatAppearance.BorderSize = 0;
            this.btnUserManSystemExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManSystemExit.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManSystemExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUserManSystemExit.Location = new System.Drawing.Point(810, -3);
            this.btnUserManSystemExit.Name = "btnUserManSystemExit";
            this.btnUserManSystemExit.Size = new System.Drawing.Size(40, 40);
            this.btnUserManSystemExit.TabIndex = 6;
            this.btnUserManSystemExit.Text = "X";
            this.btnUserManSystemExit.UseVisualStyleBackColor = false;
            this.btnUserManSystemExit.Click += new System.EventHandler(this.btnUserManSystemExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "User ID*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(166, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Title*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(387, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(625, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Surname*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Role*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(166, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(387, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(625, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "UserStatus*";
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(3, 59);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(133, 21);
            this.txtUserID.TabIndex = 16;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(390, 59);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(210, 21);
            this.txtUserName.TabIndex = 17;
            // 
            // txtUserSurname
            // 
            this.txtUserSurname.Location = new System.Drawing.Point(628, 59);
            this.txtUserSurname.Name = "txtUserSurname";
            this.txtUserSurname.Size = new System.Drawing.Size(210, 21);
            this.txtUserSurname.TabIndex = 18;
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Location = new System.Drawing.Point(3, 111);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(133, 24);
            this.cmbUserRole.TabIndex = 19;
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(169, 111);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(199, 21);
            this.txtUserEmail.TabIndex = 20;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(390, 111);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(210, 21);
            this.txtUserPassword.TabIndex = 21;
            // 
            // cmbUserStatus
            // 
            this.cmbUserStatus.FormattingEnabled = true;
            this.cmbUserStatus.Location = new System.Drawing.Point(628, 111);
            this.cmbUserStatus.Name = "cmbUserStatus";
            this.cmbUserStatus.Size = new System.Drawing.Size(168, 24);
            this.cmbUserStatus.TabIndex = 22;
            // 
            // dgvDisplayUsers
            // 
            this.dgvDisplayUsers.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDisplayUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayUsers.Location = new System.Drawing.Point(12, 223);
            this.dgvDisplayUsers.Name = "dgvDisplayUsers";
            this.dgvDisplayUsers.Size = new System.Drawing.Size(827, 271);
            this.dgvDisplayUsers.TabIndex = 23;
            this.dgvDisplayUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayUsers_CellClick);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddUser.Location = new System.Drawing.Point(654, 500);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 26;
            this.btnAddUser.Text = "ADD";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateUser.Location = new System.Drawing.Point(749, 500);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUser.TabIndex = 29;
            this.btnUpdateUser.Text = "UPDATE";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnUserManExit
            // 
            this.btnUserManExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUserManExit.FlatAppearance.BorderSize = 0;
            this.btnUserManExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManExit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUserManExit.Location = new System.Drawing.Point(15, 500);
            this.btnUserManExit.Name = "btnUserManExit";
            this.btnUserManExit.Size = new System.Drawing.Size(75, 23);
            this.btnUserManExit.TabIndex = 32;
            this.btnUserManExit.Text = "EXIT";
            this.btnUserManExit.UseVisualStyleBackColor = false;
            this.btnUserManExit.Click += new System.EventHandler(this.btnUserManExit_Click);
            // 
            // btnRefreshUsers
            // 
            this.btnRefreshUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRefreshUsers.FlatAppearance.BorderSize = 0;
            this.btnRefreshUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshUsers.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshUsers.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRefreshUsers.Location = new System.Drawing.Point(103, 500);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshUsers.TabIndex = 33;
            this.btnRefreshUsers.Text = "REFRESH";
            this.btnRefreshUsers.UseVisualStyleBackColor = false;
            this.btnRefreshUsers.Click += new System.EventHandler(this.btnRefreshUsers_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Filter By Role:";
            // 
            // cmbUserTitle
            // 
            this.cmbUserTitle.FormattingEnabled = true;
            this.cmbUserTitle.Location = new System.Drawing.Point(169, 59);
            this.cmbUserTitle.Name = "cmbUserTitle";
            this.cmbUserTitle.Size = new System.Drawing.Size(199, 24);
            this.cmbUserTitle.TabIndex = 36;
            // 
            // cmbFilterByRole
            // 
            this.cmbFilterByRole.FormattingEnabled = true;
            this.cmbFilterByRole.Location = new System.Drawing.Point(89, 194);
            this.cmbFilterByRole.Name = "cmbFilterByRole";
            this.cmbFilterByRole.Size = new System.Drawing.Size(133, 24);
            this.cmbFilterByRole.TabIndex = 39;
            this.cmbFilterByRole.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(328, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 40;
            this.label11.Text = "Filter By Name:";
            // 
            // txtFilterUserName
            // 
            this.txtFilterUserName.Location = new System.Drawing.Point(427, 194);
            this.txtFilterUserName.Name = "txtFilterUserName";
            this.txtFilterUserName.Size = new System.Drawing.Size(210, 21);
            this.txtFilterUserName.TabIndex = 41;
            this.txtFilterUserName.TextChanged += new System.EventHandler(this.txtFilterUserName_TextChanged);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 530);
            this.ControlBox = false;
            this.Controls.Add(this.txtFilterUserName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbFilterByRole);
            this.Controls.Add(this.cmbUserTitle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRefreshUsers);
            this.Controls.Add(this.btnUserManExit);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.dgvDisplayUsers);
            this.Controls.Add(this.cmbUserStatus);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.cmbUserRole);
            this.Controls.Add(this.txtUserSurname);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUserManSystemExit);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUserManSystemExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserSurname;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.ComboBox cmbUserStatus;
        private System.Windows.Forms.DataGridView dgvDisplayUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnUserManExit;
        private System.Windows.Forms.Button btnRefreshUsers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbUserTitle;
        private System.Windows.Forms.ComboBox cmbFilterByRole;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFilterUserName;
    }
}