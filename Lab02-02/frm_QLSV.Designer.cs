namespace Lab02_02
{
    partial class frm_QLSV
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.optMale = new System.Windows.Forms.RadioButton();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.optFemale = new System.Windows.Forms.RadioButton();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalMale = new System.Windows.Forms.Label();
            this.lblTotalFemale = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(274, 49);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(617, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.txtFullName);
            this.grpInput.Controls.Add(this.lblStudentID);
            this.grpInput.Controls.Add(this.txtStudentID);
            this.grpInput.Controls.Add(this.lblFullName);
            this.grpInput.Controls.Add(this.lblGender);
            this.grpInput.Controls.Add(this.optMale);
            this.grpInput.Controls.Add(this.cmbFaculty);
            this.grpInput.Controls.Add(this.optFemale);
            this.grpInput.Controls.Add(this.lblFaculty);
            this.grpInput.Controls.Add(this.lblAverageScore);
            this.grpInput.Controls.Add(this.txtAverageScore);
            this.grpInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpInput.Location = new System.Drawing.Point(49, 118);
            this.grpInput.Margin = new System.Windows.Forms.Padding(2);
            this.grpInput.Name = "grpInput";
            this.grpInput.Padding = new System.Windows.Forms.Padding(2);
            this.grpInput.Size = new System.Drawing.Size(354, 244);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông Tin Sinh Viên";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(78, 68);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(180, 23);
            this.txtFullName.TabIndex = 3;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(10, 24);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(53, 17);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Mã SV:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(78, 23);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(180, 23);
            this.txtStudentID.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(301, 387);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 24);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(10, 70);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 17);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Họ tên:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(217, 387);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(68, 24);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Thêm/Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(10, 113);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 17);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Giới tính:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(156, 387);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 24);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.Location = new System.Drawing.Point(118, 111);
            this.optMale.Margin = new System.Windows.Forms.Padding(2);
            this.optMale.Name = "optMale";
            this.optMale.Size = new System.Drawing.Size(55, 21);
            this.optMale.TabIndex = 5;
            this.optMale.TabStop = true;
            this.optMale.Text = "Nam";
            this.optMale.UseVisualStyleBackColor = true;
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(78, 194);
            this.cmbFaculty.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(136, 24);
            this.cmbFaculty.TabIndex = 10;
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.Location = new System.Drawing.Point(196, 113);
            this.optFemale.Margin = new System.Windows.Forms.Padding(2);
            this.optFemale.Name = "optFemale";
            this.optFemale.Size = new System.Drawing.Size(44, 21);
            this.optFemale.TabIndex = 6;
            this.optFemale.TabStop = true;
            this.optFemale.Text = "Nữ";
            this.optFemale.UseVisualStyleBackColor = true;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(10, 195);
            this.lblFaculty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(45, 17);
            this.lblFaculty.TabIndex = 9;
            this.lblFaculty.Text = "Khoa:";
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.AutoSize = true;
            this.lblAverageScore.Location = new System.Drawing.Point(10, 156);
            this.lblAverageScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(66, 17);
            this.lblAverageScore.TabIndex = 7;
            this.lblAverageScore.Text = "Điểm TB:";
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(78, 154);
            this.txtAverageScore.Margin = new System.Windows.Forms.Padding(2);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(136, 23);
            this.txtAverageScore.TabIndex = 8;
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(407, 118);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(705, 244);
            this.dgvStudent.TabIndex = 14;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // colMSSV
            // 
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.MinimumWidth = 6;
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.Width = 120;
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 200;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // colDTB
            // 
            this.colDTB.HeaderText = "ĐTB";
            this.colDTB.MinimumWidth = 6;
            this.colDTB.Name = "colDTB";
            // 
            // colKhoa
            // 
            this.colKhoa.HeaderText = "Khoa";
            this.colKhoa.MinimumWidth = 6;
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.Width = 150;
            // 
            // lblTotalMale
            // 
            this.lblTotalMale.AutoSize = true;
            this.lblTotalMale.Location = new System.Drawing.Point(908, 384);
            this.lblTotalMale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalMale.Name = "lblTotalMale";
            this.lblTotalMale.Size = new System.Drawing.Size(86, 13);
            this.lblTotalMale.TabIndex = 15;
            this.lblTotalMale.Text = "Tổng SV Nam: 0";
            // 
            // lblTotalFemale
            // 
            this.lblTotalFemale.AutoSize = true;
            this.lblTotalFemale.Location = new System.Drawing.Point(1014, 384);
            this.lblTotalFemale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalFemale.Name = "lblTotalFemale";
            this.lblTotalFemale.Size = new System.Drawing.Size(33, 13);
            this.lblTotalFemale.TabIndex = 16;
            this.lblTotalFemale.Text = "Nữ: 0";
            // 
            // frm_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 511);
            this.Controls.Add(this.lblTotalFemale);
            this.Controls.Add(this.lblTotalMale);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_QLSV";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frm_QLSV_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton optMale;
        private System.Windows.Forms.RadioButton optFemale;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.Label lblTotalMale;
        private System.Windows.Forms.Label lblTotalFemale;
    }
}