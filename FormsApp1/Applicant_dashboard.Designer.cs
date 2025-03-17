using Guna.UI2.WinForms;

namespace FormsApp1
{
    partial class Applicant_dashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private Guna.UI2.WinForms.Guna2Button btnNewApplication;
        private Guna.UI2.WinForms.Guna2Button btnViewApplication;
        private Guna.UI2.WinForms.Guna2Button btnUploadDocuments;
        private Guna.UI2.WinForms.Guna2Button btnMakePayment;
        private Guna.UI2.WinForms.Guna2Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnNewApplication = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewApplication = new Guna.UI2.WinForms.Guna2Button();
            this.btnUploadDocuments = new Guna.UI2.WinForms.Guna2Button();
            this.btnMakePayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.testDataSet = new FormsApp1.testDataSet();
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Applied_universities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvApplications = new Guna.UI2.WinForms.Guna2DataGridView();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formappBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formapp = new FormsApp1.formapp();
            this.applieduniversitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet1 = new FormsApp1.testDataSet1();
            this.testDataSet2 = new FormsApp1.testDataSet2();
            this.testDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new FormsApp1.testDataSet1TableAdapters.userTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formappBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new FormsApp1.formappTableAdapters.usersTableAdapter();
            this.applied_universitiesTableAdapter = new FormsApp1.formappTableAdapters.applied_universitiesTableAdapter();
            this.fKapplicantusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicant_infoTableAdapter = new FormsApp1.formappTableAdapters.applicant_infoTableAdapter();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formappBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formapp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applieduniversitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formappBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKapplicantusersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(327, 48);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(129, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "List of Applied univercities";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnNewApplication
            // 
            this.btnNewApplication.BorderRadius = 4;
            this.btnNewApplication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNewApplication.ForeColor = System.Drawing.Color.White;
            this.btnNewApplication.Location = new System.Drawing.Point(1, 408);
            this.btnNewApplication.Name = "btnNewApplication";
            this.btnNewApplication.Size = new System.Drawing.Size(180, 30);
            this.btnNewApplication.TabIndex = 2;
            this.btnNewApplication.Text = "New Application";
            this.btnNewApplication.Click += new System.EventHandler(this.btnNewApplication_Click);
            // 
            // btnViewApplication
            // 
            this.btnViewApplication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewApplication.ForeColor = System.Drawing.Color.White;
            this.btnViewApplication.Location = new System.Drawing.Point(533, 408);
            this.btnViewApplication.Name = "btnViewApplication";
            this.btnViewApplication.Size = new System.Drawing.Size(178, 30);
            this.btnViewApplication.TabIndex = 3;
            this.btnViewApplication.Text = "View Application";
            this.btnViewApplication.Click += new System.EventHandler(this.btnViewApplication_Click);
            // 
            // btnUploadDocuments
            // 
            this.btnUploadDocuments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUploadDocuments.ForeColor = System.Drawing.Color.White;
            this.btnUploadDocuments.Location = new System.Drawing.Point(352, 408);
            this.btnUploadDocuments.Name = "btnUploadDocuments";
            this.btnUploadDocuments.Size = new System.Drawing.Size(175, 30);
            this.btnUploadDocuments.TabIndex = 4;
            this.btnUploadDocuments.Text = "Upload Documents";
            this.btnUploadDocuments.Click += new System.EventHandler(this.btnUploadDocuments_Click);
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMakePayment.ForeColor = System.Drawing.Color.White;
            this.btnMakePayment.Location = new System.Drawing.Point(187, 408);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(159, 30);
            this.btnMakePayment.TabIndex = 5;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(717, 408);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            this.testDataSetBindingSource.CurrentChanged += new System.EventHandler(this.testDataSetBindingSource_CurrentChanged);
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.status.Frozen = true;
            this.status.HeaderText = "status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // Applied_universities
            // 
            this.Applied_universities.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Applied_universities.Frozen = true;
            this.Applied_universities.HeaderText = "Applied_universities";
            this.Applied_universities.MinimumWidth = 50;
            this.Applied_universities.Name = "Applied_universities";
            this.Applied_universities.ReadOnly = true;
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.dgvApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvApplications.AutoGenerateColumns = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Applied_universities,
            this.status,
            this.useridDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn});
            this.dgvApplications.DataSource = this.usersBindingSource1;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplications.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvApplications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.dgvApplications.Location = new System.Drawing.Point(91, 95);
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.Size = new System.Drawing.Size(667, 266);
            this.dgvApplications.TabIndex = 1;
            this.dgvApplications.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.SunFlower;
            this.dgvApplications.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.dgvApplications.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvApplications.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvApplications.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvApplications.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvApplications.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvApplications.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.dgvApplications.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.dgvApplications.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvApplications.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvApplications.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvApplications.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvApplications.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvApplications.ThemeStyle.ReadOnly = true;
            this.dgvApplications.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.dgvApplications.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvApplications.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvApplications.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvApplications.ThemeStyle.RowsStyle.Height = 22;
            this.dgvApplications.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            this.dgvApplications.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvApplications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplications_CellContentClick);
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.formappBindingSource;
            // 
            // formappBindingSource
            // 
            this.formappBindingSource.DataSource = this.formapp;
            this.formappBindingSource.Position = 0;
            this.formappBindingSource.CurrentChanged += new System.EventHandler(this.formappBindingSource_CurrentChanged);
            // 
            // formapp
            // 
            this.formapp.DataSetName = "formapp";
            this.formapp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applieduniversitiesBindingSource
            // 
            this.applieduniversitiesBindingSource.DataMember = "applied_universities";
            this.applieduniversitiesBindingSource.DataSource = this.formappBindingSource;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.testDataSet1;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "testDataSet1";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDataSet2
            // 
            this.testDataSet2.DataSetName = "testDataSet2";
            this.testDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDataSet2BindingSource
            // 
            this.testDataSet2BindingSource.DataSource = this.testDataSet2;
            this.testDataSet2BindingSource.Position = 0;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.formappBindingSource;
            // 
            // formappBindingSource1
            // 
            this.formappBindingSource1.DataSource = this.formapp;
            this.formappBindingSource1.Position = 0;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // applied_universitiesTableAdapter
            // 
            this.applied_universitiesTableAdapter.ClearBeforeFill = true;
            // 
            // fKapplicantusersBindingSource
            // 
            this.fKapplicantusersBindingSource.DataMember = "FK_applicant_users";
            this.fKapplicantusersBindingSource.DataSource = this.usersBindingSource1;
            // 
            // applicant_infoTableAdapter
            // 
            this.applicant_infoTableAdapter.ClearBeforeFill = true;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            this.updatedatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Applicant_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnNewApplication);
            this.Controls.Add(this.btnViewApplication);
            this.Controls.Add(this.btnUploadDocuments);
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dgvApplications);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Applicant_dashboard";
            this.Text = "Applicant Dashboard";
            this.Load += new System.EventHandler(this.Applicant_dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formappBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formapp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applieduniversitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formappBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKapplicantusersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private testDataSet testDataSet;
        private testDataSet1 testDataSet1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private testDataSet1TableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Applied_universities;
        private Guna.UI2.WinForms.Guna2DataGridView dgvApplications;
        private System.Windows.Forms.BindingSource testDataSet2BindingSource;
        private testDataSet2 testDataSet2;
        private System.Windows.Forms.BindingSource formappBindingSource;
        private formapp formapp;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private formappTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource formappBindingSource1;
        private System.Windows.Forms.BindingSource applieduniversitiesBindingSource;
        private formappTableAdapters.applied_universitiesTableAdapter applied_universitiesTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource fKapplicantusersBindingSource;
        private formappTableAdapters.applicant_infoTableAdapter applicant_infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}    //hi! gohar just testing