
using System;

namespace DermaPharm
{
    partial class AddMedicine1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateM = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddM = new Guna.UI2.WinForms.Guna2Button();
            this.txtPricePerUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExpireDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtManufacturingDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMediName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteM = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancelM = new Guna.UI2.WinForms.Guna2Button();
            this.MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-83, -49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 44);
            this.label10.TabIndex = 59;
            this.label10.Text = "AddMedicine";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 44);
            this.label1.TabIndex = 77;
            this.label1.Text = "Medicine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 28);
            this.label9.TabIndex = 75;
            this.label9.Text = "Price Per Unit";
            // 
            // btnUpdateM
            // 
            this.btnUpdateM.BorderRadius = 19;
            this.btnUpdateM.BorderThickness = 1;
            this.btnUpdateM.CheckedState.Parent = this.btnUpdateM;
            this.btnUpdateM.CustomImages.Parent = this.btnUpdateM;
            this.btnUpdateM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdateM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateM.ForeColor = System.Drawing.Color.White;
            this.btnUpdateM.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateM.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUpdateM.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdateM.HoverState.Parent = this.btnUpdateM;
            this.btnUpdateM.Location = new System.Drawing.Point(262, 546);
            this.btnUpdateM.Name = "btnUpdateM";
            this.btnUpdateM.ShadowDecoration.Parent = this.btnUpdateM;
            this.btnUpdateM.Size = new System.Drawing.Size(83, 40);
            this.btnUpdateM.TabIndex = 74;
            this.btnUpdateM.Text = "Update";
            this.btnUpdateM.Click += new System.EventHandler(this.btnUpdateM_Click);
            // 
            // btnAddM
            // 
            this.btnAddM.BorderRadius = 19;
            this.btnAddM.BorderThickness = 1;
            this.btnAddM.CheckedState.Parent = this.btnAddM;
            this.btnAddM.CustomImages.Parent = this.btnAddM;
            this.btnAddM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddM.ForeColor = System.Drawing.Color.White;
            this.btnAddM.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnAddM.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddM.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddM.HoverState.Parent = this.btnAddM;
            this.btnAddM.Location = new System.Drawing.Point(17, 546);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.ShadowDecoration.Parent = this.btnAddM;
            this.btnAddM.Size = new System.Drawing.Size(75, 40);
            this.btnAddM.TabIndex = 73;
            this.btnAddM.Text = "Add";
            this.btnAddM.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPricePerUnit.DefaultText = "";
            this.txtPricePerUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPricePerUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPricePerUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerUnit.DisabledState.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.FocusedState.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.ForeColor = System.Drawing.Color.Black;
            this.txtPricePerUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.HoverState.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.Location = new System.Drawing.Point(17, 474);
            this.txtPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.PasswordChar = '\0';
            this.txtPricePerUnit.PlaceholderText = "";
            this.txtPricePerUnit.SelectedText = "";
            this.txtPricePerUnit.ShadowDecoration.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.Size = new System.Drawing.Size(340, 36);
            this.txtPricePerUnit.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 28);
            this.label8.TabIndex = 71;
            this.label8.Text = " ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.Parent = this.txtQuantity;
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedState.Parent = this.txtQuantity;
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.HoverState.Parent = this.txtQuantity;
            this.txtQuantity.Location = new System.Drawing.Point(17, 387);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(340, 36);
            this.txtQuantity.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 28);
            this.label7.TabIndex = 69;
            this.label7.Text = "Quantity";
            // 
            // txtExpireDate
            // 
            this.txtExpireDate.BorderThickness = 1;
            this.txtExpireDate.CheckedState.Parent = this.txtExpireDate;
            this.txtExpireDate.FillColor = System.Drawing.Color.White;
            this.txtExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtExpireDate.HoverState.Parent = this.txtExpireDate;
            this.txtExpireDate.Location = new System.Drawing.Point(17, 296);
            this.txtExpireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtExpireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtExpireDate.Name = "txtExpireDate";
            this.txtExpireDate.ShadowDecoration.Parent = this.txtExpireDate;
            this.txtExpireDate.Size = new System.Drawing.Size(340, 36);
            this.txtExpireDate.TabIndex = 68;
            this.txtExpireDate.Value = new System.DateTime(2022, 4, 26, 18, 7, 35, 785);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 28);
            this.label6.TabIndex = 67;
            this.label6.Text = "Expire Date";
            // 
            // txtManufacturingDate
            // 
            this.txtManufacturingDate.BorderThickness = 1;
            this.txtManufacturingDate.CheckedState.Parent = this.txtManufacturingDate;
            this.txtManufacturingDate.FillColor = System.Drawing.Color.White;
            this.txtManufacturingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtManufacturingDate.HoverState.Parent = this.txtManufacturingDate;
            this.txtManufacturingDate.Location = new System.Drawing.Point(17, 214);
            this.txtManufacturingDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtManufacturingDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtManufacturingDate.Name = "txtManufacturingDate";
            this.txtManufacturingDate.ShadowDecoration.Parent = this.txtManufacturingDate;
            this.txtManufacturingDate.Size = new System.Drawing.Size(340, 36);
            this.txtManufacturingDate.TabIndex = 66;
            this.txtManufacturingDate.Value = new System.DateTime(2022, 4, 26, 18, 7, 35, 785);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 28);
            this.label5.TabIndex = 65;
            this.label5.Text = "Manufacturing Date";
            // 
            // txtMediName
            // 
            this.txtMediName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMediName.DefaultText = "";
            this.txtMediName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMediName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMediName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediName.DisabledState.Parent = this.txtMediName;
            this.txtMediName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediName.FocusedState.Parent = this.txtMediName;
            this.txtMediName.ForeColor = System.Drawing.Color.Black;
            this.txtMediName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediName.HoverState.Parent = this.txtMediName;
            this.txtMediName.Location = new System.Drawing.Point(17, 120);
            this.txtMediName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMediName.Name = "txtMediName";
            this.txtMediName.PasswordChar = '\0';
            this.txtMediName.PlaceholderText = "";
            this.txtMediName.SelectedText = "";
            this.txtMediName.ShadowDecoration.Parent = this.txtMediName;
            this.txtMediName.Size = new System.Drawing.Size(340, 36);
            this.txtMediName.TabIndex = 62;
            this.txtMediName.TextChanged += new System.EventHandler(this.txtMediName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Medicine Name";
            // 
            // btnDeleteM
            // 
            this.btnDeleteM.BorderRadius = 19;
            this.btnDeleteM.BorderThickness = 1;
            this.btnDeleteM.CheckedState.Parent = this.btnDeleteM;
            this.btnDeleteM.CustomImages.Parent = this.btnDeleteM;
            this.btnDeleteM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnDeleteM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteM.ForeColor = System.Drawing.Color.White;
            this.btnDeleteM.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteM.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDeleteM.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnDeleteM.HoverState.Parent = this.btnDeleteM;
            this.btnDeleteM.Location = new System.Drawing.Point(139, 546);
            this.btnDeleteM.Name = "btnDeleteM";
            this.btnDeleteM.ShadowDecoration.Parent = this.btnDeleteM;
            this.btnDeleteM.Size = new System.Drawing.Size(79, 40);
            this.btnDeleteM.TabIndex = 78;
            this.btnDeleteM.Text = "Delete";
            this.btnDeleteM.Click += new System.EventHandler(this.btnDeleteM_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineID,
            this.MedicineName,
            this.ManufacturingDate,
            this.ExpireDate,
            this.Quantity,
            this.PricePerUnit});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(378, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.Size = new System.Drawing.Size(696, 634);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btnCancelM
            // 
            this.btnCancelM.BorderRadius = 19;
            this.btnCancelM.BorderThickness = 1;
            this.btnCancelM.CheckedState.Parent = this.btnCancelM;
            this.btnCancelM.CustomImages.Parent = this.btnCancelM;
            this.btnCancelM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnCancelM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelM.ForeColor = System.Drawing.Color.White;
            this.btnCancelM.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnCancelM.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCancelM.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnCancelM.HoverState.Parent = this.btnCancelM;
            this.btnCancelM.Location = new System.Drawing.Point(114, 609);
            this.btnCancelM.Name = "btnCancelM";
            this.btnCancelM.ShadowDecoration.Parent = this.btnCancelM;
            this.btnCancelM.Size = new System.Drawing.Size(130, 48);
            this.btnCancelM.TabIndex = 81;
            this.btnCancelM.Text = "Cancel";
            this.btnCancelM.Click += new System.EventHandler(this.btnCancelM_Click);
            // 
            // MedicineID
            // 
            this.MedicineID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineID.DataPropertyName = "MedicineID";
            this.MedicineID.HeaderText = "MedicineID";
            this.MedicineID.MinimumWidth = 6;
            this.MedicineID.Name = "MedicineID";
            this.MedicineID.ReadOnly = true;
            this.MedicineID.Visible = false;
            // 
            // MedicineName
            // 
            this.MedicineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineName.DataPropertyName = "MedicineName";
            this.MedicineName.HeaderText = "Medicine Name";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.ReadOnly = true;
            // 
            // ManufacturingDate
            // 
            this.ManufacturingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManufacturingDate.DataPropertyName = "ManufacturingDate";
            this.ManufacturingDate.HeaderText = "Manufacturing Date";
            this.ManufacturingDate.MinimumWidth = 6;
            this.ManufacturingDate.Name = "ManufacturingDate";
            this.ManufacturingDate.ReadOnly = true;
            // 
            // ExpireDate
            // 
            this.ExpireDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpireDate.DataPropertyName = "ExpireDate";
            this.ExpireDate.HeaderText = "Expire Date";
            this.ExpireDate.MinimumWidth = 6;
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PricePerUnit.DataPropertyName = "PricePerUnit";
            this.PricePerUnit.HeaderText = "Price PerUnit";
            this.PricePerUnit.MinimumWidth = 6;
            this.PricePerUnit.Name = "PricePerUnit";
            this.PricePerUnit.ReadOnly = true;
            // 
            // AddMedicine1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 684);
            this.Controls.Add(this.btnCancelM);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnUpdateM);
            this.Controls.Add(this.btnAddM);
            this.Controls.Add(this.txtPricePerUnit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtExpireDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtManufacturingDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMediName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Name = "AddMedicine1";
            this.Text = "AddMedicine1";
            this.Load += new System.EventHandler(this.AddMedicine1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void plswork_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnUpdateM;
        private Guna.UI2.WinForms.Guna2Button btnAddM;
        private Guna.UI2.WinForms.Guna2TextBox txtPricePerUnit;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtExpireDate;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtManufacturingDate;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMediName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnDeleteM;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnCancelM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
    }
}