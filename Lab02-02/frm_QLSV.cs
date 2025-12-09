using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class frm_QLSV : Form
    {
        public frm_QLSV()
        {
            InitializeComponent();
        }

        private void frm_QLSV_Load(object sender, EventArgs e)
        {
            // Thêm các cột vào DataGridView
            dgvStudent.Columns.Add("colMSSV", "MSSV");
            dgvStudent.Columns.Add("colHoTen", "Họ Tên");
            dgvStudent.Columns.Add("colGioiTinh", "Giới Tính");
            dgvStudent.Columns.Add("colDTB", "ĐTB");
            dgvStudent.Columns.Add("colKhoa", "Khoa");

            // Thiết lập SelectionMode để chọn cả dòng
            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Thêm 10 dữ liệu mẫu
            AddSampleData();
            UpdateCounts();
        }

        private void AddSampleData()
        {
            // Dữ liệu mẫu
            string[,] data = {
                {"2380600001", "Trần Quốc Anh", "Nam", "8.5", "QTKD"},
                {"2380600002", "Nguyễn Thị Mai", "Nữ", "9.0", "CNTT"},
                {"2380600003", "Lê Minh Tuấn", "Nam", "7.8", "NNA"},
                {"2380600004", "Phạm Hồng Ngọc", "Nữ", "6.5", "QTKD"}
            };

            for (int i = 0; i < data.GetLength(0); i++)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells["colMSSV"].Value = data[i, 0];
                dgvStudent.Rows[index].Cells["colHoTen"].Value = data[i, 1];
                dgvStudent.Rows[index].Cells["colGioiTinh"].Value = data[i, 2];
                dgvStudent.Rows[index].Cells["colDTB"].Value = data[i, 3];
                dgvStudent.Rows[index].Cells["colKhoa"].Value = data[i, 4];
            }

            // Thiết lập giá trị mặc định
            cmbFaculty.Items.AddRange(new string[] { "QTKD", "CNTT", "NNA" });
            cmbFaculty.SelectedIndex = 0;
            optFemale.Checked = true;
        }

        private int GetSelectedRowIndex(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells["colMSSV"].Value?.ToString() == studentID)
                    return i;
            }
            return -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = txtStudentID.Text.Trim();
                string fullName = txtFullName.Text.Trim();
                float averageScore = float.Parse(txtAverageScore.Text);
                string gender = optMale.Checked ? "Nam" : "Nữ";
                string faculty = cmbFaculty.Text;

                if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(txtAverageScore.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int rowIndex = GetSelectedRowIndex(studentID);

                if (rowIndex == -1) // Thêm mới
                {
                    // Kiểm tra xem MSSV đã tồn tại chưa
                    foreach (DataGridViewRow row in dgvStudent.Rows)
                    {
                        if (row.Cells["colMSSV"].Value?.ToString() == studentID)
                        {
                            MessageBox.Show("Mã SV đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    int index = dgvStudent.Rows.Add();
                    dgvStudent.Rows[index].Cells["colMSSV"].Value = studentID;
                    dgvStudent.Rows[index].Cells["colHoTen"].Value = fullName;
                    dgvStudent.Rows[index].Cells["colGioiTinh"].Value = gender;
                    dgvStudent.Rows[index].Cells["colDTB"].Value = averageScore;
                    dgvStudent.Rows[index].Cells["colKhoa"].Value = faculty;
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                }
                else // Cập nhật
                {
                    dgvStudent.Rows[rowIndex].Cells["colHoTen"].Value = fullName;
                    dgvStudent.Rows[rowIndex].Cells["colGioiTinh"].Value = gender;
                    dgvStudent.Rows[rowIndex].Cells["colDTB"].Value = averageScore;
                    dgvStudent.Rows[rowIndex].Cells["colKhoa"].Value = faculty;
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                }

                ResetForm();
                UpdateCounts();
            }
            catch (FormatException)
            {
                MessageBox.Show("Điểm TB phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text.Trim();
            int rowIndex = GetSelectedRowIndex(studentID);
            if (rowIndex == -1)
            {
                MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvStudent.Rows.RemoveAt(rowIndex);
                MessageBox.Show("Xóa sinh viên thành công!");
                ResetForm();
                UpdateCounts();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchKey = txtFullName.Text.Trim(); // Tìm theo tên
                string searchID = txtStudentID.Text.Trim(); // Tìm theo MSSV
                string searchFaculty = cmbFaculty.Text.Trim(); // Tìm theo khoa

                // Xóa toàn bộ dữ liệu hiện tại trong DataGridView
                dgvStudent.Rows.Clear();

                // Lọc lại dữ liệu dựa trên điều kiện tìm kiếm
                for (int i = 0; i < 10; i++) // Duyệt qua 10 bản ghi mẫu
                {
                    string id = $"10000{i + 1}";
                    string name = $"Nguyễn Văn {((char)('A' + i))}";
                    string gender = i % 2 == 0 ? "Nam" : "Nữ";
                    string score = (8.0 + i * 0.5).ToString();
                    string faculty = i % 3 == 0 ? "QTKD" : (i % 3 == 1 ? "CNTT" : "NNA");

                    // Kiểm tra điều kiện tìm kiếm
                    bool match = true;
                    if (!string.IsNullOrEmpty(searchID) && !id.Contains(searchID))
                        match = false;
                    if (!string.IsNullOrEmpty(searchKey) && !name.ToLower().Contains(searchKey.ToLower()))
                        match = false;
                    if (!string.IsNullOrEmpty(searchFaculty) && !faculty.Equals(searchFaculty, StringComparison.OrdinalIgnoreCase))
                        match = false;

                    if (match)
                    {
                        int index = dgvStudent.Rows.Add();
                        dgvStudent.Rows[index].Cells["colMSSV"].Value = id;
                        dgvStudent.Rows[index].Cells["colHoTen"].Value = name;
                        dgvStudent.Rows[index].Cells["colGioiTinh"].Value = gender;
                        dgvStudent.Rows[index].Cells["colDTB"].Value = score;
                        dgvStudent.Rows[index].Cells["colKhoa"].Value = faculty;
                    }
                }

                UpdateCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvStudent.Rows[e.RowIndex];
                txtStudentID.Text = row.Cells["colMSSV"].Value?.ToString();
                txtFullName.Text = row.Cells["colHoTen"].Value?.ToString();
                txtAverageScore.Text = row.Cells["colDTB"].Value?.ToString();
                cmbFaculty.Text = row.Cells["colKhoa"].Value?.ToString();

                if (row.Cells["colGioiTinh"].Value?.ToString() == "Nam")
                {
                    optMale.Checked = true;
                    optFemale.Checked = false;
                }
                else
                {
                    optFemale.Checked = true;
                    optMale.Checked = false;
                }
            }
        }

        private void UpdateCounts()
        {
            int maleCount = 0, femaleCount = 0;
            foreach (DataGridViewRow r in dgvStudent.Rows)
            {
                if (r.Cells["colGioiTinh"].Value?.ToString() == "Nam") maleCount++;
                else if (r.Cells["colGioiTinh"].Value?.ToString() == "Nữ") femaleCount++;
            }
            lblTotalMale.Text = $"Tổng SV Nam: {maleCount}";
            lblTotalFemale.Text = $"Nữ: {femaleCount}";
        }

        private void ResetForm()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            txtAverageScore.Clear();
            optFemale.Checked = true;
            cmbFaculty.SelectedIndex = 0;
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}