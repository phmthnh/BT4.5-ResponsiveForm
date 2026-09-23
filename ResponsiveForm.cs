using System;
using System.Windows.Forms;

namespace BT4_5_ResponsiveForm
{
    public partial class ResponsiveForm : Form
    {
        public ResponsiveForm()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private int recordCounter = 1;

        // Nạp dữ liệu mẫu vào DataGridView
        private void LoadSampleData()
        {
            dgvData.Columns.Add("ID",      "Mã");
            dgvData.Columns.Add("Name",    "Họ Tên");
            dgvData.Columns.Add("Email",   "Email");
            dgvData.Columns.Add("Phone",   "Điện Thoại");

            dgvData.Columns["ID"].Width    = 60;
            dgvData.Columns["Name"].Width  = 150;
            dgvData.Columns["Email"].Width = 180;
            dgvData.Columns["Phone"].Width = 120;

            // Dữ liệu mẫu
            dgvData.Rows.Add("001", "Nguyễn Văn An",   "an@email.com",   "0901 234 567");
            dgvData.Rows.Add("002", "Trần Thị Bình",   "binh@email.com", "0912 345 678");
            dgvData.Rows.Add("003", "Lê Văn Cường",    "cuong@email.com","0923 456 789");
            recordCounter = 4;
        }

        // Nút Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            string id    = recordCounter.ToString("D3");
            string name  = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            dgvData.Rows.Add(id, name, email, phone);
            recordCounter++;
            ClearInputs();
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút Xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
                dgvData.Rows.Remove(dgvData.SelectedRows[0]);
        }

        // Nút Xóa Dữ Liệu (clear form)
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtName.Focus();
        }
    }
}
