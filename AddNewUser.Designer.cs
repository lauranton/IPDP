
namespace DermaFram
{
    partial class AddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backdash = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtnewuseName = new System.Windows.Forms.TextBox();
            this.newUserAdd = new Guna.UI2.WinForms.Guna2Button();
            this.newuserName = new System.Windows.Forms.Label();
            this.HireDatelabel = new System.Windows.Forms.Label();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.newUserUsername = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.newUserpassword = new System.Windows.Forms.Label();
            this.txtnewuserPassword = new System.Windows.Forms.TextBox();
            this.NewUserDelete = new Guna.UI2.WinForms.Guna2Button();
            this.NewUserCancel = new Guna.UI2.WinForms.Guna2Button();
            this.NewUserupdate = new Guna.UI2.WinForms.Guna2Button();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backdash
            // 
            this.backdash.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.backdash.CheckedState.FillColor = System.Drawing.Color.White;
            this.backdash.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.backdash.CheckedState.Parent = this.backdash;
            this.backdash.CustomImages.Parent = this.backdash;
            this.backdash.FillColor = System.Drawing.Color.LightGray;
            this.backdash.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.backdash.ForeColor = System.Drawing.Color.Black;
            this.backdash.HoverState.Parent = this.backdash;
            this.backdash.Image = ((System.Drawing.Image)(resources.GetObject("backdash.Image")));
            this.backdash.ImageSize = new System.Drawing.Size(40, 40);
            this.backdash.Location = new System.Drawing.Point(17, 14);
            this.backdash.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.backdash.Name = "backdash";
            this.backdash.ShadowDecoration.Parent = this.backdash;
            this.backdash.Size = new System.Drawing.Size(223, 114);
            this.backdash.TabIndex = 7;
            this.backdash.Text = "Dashbord";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userID,
            this.hireDate,
            this.username,
            this.password,
            this.Name});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(507, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.Size = new System.Drawing.Size(750, 646);
            this.dataGridView1.TabIndex = 9;
            // 
            // txtnewuseName
            // 
            this.txtnewuseName.Location = new System.Drawing.Point(58, 204);
            this.txtnewuseName.Margin = new System.Windows.Forms.Padding(4);
            this.txtnewuseName.Multiline = true;
            this.txtnewuseName.Name = "txtnewuseName";
            this.txtnewuseName.Size = new System.Drawing.Size(404, 55);
            this.txtnewuseName.TabIndex = 10;
            // 
            // newUserAdd
            // 
            this.newUserAdd.AutoRoundedCorners = true;
            this.newUserAdd.BorderRadius = 27;
            this.newUserAdd.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.newUserAdd.CheckedState.Parent = this.newUserAdd;
            this.newUserAdd.CustomImages.Parent = this.newUserAdd;
            this.newUserAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newUserAdd.ForeColor = System.Drawing.Color.White;
            this.newUserAdd.HoverState.Parent = this.newUserAdd;
            this.newUserAdd.Location = new System.Drawing.Point(58, 604);
            this.newUserAdd.Margin = new System.Windows.Forms.Padding(4);
            this.newUserAdd.Name = "newUserAdd";
            this.newUserAdd.ShadowDecoration.Parent = this.newUserAdd;
            this.newUserAdd.Size = new System.Drawing.Size(95, 56);
            this.newUserAdd.TabIndex = 11;
            this.newUserAdd.Text = "Add";
            this.newUserAdd.Click += new System.EventHandler(this.newUserAdd_Click);
            // 
            // newuserName
            // 
            this.newuserName.AutoSize = true;
            this.newuserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newuserName.Location = new System.Drawing.Point(62, 176);
            this.newuserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newuserName.Name = "newuserName";
            this.newuserName.Size = new System.Drawing.Size(66, 24);
            this.newuserName.TabIndex = 12;
            this.newuserName.Text = "Nume";
            this.newuserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // HireDatelabel
            // 
            this.HireDatelabel.AutoSize = true;
            this.HireDatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HireDatelabel.Location = new System.Drawing.Point(62, 288);
            this.HireDatelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HireDatelabel.Name = "HireDatelabel";
            this.HireDatelabel.Size = new System.Drawing.Size(97, 24);
            this.HireDatelabel.TabIndex = 14;
            this.HireDatelabel.Text = "Hire Date";
            this.HireDatelabel.Click += new System.EventHandler(this.HireDate_Click);
            // 
            // txtHireDate
            // 
            this.txtHireDate.Location = new System.Drawing.Point(58, 316);
            this.txtHireDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtHireDate.Multiline = true;
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(404, 55);
            this.txtHireDate.TabIndex = 13;
            // 
            // newUserUsername
            // 
            this.newUserUsername.AutoSize = true;
            this.newUserUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newUserUsername.Location = new System.Drawing.Point(62, 390);
            this.newUserUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newUserUsername.Name = "newUserUsername";
            this.newUserUsername.Size = new System.Drawing.Size(105, 24);
            this.newUserUsername.TabIndex = 16;
            this.newUserUsername.Text = "Username";
            this.newUserUsername.Click += new System.EventHandler(this.newUserUsername_Click);
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(58, 418);
            this.txtNewUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewUsername.Multiline = true;
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(404, 55);
            this.txtNewUsername.TabIndex = 15;
            // 
            // newUserpassword
            // 
            this.newUserpassword.AutoSize = true;
            this.newUserpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newUserpassword.Location = new System.Drawing.Point(62, 496);
            this.newUserpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newUserpassword.Name = "newUserpassword";
            this.newUserpassword.Size = new System.Drawing.Size(100, 24);
            this.newUserpassword.TabIndex = 18;
            this.newUserpassword.Text = "Password";
            this.newUserpassword.Click += new System.EventHandler(this.newUserpassword_Click);
            // 
            // txtnewuserPassword
            // 
            this.txtnewuserPassword.Location = new System.Drawing.Point(58, 524);
            this.txtnewuserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtnewuserPassword.Multiline = true;
            this.txtnewuserPassword.Name = "txtnewuserPassword";
            this.txtnewuserPassword.Size = new System.Drawing.Size(404, 58);
            this.txtnewuserPassword.TabIndex = 17;
            // 
            // NewUserDelete
            // 
            this.NewUserDelete.AutoRoundedCorners = true;
            this.NewUserDelete.BorderRadius = 27;
            this.NewUserDelete.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.NewUserDelete.CheckedState.Parent = this.NewUserDelete;
            this.NewUserDelete.CustomImages.Parent = this.NewUserDelete;
            this.NewUserDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewUserDelete.ForeColor = System.Drawing.Color.White;
            this.NewUserDelete.HoverState.Parent = this.NewUserDelete;
            this.NewUserDelete.Location = new System.Drawing.Point(161, 604);
            this.NewUserDelete.Margin = new System.Windows.Forms.Padding(4);
            this.NewUserDelete.Name = "NewUserDelete";
            this.NewUserDelete.ShadowDecoration.Parent = this.NewUserDelete;
            this.NewUserDelete.Size = new System.Drawing.Size(95, 56);
            this.NewUserDelete.TabIndex = 19;
            this.NewUserDelete.Text = "Delete";
            // 
            // NewUserCancel
            // 
            this.NewUserCancel.AutoRoundedCorners = true;
            this.NewUserCancel.BorderRadius = 27;
            this.NewUserCancel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.NewUserCancel.CheckedState.Parent = this.NewUserCancel;
            this.NewUserCancel.CustomImages.Parent = this.NewUserCancel;
            this.NewUserCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewUserCancel.ForeColor = System.Drawing.Color.White;
            this.NewUserCancel.HoverState.Parent = this.NewUserCancel;
            this.NewUserCancel.Location = new System.Drawing.Point(367, 604);
            this.NewUserCancel.Margin = new System.Windows.Forms.Padding(4);
            this.NewUserCancel.Name = "NewUserCancel";
            this.NewUserCancel.ShadowDecoration.Parent = this.NewUserCancel;
            this.NewUserCancel.Size = new System.Drawing.Size(95, 56);
            this.NewUserCancel.TabIndex = 20;
            this.NewUserCancel.Text = "Cancel";
            this.NewUserCancel.Click += new System.EventHandler(this.NewUserCancel_Click);
            // 
            // NewUserupdate
            // 
            this.NewUserupdate.AutoRoundedCorners = true;
            this.NewUserupdate.BorderRadius = 27;
            this.NewUserupdate.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.NewUserupdate.CheckedState.Parent = this.NewUserupdate;
            this.NewUserupdate.CustomImages.Parent = this.NewUserupdate;
            this.NewUserupdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewUserupdate.ForeColor = System.Drawing.Color.White;
            this.NewUserupdate.HoverState.Parent = this.NewUserupdate;
            this.NewUserupdate.Location = new System.Drawing.Point(264, 604);
            this.NewUserupdate.Margin = new System.Windows.Forms.Padding(4);
            this.NewUserupdate.Name = "NewUserupdate";
            this.NewUserupdate.ShadowDecoration.Parent = this.NewUserupdate;
            this.NewUserupdate.Size = new System.Drawing.Size(95, 56);
            this.NewUserupdate.TabIndex = 21;
            this.NewUserupdate.Text = "Update";
            // 
            // userID
            // 
            this.userID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userID.DataPropertyName = "userID";
            this.userID.HeaderText = "userID";
            this.userID.Name = "userID";
            // 
            // hireDate
            // 
            this.hireDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hireDate.DataPropertyName = "hireDate";
            this.hireDate.HeaderText = "hireDate";
            this.hireDate.Name = "hireDate";
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "username";
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "password";
            this.password.Name = "password";
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name ";
            this.Name.Name = "Name";
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.NewUserupdate);
            this.Controls.Add(this.NewUserCancel);
            this.Controls.Add(this.NewUserDelete);
            this.Controls.Add(this.newUserpassword);
            this.Controls.Add(this.txtnewuserPassword);
            this.Controls.Add(this.newUserUsername);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.HireDatelabel);
            this.Controls.Add(this.txtHireDate);
            this.Controls.Add(this.newuserName);
            this.Controls.Add(this.newUserAdd);
            this.Controls.Add(this.txtnewuseName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backdash);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name.Name = "AddNewUser";
            this.Text = "AddNewUser";
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button backdash;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtnewuseName;
        private Guna.UI2.WinForms.Guna2Button newUserAdd;
        private System.Windows.Forms.Label newuserName;
        private System.Windows.Forms.Label HireDatelabel;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.Label newUserUsername;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label newUserpassword;
        private System.Windows.Forms.TextBox txtnewuserPassword;
        private Guna.UI2.WinForms.Guna2Button NewUserDelete;
        private Guna.UI2.WinForms.Guna2Button NewUserCancel;
        private Guna.UI2.WinForms.Guna2Button NewUserupdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    }
}