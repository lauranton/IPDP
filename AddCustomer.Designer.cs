
using System;

namespace DermaPharm
{
    partial class AddCustomer
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNrtel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdresa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancelC = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteC = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateC = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddC = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nrtel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.Nrtel,
            this.Adresa});
            this.dataGridView2.Location = new System.Drawing.Point(389, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(696, 634);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 44);
            this.label2.TabIndex = 78;
            this.label2.Text = "Customer";
            // 
            // txtCustID
            // 
            this.txtCustID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustID.DefaultText = "";
            this.txtCustID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustID.DisabledState.Parent = this.txtCustID;
            this.txtCustID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustID.FocusedState.Parent = this.txtCustID;
            this.txtCustID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustID.HoverState.Parent = this.txtCustID;
            this.txtCustID.Location = new System.Drawing.Point(30, 144);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.PasswordChar = '\0';
            this.txtCustID.PlaceholderText = "";
            this.txtCustID.SelectedText = "";
            this.txtCustID.ShadowDecoration.Parent = this.txtCustID;
            this.txtCustID.Size = new System.Drawing.Size(340, 36);
            this.txtCustID.TabIndex = 80;
            this.txtCustID.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 81;
            this.label1.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 83;
            this.label3.Text = "Nrtel";
            // 
            // txtNrtel
            // 
            this.txtNrtel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNrtel.DefaultText = "";
            this.txtNrtel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNrtel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNrtel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNrtel.DisabledState.Parent = this.txtNrtel;
            this.txtNrtel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNrtel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNrtel.FocusedState.Parent = this.txtNrtel;
            this.txtNrtel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNrtel.HoverState.Parent = this.txtNrtel;
            this.txtNrtel.Location = new System.Drawing.Point(30, 349);
            this.txtNrtel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNrtel.Name = "txtNrtel";
            this.txtNrtel.PasswordChar = '\0';
            this.txtNrtel.PlaceholderText = "";
            this.txtNrtel.SelectedText = "";
            this.txtNrtel.ShadowDecoration.Parent = this.txtNrtel;
            this.txtNrtel.Size = new System.Drawing.Size(340, 36);
            this.txtNrtel.TabIndex = 82;
            this.txtNrtel.TextChanged += new System.EventHandler(this.txtNrtel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 29);
            this.label4.TabIndex = 85;
            this.label4.Text = "Customer Name";
            // 
            // txtCustName
            // 
            this.txtCustName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustName.DefaultText = "";
            this.txtCustName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustName.DisabledState.Parent = this.txtCustName;
            this.txtCustName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustName.FocusedState.Parent = this.txtCustName;
            this.txtCustName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustName.HoverState.Parent = this.txtCustName;
            this.txtCustName.Location = new System.Drawing.Point(30, 247);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.PasswordChar = '\0';
            this.txtCustName.PlaceholderText = "";
            this.txtCustName.SelectedText = "";
            this.txtCustName.ShadowDecoration.Parent = this.txtCustName;
            this.txtCustName.Size = new System.Drawing.Size(340, 36);
            this.txtCustName.TabIndex = 84;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 87;
            this.label5.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdresa.DefaultText = "";
            this.txtAdresa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdresa.DisabledState.Parent = this.txtAdresa;
            this.txtAdresa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdresa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdresa.FocusedState.Parent = this.txtAdresa;
            this.txtAdresa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdresa.HoverState.Parent = this.txtAdresa;
            this.txtAdresa.Location = new System.Drawing.Point(30, 450);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.PasswordChar = '\0';
            this.txtAdresa.PlaceholderText = "";
            this.txtAdresa.SelectedText = "";
            this.txtAdresa.ShadowDecoration.Parent = this.txtAdresa;
            this.txtAdresa.Size = new System.Drawing.Size(340, 36);
            this.txtAdresa.TabIndex = 86;
            this.txtAdresa.TextChanged += new System.EventHandler(this.txtAdresa_TextChanged);
            // 
            // btnCancelC
            // 
            this.btnCancelC.BorderRadius = 19;
            this.btnCancelC.BorderThickness = 1;
            this.btnCancelC.CheckedState.Parent = this.btnCancelC;
            this.btnCancelC.CustomImages.Parent = this.btnCancelC;
            this.btnCancelC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnCancelC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelC.ForeColor = System.Drawing.Color.White;
            this.btnCancelC.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnCancelC.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCancelC.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnCancelC.HoverState.Parent = this.btnCancelC;
            this.btnCancelC.Location = new System.Drawing.Point(127, 594);
            this.btnCancelC.Name = "btnCancelC";
            this.btnCancelC.ShadowDecoration.Parent = this.btnCancelC;
            this.btnCancelC.Size = new System.Drawing.Size(130, 48);
            this.btnCancelC.TabIndex = 91;
            this.btnCancelC.Text = "Cancel";
            this.btnCancelC.Click += new System.EventHandler(this.btnCancelC_Click);
            // 
            // btnDeleteC
            // 
            this.btnDeleteC.BorderRadius = 19;
            this.btnDeleteC.BorderThickness = 1;
            this.btnDeleteC.CheckedState.Parent = this.btnDeleteC;
            this.btnDeleteC.CustomImages.Parent = this.btnDeleteC;
            this.btnDeleteC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnDeleteC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteC.ForeColor = System.Drawing.Color.White;
            this.btnDeleteC.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteC.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDeleteC.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnDeleteC.HoverState.Parent = this.btnDeleteC;
            this.btnDeleteC.Location = new System.Drawing.Point(152, 531);
            this.btnDeleteC.Name = "btnDeleteC";
            this.btnDeleteC.ShadowDecoration.Parent = this.btnDeleteC;
            this.btnDeleteC.Size = new System.Drawing.Size(79, 40);
            this.btnDeleteC.TabIndex = 90;
            this.btnDeleteC.Text = "Delete";
            this.btnDeleteC.Click += new System.EventHandler(this.btnDeleteC_Click);
            // 
            // btnUpdateC
            // 
            this.btnUpdateC.BorderRadius = 19;
            this.btnUpdateC.BorderThickness = 1;
            this.btnUpdateC.CheckedState.Parent = this.btnUpdateC;
            this.btnUpdateC.CustomImages.Parent = this.btnUpdateC;
            this.btnUpdateC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdateC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateC.ForeColor = System.Drawing.Color.White;
            this.btnUpdateC.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateC.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUpdateC.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdateC.HoverState.Parent = this.btnUpdateC;
            this.btnUpdateC.Location = new System.Drawing.Point(287, 531);
            this.btnUpdateC.Name = "btnUpdateC";
            this.btnUpdateC.ShadowDecoration.Parent = this.btnUpdateC;
            this.btnUpdateC.Size = new System.Drawing.Size(83, 40);
            this.btnUpdateC.TabIndex = 89;
            this.btnUpdateC.Text = "Update";
            // 
            // btnAddC
            // 
            this.btnAddC.BorderRadius = 19;
            this.btnAddC.BorderThickness = 1;
            this.btnAddC.CheckedState.Parent = this.btnAddC;
            this.btnAddC.CustomImages.Parent = this.btnAddC;
            this.btnAddC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddC.ForeColor = System.Drawing.Color.White;
            this.btnAddC.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnAddC.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddC.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddC.HoverState.Parent = this.btnAddC;
            this.btnAddC.Location = new System.Drawing.Point(30, 531);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.ShadowDecoration.Parent = this.btnAddC;
            this.btnAddC.Size = new System.Drawing.Size(75, 40);
            this.btnAddC.TabIndex = 88;
            this.btnAddC.Text = "Add";
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Nrtel
            // 
            this.Nrtel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nrtel.DataPropertyName = "Nrtel";
            this.Nrtel.HeaderText = "Nrtel";
            this.Nrtel.MinimumWidth = 6;
            this.Nrtel.Name = "Nrtel";
            this.Nrtel.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.MinimumWidth = 6;
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 684);
            this.Controls.Add(this.btnCancelC);
            this.Controls.Add(this.btnDeleteC);
            this.Controls.Add(this.btnUpdateC);
            this.Controls.Add(this.btnAddC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNrtel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtCustID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtNrtel;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtCustName;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtAdresa;
        private Guna.UI2.WinForms.Guna2Button btnCancelC;
        private Guna.UI2.WinForms.Guna2Button btnDeleteC;
        private Guna.UI2.WinForms.Guna2Button btnUpdateC;
        private Guna.UI2.WinForms.Guna2Button btnAddC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nrtel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
    }
}